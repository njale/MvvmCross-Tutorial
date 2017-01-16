using System.Collections.Generic;
using Day17.Core.Services.Collections;
using Day17.Core.Services.DataStore;
using Day17.Core.Services.Location;
using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.Messenger;

namespace Day17.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        protected readonly ICollectionService CollectionService;
        private readonly ILocationService _locationService;
        private readonly MvxSubscriptionToken _locationMessageSubscriptionToken;
        private MvxSubscriptionToken _collectionChangedMessageSubscriptionToken;

        private string _caption;
        private string _notes;
        private double? _latitude;
        private double? _longitude;
        private bool _locationKnown;
        private CollectedItem _latest;


        protected BaseViewModel(ICollectionService collectionService, ILocationService locationService, IMvxMessenger messenger)
        {
            CollectionService = collectionService;
            _locationService = locationService;

            GetInitialLocation();

            _locationMessageSubscriptionToken = messenger.SubscribeOnMainThread<LocationMessage>(OnLocationMessage);
            _collectionChangedMessageSubscriptionToken = messenger.Subscribe<CollectionChangedMessage>(OnCollectionChanged);
        }

        private List<CollectedItem> _items;
        public List<CollectedItem> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }


        private void OnCollectionChanged(CollectionChangedMessage obj)
        {
            ReloadList();
        }

        private void ReloadList()
        {
            Items = CollectionService.All();
        }

        private void GetInitialLocation()
        {
            double latitude, longitude;
            if (_locationService.TryGetLatestLocation(out latitude, out longitude))
            {
                Latitude = latitude;
                Longitude = longitude;
            }
        }

        private void OnLocationMessage(LocationMessage locationMessage)
        {
            Latitude = locationMessage.Latitude;
            Longitude = locationMessage.Longitude;
        }

        public string Caption
        {
            get { return _caption; }
            set { SetProperty(ref _caption, value); }
        }

        public string Notes
        {
            get { return _notes; }
            set { SetProperty(ref _notes, value); }
        }

        public double? Latitude
        {
            get { return _latitude; }
            set
            {
                SetProperty(ref _latitude, value);
                UpdateLocationKnown();
            }
        }

        public double? Longitude
        {
            get { return _longitude; }
            set
            {
                SetProperty(ref _longitude, value);
                UpdateLocationKnown();
            }
        }

        public CollectedItem Latest
        {
            get { return _latest; }
            set { SetProperty(ref _latest, value); }
        }

        protected void UpdateLatest()
        {
            Latest = CollectionService.Latest;
        }

        private void UpdateLocationKnown()
        {
            LocationKnown = Latitude != null && Longitude != null;
        }

        public bool LocationKnown
        {
            get { return _locationKnown; }
            private set { SetProperty(ref _locationKnown, value); }
        }
    }
}
