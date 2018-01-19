using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simonliProjGraph
{
    public class Graph<T>
    {
        public Graph() { }
        public Graph(IEnumerable<T> vertices, IEnumerable<Tuple<T, T>> edges)
        {
            foreach (var vertex in vertices)
                AddVertex(vertex);

            foreach (var edge in edges)
                AddEdge(edge);
        }

        public Dictionary<T, HashSet<T>> AdjacencyList { get; } = new Dictionary<T, HashSet<T>>();

        public void AddVertex(T vertex)
        {
            AdjacencyList[vertex] = new HashSet<T>();
        }

        public void AddEdge(Tuple<T, T> edge)
        {
            if (AdjacencyList.ContainsKey(edge.Item1) && AdjacencyList.ContainsKey(edge.Item2))
            {
                AdjacencyList[edge.Item1].Add(edge.Item2);
                AdjacencyList[edge.Item2].Add(edge.Item1);
            }
        }
    }

    public class Algorithms
    {
        public HashSet<T> BFS<T>(Graph<T> graph, T start)
        {
            var visited = new HashSet<T>();

            if (!graph.AdjacencyList.ContainsKey(start))
                return visited;

            var queue = new Queue<T>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var vertex = queue.Dequeue();

                if (visited.Contains(vertex))
                    continue;

                visited.Add(vertex);

                foreach (var neighbor in graph.AdjacencyList[vertex])
                    if (!visited.Contains(neighbor))
                        queue.Enqueue(neighbor);
            }

            return visited;
        }
        public Func<T, IEnumerable<T>> ShortestPathFunction<T>(Graph<T> graph, T start)
        {
            var previous = new Dictionary<T, T>();

            var queue = new Queue<T>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var vertex = queue.Dequeue();
                foreach (var neighbor in graph.AdjacencyList[vertex])
                {
                    if (previous.ContainsKey(neighbor))
                        continue;

                    previous[neighbor] = vertex;
                    queue.Enqueue(neighbor);
                }
            }

            Func<T, IEnumerable<T>> shortestPath = v => {
                var path = new List<T> { };

                var current = v;
                while (!current.Equals(start))
                {
                    path.Add(current);
                    current = previous[current];
                };

                path.Add(start);
                path.Reverse();

                return path;
            };

            return shortestPath;
        }
    }





    class Program
    {
      

       

        static void Main(string[] args)
        {

            string[] arrA2 = { "Waterfront",
"Vancouver City Centre",
"Yaletown–Roundhouse",
"Olympic Village",
"Broadway–City Hall",
"King Edward",
"Oakridge–41st Avenue",
"Langara–49th Avenue",
"Marine Drive",
"Bridgeport",
"Aberdeen",
"Lansdowne",
"Richmond–Brighouse"

            };

            string[] arrA1={
                "Bridgeport",
                "Templeton",
                "Sea Island",
                "YVR"
            };


            string[] arrA3 = {"Waterfront",
"Burrard",
"Granville",
"Stadium–Chinatown",
"Main Street–Science World",
"Commercial–Broadway",
"Nanaimo",
"29th Avenue",
"Joyce–Collingwood",
"Patterson",
"Metrotown",
"Royal Oak",
"Edmonds",
"22nd Street",
"New Westminster",
"Columbia",
"Sapperton",
"Braid",
"Lougheed Town Centre",
"Production Way–University"};



            string[] arrA4 = { "Columbia",
"Scott Road",
"Gateway",
"Surrey Central",
"King George"};

            string[] arrA5 = { "VCC–Clark",
"Commercial–Broadway",
"Renfrew",
"Rupert",
"Gilmore",
"Brentwood Town Centre",
"Holdom",
"Sperling–Burnaby Lake",
"Lake City Way",
"Production Way–University",
"Lougheed Town Centre",
"Burquitlam",
"Moody Centre",
"Inlet Centre",
"Coquitlam Central",
"Lincoln",
"Lafarge Lake–Douglas"};


            List<string[]> data = new List<string[]>() { arrA1, arrA1, arrA2, arrA3, arrA4, arrA5 };


            string SourceStation = "Templeton";//Metrotown//YVR//YVR
            string DestinationStation = "Aberdeen";//Holdom//Holdom//King George
            var vertex = 1;//destination
            var startVertex = 1;//our source


            //this is for finding destination array to set it to startVertex
            int pos = Array.IndexOf(arrA1, DestinationStation);
            if (pos > -1)
            {
                
                vertex = 1;


            }
            pos = Array.IndexOf(arrA2, DestinationStation);//pos=15
            if (pos > -1)//true
            {
                vertex = 2;//
            }
            pos = Array.IndexOf(arrA3, DestinationStation);
            if (pos > -1)
            {
                vertex = 3;
            }
            pos = Array.IndexOf(arrA4, DestinationStation);
            if (pos > -1)
            {
                vertex = 4;
            }
            pos = Array.IndexOf(arrA5, DestinationStation);
            if (pos > -1)
            {
                vertex = 5;
            }
            /////////////////////////////////////////

            //this is for finding source array to set it to vertex
            int poss = Array.IndexOf(arrA1, SourceStation);
            int chk = 0;

            


                if (poss > -1 && chk==0)
                {
                
                startVertex = 1;
                if (poss == 0) chk = 1;
                }
            poss = Array.IndexOf(arrA2, SourceStation);
            if (poss > -1 && chk == 0)
            {
                startVertex = 2;
                if (poss == 0) chk = 1;
            }
            poss = Array.IndexOf(arrA3, SourceStation);
            if (poss > -1 && chk == 0)
            {
                startVertex = 3;
                if (poss == 0) chk = 1;
            }
            poss = Array.IndexOf(arrA4, SourceStation);
            if (poss > -1 && chk == 0)
            {
                startVertex = 4;
                if (poss == 0) chk = 1;
            }
            poss = Array.IndexOf(arrA5   , SourceStation);
            if (poss > -1 && chk == 0)
            {
                startVertex = 5;
                if (poss == 0) chk = 1;
            }

            ////////////////////////////////////////////////////

            



            ////////////////////////////////////////////////////////
            var vertices = new[] { 1, 2, 3, 4, 5 };
            var edges = new[]{Tuple.Create(1,2),
                Tuple.Create(2,3), Tuple.Create(3,4), Tuple.Create(3,5),
                 };

            var graph = new Graph<int>(vertices, edges);
            var algorithms = new Algorithms();

            
           
            var shortestPath = algorithms.ShortestPathFunction(graph, startVertex);
            //foreach (var vertex in vertices)
                Console.WriteLine("shortest path to {0,2}: {1}",
                        vertex, string.Join(", ", shortestPath(vertex)));

            //finding smallest route//////////////////////////////////////////////////////////////////////////
            string nodes=string.Join("",shortestPath(vertex));
            Console.WriteLine(nodes);
             
            var chars = nodes.ToCharArray();

            int[] myInts = nodes.Select(c => int.Parse(c.ToString())).ToArray();
            // if (chars[0]=='3'&&chars[1]=='5')
            //           shortRoute(data[2], data[4], DestinationStation);

            string newdestination = DestinationStation;
            string newSource = SourceStation;

            Console.WriteLine(SourceStation);//printing current station
            for (int i=0;i<myInts.Length-1;i++) {

                newdestination=shortRoute(data[myInts[i]], data[myInts[i+1]], newdestination);
                //Console.WriteLine(newdestination);//updating new destination w.r.t connecting point
                PrintStations(data[myInts[i]], newSource, newdestination);

                newSource = newdestination;

                
            }

            PrintStations(data[myInts[myInts.Length - 1]], newSource, DestinationStation);





            Console.ReadLine();
        }

        static void PrintStations(string[] a, string startStation, string endStation) {
            Console.WriteLine("/////////////////////////////////////////////////");
            int dpos = Array.IndexOf(a, endStation);
            int spos= Array.IndexOf(a, startStation);
            int counter = 0;


            if (dpos > spos)
            {

                while (dpos != spos)
                {
                    spos++;
                    counter++;
                    Console.WriteLine(a[spos]);
                }

            }
            if (spos > dpos)
            {

                while (dpos != spos)
                {
                    spos--;
                    counter++;
                    Console.WriteLine(a[spos]);
                }
            }



            Console.WriteLine("/////////////////////////////////////////////////");
        }
       static string shortRoute(string[] b, string[] a,string DestinationStation) {

            //


            int spos;
            int counter = 0;
            int smallcounter = 100;
            string shortroute = "";


            int dpos = Array.IndexOf(a, DestinationStation);//destination postion in its station
            var listCommon = b.Intersect(a);//common connecting points


            foreach (string s in listCommon)
            {
               // Console.WriteLine(s); //for printing commoin connecting points

                spos = Array.IndexOf(a, s);//your source postion w.r.t connecting point
                ///
                if (dpos > spos)
                {

                    while (dpos != spos)
                    {
                        spos++;
                        counter++;
                    }

                }
                if (spos > dpos)
                {

                    while (dpos != spos)
                    {
                        spos--;
                        counter++;
                    }
                }
                ///
                if (counter < smallcounter) { smallcounter = counter; shortroute = s; }

                //Console.WriteLine("dis " + counter);//for calculating distance
                counter = 0;
            }
            //Console.WriteLine(shortroute);
            return shortroute;
            //





        }


    }
    
}
