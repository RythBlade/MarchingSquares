using System;

namespace MarchingSquares
{
    public class MSPoint
    {
        public float X { get; set; }
        public float Y { get; set; }

        #region Constructors
        public MSPoint()
        {
            X = 0.0f;
            Y = 0.0f;
        }

        public MSPoint(MSPoint point)
        {
            X = point.X;
            Y = point.Y;
        }

        public MSPoint(float value)
        {
            X = value;
            Y = value;
        }

        public MSPoint(float x, float y)
        {
            X = x;
            Y = y;
        }
        #endregion

        #region Operator overloads
        public static MSPoint operator +(MSPoint lhs, MSPoint rhs)
        {
            return new MSPoint(lhs.X + rhs.X, lhs.Y + rhs.Y);
        }

        public static MSPoint operator -(MSPoint lhs, MSPoint rhs)
        {
            return new MSPoint(lhs.X - rhs.X, lhs.Y - rhs.Y);
        }

        public static MSPoint operator *(MSPoint lhs, float rhs)
        {
            return new MSPoint(lhs.X * rhs, lhs.Y * rhs);
        }
        #endregion

        #region Math functions
        public float Length()
        {
            return (float)Math.Sqrt(X * X + Y * Y);
        }

        public float LengthSqr()
        {
            return X * X + Y * Y;
        }

        public static MSPoint min(MSPoint p1, MSPoint p2)
        {
            return new MSPoint(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y));
        }

        public static MSPoint max(MSPoint p1, MSPoint p2)
        {
            return new MSPoint(Math.Max(p1.X, p2.X), Math.Max(p1.Y, p2.Y));
        }
        #endregion
    }
}
