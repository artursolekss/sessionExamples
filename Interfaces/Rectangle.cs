using System;

namespace AbstractClInterfaces
{
    public class Rectangle : IFigure
    {

        private double edge1, edge2;

        public double GetEdge1()
        {
            return this.edge1;
        }

        public void SetEdge1(double edge)
        {
            this.edge1 = edge;
        }

        public double GetEdge2()
        {
            return this.edge2;
        }

        public void SetEdge2(double edge)
        {
            this.edge2 = edge;
        }

        public double CalculatePerimeter()
        {
            return 2 * (this.edge1 + this.edge2);
        }

        public double CalculateArea()
        {
            return this.edge1 * this.edge2;
        }

        public override string ToString()
        {
            return "Rectangle";
        }

    }

}