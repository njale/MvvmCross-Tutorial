using System;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Day19.Core.Model;
using Day19.Core.ViewModels;
using Color = Android.Graphics.Color;

namespace Day19.Droid.Controls
{
    public class CustomDrawShapeView : View
    {
        private Shape _theShape;

        public CustomDrawShapeView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public CustomDrawShapeView(Context context) : base(context)
        {
        }

        public CustomDrawShapeView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public CustomDrawShapeView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        public CustomDrawShapeView(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {
        }

        public Shape TheShape
        {
            get { return _theShape; }
            set
            {
                _theShape = value;
                Invalidate();
            }
        }

        public override void Draw(Canvas canvas)
        {
            var rect = new RectF(0,0,300,300);
            switch (TheShape)
            {
                case Shape.Circle:
                    canvas.DrawOval(rect, new Paint {Color = Color.Aqua});
                    break;
                case Shape.Square:
                    canvas.DrawRect(rect, new Paint { Color = Color.Red });
                    break;
                case Shape.Triangle:
                    var path = new Path();
                    path.MoveTo(rect.CenterX(), 0);
                    path.LineTo(0, rect.Height());
                    path.LineTo(rect.Width(), rect.Height());
                    path.Close();

                    var paint =  new Paint() {Color = Color.Magenta};
                    paint.SetStyle(Paint.Style.Fill);
                    canvas.DrawPath(path, paint);
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}