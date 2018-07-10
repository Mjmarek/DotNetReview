using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Encapsulation_Exercise_2
{
    public class Room
    {
        public double Length { get; set; }
        public double Width { get; set; }

        private double _height;

        public double Height
        {
            get { return _height; }
            set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Room height is too small");
                }
                else if (value > 12)
                {
                    throw new ArgumentException("Room height is too large");
                }
                else
                {
                    _height = value;
                }
            }
        }

        public Room()
        {

        }

        public Room(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double CalculateRoomArea()
        {
            var area = (Length * Width);
            if (area > 900 || area < 36)
            {
                throw new ArgumentException("Room dimensions do not meet specifications.");
            }

            return area;
        }

        public double CalculateWallArea1()
        {
            return (Length * Height);
        }

        public double CalculateWallArea2()
        {
            return (Width * Height);
        }

        public override string ToString() =>
            string.Format($"Length: {Length}, Width: {Width}, Height: {Height}");
    }
}
