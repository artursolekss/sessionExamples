using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    class Graph
    {

        private LinkedList<Edge> edges = new LinkedList<Edge>();
        private LinkedList<Vertex> vertexes = new LinkedList<Vertex>();

        public void AddNewEdge(Edge edge)
        {
            this.edges.AddLast(edge);
        }

        public void AddVertex(Vertex vertex)
        {
            this.vertexes.AddLast(vertex);
        }

        public void PrintAllVertexes()
        {
            Console.WriteLine("The vertextes of the graph:");
            foreach (Vertex vertex in this.vertexes)
            {
                Console.WriteLine(vertex);
            }
        }

        public void PrintAllEdges()
        {
            Console.WriteLine("The edges of the graph:");
            foreach (Edge edge in this.edges)
            {
                Console.WriteLine(edge);
            }
        }

        public int GetNumberOfTheEdges()
        {
            return this.edges.Count;
        }

    }

}