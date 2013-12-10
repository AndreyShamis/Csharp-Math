using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateTest
{
    public class Graph<T>
    {
        private ArrayList vertex = new ArrayList();
        private ArrayList edge = new ArrayList();
        public double insertTime { get; internal set; }
        public double addTime { get; internal set; }

        private LinkedList<GraphVertex<T>> m_Vertex = new LinkedList<GraphVertex<T>>();
        
        public double findVertexTime { get; internal set; }
        public double findVertexByValueTime { get; internal set; }

        public void InsertVertex(GraphVertex<T> newVertex)
        {
            AddVertex(newVertex);
        }


        private void AddVertex(GraphVertex<T> newVertex)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //vertex.Add(newVertex);
            m_Vertex.AddFirst(newVertex);
            sw.Stop();
            addTime = sw.Elapsed.TotalMilliseconds;
        }

        public void InsertVertex(GraphVertex<T> newVertex, GraphVertex<T> neightbor)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            // Check if neightbor exist
            if (this.Contains(neightbor))
            {
                AddVertex(newVertex);
                InsertEdge(newVertex, neightbor);
            }
            else
            {
                Console.Out.WriteLine("Neightbor not found");
            }
            sw.Stop();
            insertTime = sw.Elapsed.Ticks;
        }

        public long VertexsCount()
        {
            return (m_Vertex != null) ? m_Vertex.Count : 0;
        }
        
        public long EdgesCount()
        {
            return (edge != null) ? edge.Count : 0;
        }

        public void InsertEdge(GraphVertex<T> v1, GraphVertex<T> v2)
        {
            GraphEdge newEdge = new GraphEdge(v1, v2);
            edge.Add(newEdge);
        }

        public IGraphVertex GetVertexByValue(T otherValue)
        {
            IGraphVertex ret = null;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            foreach (IGraphVertex tmp in vertex)
            {
                if ( EqualityComparer<T>.Default.Equals( otherValue,((GraphVertex<T>)tmp).value))
                {
                    ret = tmp;
                    break;
                }
            }
            sw.Stop();
            findVertexByValueTime = sw.Elapsed.TotalMilliseconds;
            return ret;
        }

        public IGraphVertex GetVertex(GraphVertex<T> other)
        {
            IGraphVertex ret = null;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            /*foreach (IGraphVertex tmp in vertex)
            {
                if (other.(tmp))
                {
                    ret = tmp;
                    break;
                }
            }*/
            if (vertex.Contains(other))
                ret = new GraphVertex<T>();
            sw.Stop();
            findVertexTime = sw.Elapsed.TotalMilliseconds;
            return ret;
        }

        public bool Contains(GraphVertex<T> other)
        {
            bool ret = false;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (m_Vertex.Contains(other))
                ret = true;
            sw.Stop();
            findVertexTime = sw.Elapsed.TotalMilliseconds;
            return ret;
        }

        public IGraphVertex GetVertexEquels(GraphVertex<T> other)
        {
            IGraphVertex ret = null;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            foreach (IGraphVertex tmp in vertex)
            {
                if (other.Equals(tmp))
                {
                    ret = tmp;
                    break;
                }
            }
            sw.Stop();
            findVertexTime = sw.Elapsed.TotalMilliseconds;
            return ret;
        }

    }
}
