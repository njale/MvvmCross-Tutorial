using System;
using System.ComponentModel;
using System.Drawing;
using CoreGraphics;
using Day19.Core.Model;
using Foundation;
using UIKit;


namespace Day19.IOS.Controls
{
    [Register("ShapeView"), DesignTimeVisible(true)]
    public class ShapeView : UIView
    {
        private Shape _theShape;

        public ShapeView()
        {
        }

        public ShapeView(IntPtr handle) : base(handle)
        {
        }

        public ShapeView(CGRect rect) : base(rect)
        {
        }

        public Shape TheShape
        {
            get { return _theShape; }
            set
            {
                _theShape = value;
                SetNeedsDisplay();
            }
        }

        public override void Draw(CGRect rect)
        {
            base.Draw(rect);

            // Clear background
            var context = UIGraphics.GetCurrentContext();
            context.SetFillColor(UIColor.White.CGColor);
            context.FillRect(rect);

            switch (TheShape)
            {
                case Shape.Circle:
                    context.SetFillColor(UIColor.Cyan.CGColor);
                    context.FillEllipseInRect(rect);
                    break;

                case Shape.Square:
                    context.SetFillColor(UIColor.Red.CGColor);
                    context.FillRect(rect);
                    break;

                case Shape.Triangle:
                    context.SetFillColor(UIColor.Magenta.CGColor);
                    context.BeginPath();
                    context.MoveTo(rect.Width / 2, 0);
                    context.AddLineToPoint(0, rect.Height);
                    context.AddLineToPoint(rect.Width, rect.Height);
                    context.ClosePath();
                    context.FillPath();
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}