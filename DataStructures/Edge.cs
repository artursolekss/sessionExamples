using System;
using System.Collections;

namespace DataStructures
{
    class Edge
    {

        private Vertex point1, point2;

        public Edge(Vertex point1, Vertex point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }

        public Vertex GetPoint1()
        {
            return this.point1;
        }

        public Vertex GetPoint2()
        {
            return this.point2;
        }

    }

}