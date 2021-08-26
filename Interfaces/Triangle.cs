using System;

namespace AbstractClInterfaces
{
    public class Triangle : IFigure
    {

        private double edge1, edge2, edge3, height1;

        public void SetEdge1(double edge1)
        {
            this.edge1 = edge1;
        }

        public void SetEdge2(double edge2)
        {
            this.edge2 = edge2;
        }

        public void SetEdge3(double edge3)
        {
            this.edge3 = edge3;
        }

        public double GetEdge1()
        {
            return this.edge1;
        }

        public double GetEdge2()
        {
            return this.edge2;
        }

        public double GetEdge3()
        {
            return this.edge3;
        }

        public double GetH1()
        {
            return this.height1;
        }

        public void SetH1(double h1)
        {
            this.height1 = h1;
        }

        public double CalculatePerimeter()
        {
            return this.edge1 + this.edge2 + this.edge3;
        }

        public double CalculateArea()
        {
            return this.edge1 * this.height1 / 2;
        }

        public override string ToString()
        {
            return "Triangle";
        }


    }

}