using System;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }


        private double length;

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.BoxParameterCannotBeZeroOrNegative, nameof(this.Length)));
                }

                this.length = value;
            }
        }

        private double width;

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.BoxParameterCannotBeZeroOrNegative, nameof(this.Width)));
                }

                this.width = value;

            }
        }


        private double height;

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.BoxParameterCannotBeZeroOrNegative, nameof(this.Height)));
                }

                this.height = value;
            }
        }


        public double SurfaceArea()
        {
            return (2 * this.Length * this.Width) + (2 * this.Length * this.Height) + (2 * this.Width * this.Height);

            //or  this.LateralSurfaceArea()+()2*this.Length*this.Width;

        }

        public double LateralSurfaceArea()
        {
            return (2 * this.Length * this.Height) + (2 * this.Width * this.Height);

        }

        public double Volume()
        {
            return this.Length * this.Width * this.Height;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine($"Surface Area - {this.SurfaceArea():f2}")
                .AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():f2}")
                .AppendLine($"Volume - {this.Volume():f2}");


            return sb.ToString().Trim();
        }
    }
}
