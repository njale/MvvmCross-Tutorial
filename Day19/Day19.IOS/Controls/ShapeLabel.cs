using System;
using System.Drawing;
using Day19.Core.ViewModels;
using Foundation;
using UIKit;

namespace Day19.IOS.Controls
{
    [Register("ShapeLabel")]
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

        public Shape TheShape
        {
            get { return _theShape; }
            set
            {
                _theShape = value;
                UpdateUI();
            }
        }

        private void UpdateUI()
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
