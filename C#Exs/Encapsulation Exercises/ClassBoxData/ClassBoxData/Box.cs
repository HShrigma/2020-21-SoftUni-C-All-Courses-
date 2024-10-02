using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;


        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        private double Length
        {
            get
            {
                return length;
            }

            set
            {
                if (IsNegativeOrZero(value))
                    throw new ArgumentException("Length cannot be zero or negative.");
                length = value;
            }
        }
        private double Width
        {
            get
            {
                return width;
            }

            set
            {
                if (IsNegativeOrZero(value))
                    throw new ArgumentException("Width cannot be zero or negative.");

                width = value;
            }
        }

        private double Height
        {
            get
            {
                return height;
            }

            set
            {
                if (IsNegativeOrZero(value))
                    throw new ArgumentException("Height cannot be zero or negative.");

                height = value;
            }
        }
        public double SurfaceArea()
        {
            return (2 * this.length * this.width) + (2 * this.length * this.height) + (2 * this.width * this.height);
        }

        public double LateralSurfaceArea()
        {
            return (2 * this.length * this.height) + (2 * this.width * this.height);
        }

        public double Volume()
        {
            return this.length * this.width * this.height;
        }

        private bool IsNegativeOrZero(double num)
        {
            return num <= 0;
        }

        public override string ToString()
        {
            return $"Surface Area - {SurfaceArea():F2}\nLateral Surface Area - {LateralSurfaceArea():F2}\nVolume - {Volume():F2}";
        }
    }
}
