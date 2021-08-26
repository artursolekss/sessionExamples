using System;

namespace AbstractClInterfaces
{
    public class Circle : IFigure
    {
        private double radiuss;

        public double GetRadiuss()
        {
            return this.radiuss;
        }

        public void SetRadiuss(double radiuss)
        {
            this.radiuss = radiuss;
        }

        public double CalculatePerimeter()
        {
            return 2 * this.radiuss * Math.PI;
        }

        public double CalculateArea()
        {
            return Math.PI * this.radiuss * this.radiuss;
        }

        public override string ToString()
        {
            return "Circle";
        }

    }

}