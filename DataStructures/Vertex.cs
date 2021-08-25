using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    class Vertex
    {
        private string name;
        private LinkedList<Edge> edgesInvolved = new LinkedList<Edge>();

        public Vertex(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public void AddNewEdge(Edge edge)
        {
            this.edgesInvolved.AddLast(edge);
        }

    }

}