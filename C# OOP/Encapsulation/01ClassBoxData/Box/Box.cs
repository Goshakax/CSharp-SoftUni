using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    public class Box
    {
        private double height;
        private double width;
        private double length;

        public Box(double height, double width, double length)
        {
            Height = height;
            Width = width;
            Length = length;
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value > 0)
                {
                    this.height = value;
                }
                else
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

            }

        }
        public double Width
        {
            get { return this.width; }
            set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

            }

        }
        public double Length
        {
            get { return this.length; }
            set
            {
                if (value > 0)
                {
                    this.length = value;
                }
                else
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

            }

        }

        public double SurfaceArea()
        {
            return 2 * this.height * this.width + 2 * this.height * this.length + 2 * this.height * this.length;
        }

        public double LateralSurfaceArea()
        {
            return (height * this.length * 2) + this.width * this.height * 2;

        }

        public double Volume()
        {
            return height * width * length;
        }
    }
}
