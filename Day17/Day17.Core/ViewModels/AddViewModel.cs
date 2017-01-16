using System;
using System.IO;
using Day17.Core.Services.Collections;
using Day17.Core.Services.DataStore;
using Day17.Core.Services.Location;
using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.File;
using MvvmCross.Plugins.Messenger;
using MvvmCross.Plugins.PictureChooser;

namespace Day17.Core.ViewModels
{
    public class AddViewModel : BaseViewModel
    {
        private readonly IMvxPictureChooserTask _pictureChooserTask;
        private readonly IMvxFileStore _fileStore;
        private MvxCommand _saveCommand;
        private MvxCommand _addPictureCommand;
        private byte[] _pictureBytes;

        public AddViewModel(ICollectionService collectionService, ILocationService locationService, 
            IMvxMessenger messenger, IMvxPictureChooserTask pictureChooserTask,
            IMvxFileStore fileStore) 
            : base(collectionService, locationService, messenger)
        {
            _pictureChooserTask = pictureChooserTask;
            _fileStore = fileStore;
        }

        public MvxCommand SaveCommand
        {
            get { return _saveCommand ?? new MvxCommand(DoSave); }
            set { SetProperty(ref _saveCommand, value); }
        }

        private void DoSave()
        {
            if (Validate())
            {
                var collectedItem = new CollectedItem
                {
                    Caption = Caption,
                    ImagePath = GenerateImagePath(),
                    Latitude = Latitude,
                    Longitude = Longitude,
                    Notes = Notes,
                    WhenUtc = DateTime.UtcNow
                };

                CollectionService.Add(collectedItem);
                Close(this);
            }
        }

        private string GenerateImagePath()
        {
            if(PictureBytes == null)
                return null;

            var randomFileName = $"Image{Guid.NewGuid().ToString("N")}.jpg";
            //var randomFileName = "Image.jpg";
            _fileStore.EnsureFolderExists("Images");
            var path = _fileStore.PathCombine("Images", randomFileName);
            _fileStore.WriteFile(path, PictureBytes);

            // Neccesay for android
            // path = _fileStore.NativePath(path);
            return path;
        }

        
        private bool Validate()
        {
            if (string.IsNullOrEmpty(Caption))
                return false;

            //if (PictureBytes == null)
            //    return false;

            return true;
        }

        public MvxCommand AddPictureCommand
        {
            get { return _addPictureCommand ?? new MvxCommand(DoAddPicture); }
            set { SetProperty(ref _addPictureCommand, value); }
        }

        private void DoAddPicture()
        {
            try
            {
                _pictureChooserTask.ChoosePictureFromLibrary(400, 95, OnPictureTaken, () => { });
                
                // Does not work for IOS Simulator
                // _pictureChooserTask.TakePicture(400, 95, OnPictureTaken, () => { });
            }
            catch (Exception ex)
            {
                return;
            }
            
            // _pictureChooserTask.ChoosePictureFromLibrary(400, 95, OnPictureTaken, () => { });
        }

        private void OnPictureTaken(Stream pictureStream)
        {
            var memoryStream = new MemoryStream();
            pictureStream.CopyTo(memoryStream);
            PictureBytes = memoryStream.ToArray();
        }

        public byte[] PictureBytes
        {
            get { return _pictureBytes; }
            set { SetProperty(ref _pictureBytes,  value); }
        }
    }
}
