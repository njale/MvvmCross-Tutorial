using System;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Util;
using Android.Widget;
using Day19.Core.Model;
using Day19.Core.ViewModels;

namespace Day19.Droid.Controls
{
    class ShapeTextView : TextView
    {
        private Shape _theShape;

        public ShapeTextView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public ShapeTextView(Context context) : base(context)
        {
        }

        public ShapeTextView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public ShapeTextView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        public ShapeTextView(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {
        }

        public Shape TheShape
        {
            get { return _theShape; }
            set
            {
                _theShape = value;
                AdjustText();
            }
        }

        private void AdjustText()
        {
            Text = TheShape.ToString();
            switch (TheShape)
            {
                case Shape.Circle:
                    SetTextColor(Color.Aqua); 
                    break;
                case Shape.Square:
                    SetTextColor(Color.Red);
                    break;
                case Shape.Triangle:
                    SetTextColor(Color.Magenta);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}