using System;
using System.Collections;

namespace DataStructures
{
    class Assigment4
    {
        public static void Start()
        {
            Graph routesGraph = new Graph();

            Vertex livingstone = new Vertex("Livingstone");
            routesGraph.AddVertex(livingstone);

            Vertex victoriaFalls = new Vertex("Victoria Falls");
            routesGraph.AddVertex(victoriaFalls);

            Vertex harare = new Vertex("Harare");
            routesGraph.AddVertex(harare);

            Vertex mauritus = new Vertex("Mauritius");
            routesGraph.AddVertex(mauritus);

            Vertex joBurg = new Vertex("Jo'burg");
            routesGraph.AddVertex(joBurg);

            Vertex durbs = new Vertex("Durbs");
            routesGraph.AddVertex(durbs);

            Vertex pe = new Vertex("PE");
            routesGraph.AddVertex(pe);

            Vertex capeTown = new Vertex("Cape Town");
            routesGraph.AddVertex(capeTown);

            Vertex windhoek = new Vertex("Windhoek");
            routesGraph.AddVertex(windhoek);

            routesGraph.AddNewEdge(new Edge(victoriaFalls, joBurg));
            routesGraph.AddNewEdge(new Edge(livingstone, joBurg));
            routesGraph.AddNewEdge(new Edge(harare, joBurg));
            routesGraph.AddNewEdge(new Edge(mauritus, joBurg));
            routesGraph.AddNewEdge(new Edge(durbs, joBurg));
            routesGraph.AddNewEdge(new Edge(pe, joBurg));
            routesGraph.AddNewEdge(new Edge(capeTown, joBurg));
            routesGraph.AddNewEdge(new Edge(windhoek, joBurg));
            routesGraph.AddNewEdge(new Edge(durbs, capeTown));
            routesGraph.AddNewEdge(new Edge(pe, capeTown));
            routesGraph.AddNewEdge(new Edge(durbs, pe));


            routesGraph.PrintAllVertexes();
            routesGraph.PrintAllEdges();
            Console.WriteLine("There are " + routesGraph.GetNumberOfTheEdges() + " direct flights in graph");

            Console.WriteLine("Direct flights connected to Cape Town");
            capeTown.PrintAllEdges();

            Console.WriteLine("There are " + joBurg.GetNumberOfTheEdges() + " direct flights from Jo'Burg");

        }

    }

}