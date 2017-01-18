using System;
using System.ComponentModel;
using System.Drawing;
using Day19.Core.Model;
using Day19.Core.ViewModels;
using Foundation;
using UIKit;

namespace Day19.IOS.Controls
{
    [Register("ShapeLabel"), DesignTimeVisible(true)]
    public class ShapeLabel : UILabel
    {
        private Shape _theShape;

        public ShapeLabel()
        {
        }

        public ShapeLabel(IntPtr handle) : base(handle)
        {
            
        }


        public ShapeLabel(RectangleF frame) : base(frame)
        {

        }

        // [Export("Test"), Browsable(true)]
        public Shape TheShape
        {
            get { return _theShape; }
            set
            {
                _theShape = value;
                UpdateGui();
            }
        }
        
        private void UpdateGui()
        {
            Text = TheShape.ToString();

            switch (TheShape)
            {
                case Shape.Circle:
                    TextColor = UIColor.Cyan;
                    break;
                case Shape.Square:
                    TextColor = UIColor.Red;
                    break;
                case Shape.Triangle:
                    TextColor = UIColor.Magenta;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        
    }
}
