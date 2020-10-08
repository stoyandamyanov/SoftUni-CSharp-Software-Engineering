using System;

namespace BoxData
{
    public class Box
    {
        private const double SIDE_MIN_VALUE = 0;
        private const string INVALID_VALUE_MASSAGE = "{0} cannot be zero or negative.";
        private double length;
        private double width;
        private double height;

        public Box(double length,double width,double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
            
            Console.WriteLine($"Surface Area - {SurfaceArea():f2}");
            Console.WriteLine($"Lateral Surface Area - {LateralSurfaceArea():f2}");
            Console.WriteLine($"Volume - {Volume():f2}");
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if(value <= SIDE_MIN_VALUE)
                {
                    throw new ArgumentException(String.Format(INVALID_VALUE_MASSAGE,nameof(this.Length)));
                }

                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= SIDE_MIN_VALUE)
                {
                    throw new ArgumentException(String.Format(INVALID_VALUE_MASSAGE, nameof(this.Width)));
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= SIDE_MIN_VALUE)
                {
                    throw new ArgumentException(String.Format(INVALID_VALUE_MASSAGE, nameof(this.Height)));
                }

                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            double SArea = (2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height);
            return SArea;
        }

        public double LateralSurfaceArea()
        {
            double LArea = 2 * this.Length * this.Height + 2 * this.Width * this.Height;
            return LArea;
        }

        public double Volume()
        {
            double Volume = this.Width * this.Height * this.Length;
            return Volume;
        }
    }

}
