using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    class Graph
    {

        private LinkedList<Edge> edges = new LinkedList<Edge>();
        private LinkedList<Vertex> vertexes = new LinkedList<Vertex>(); 

        public void AddNewEdge(Edge edge){
            this.edges.AddLast(edge);
        }

        public void AddVertex(Vertex vertex){
            this.vertexes.AddLast(vertex);
        }

    }

}