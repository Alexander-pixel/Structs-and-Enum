
using System;

namespace Structs
{
    public struct Point:IComparable, ICloneable
    {
        private int _x;
        private int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get => _x;
            set => _x = value;
        }
        
        public int Y 
        {
            get => _y;
            set => _y = value;
        }

        public override string ToString()
        {
            return $"X: {_x} Y: {_y}";
        }

        public int CompareTo(object obj)
        {
            return X.CompareTo(((Point) obj).X);
        }

        public object Clone()
        {
            return this;
        }
    }
}