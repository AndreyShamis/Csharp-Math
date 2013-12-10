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
        private static Random               rnd = new Random();
        private LinkedList<IGraphEdge>      m_Edge = new LinkedList<IGraphEdge>();
        public double       insertTime { get; internal set; }
        public double       addTime { get; internal set; }

        private LinkedList<IGraphVertex>    m_Vertex = new LinkedList<IGraphVertex>();
        
        public double       findVertexTime { get; internal set; }
        public double       findVertexByValueTime { get; internal set; }

        public Graph<T> BFS()
        {
            return new Graph<T>();
        }

        public Graph<T> DFS()
        {
            return new Graph<T>();
        }

        public bool isFull()
        {
            if (m_Vertex.Count == 1)
                return true;
            if (m_Edge.Count+1 < m_Vertex.Count)
                return false;
            if ((m_Edge.Count *2 >= m_Vertex.Count))    //  TODO CHECK IT
                return true;

            return false;
        }

        public bool isComplete()
        {
            if (m_Vertex.Count == 1)
                return true;

            if (!isFull())
                return false;
            
            return false;
        }

        public void InsertVertex(IGraphVertex newVertex)
        {
            AddVertex(newVertex);
        }


        private void AddVertex(IGraphVertex newVertex)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //vertex.Add(newVertex);
            m_Vertex.AddFirst(newVertex);
            sw.Stop();
            addTime = sw.Elapsed.TotalMilliseconds;
        }

        public GraphVertex<T> GetRandomVertex()
        {
            
            long id = rnd.Next(0, Convert.ToInt32( this.VertexsCount())-1);
            long counter = 0;
            foreach (GraphVertex<T> tmp in m_Vertex)
            {
                if (counter == id)
                    return tmp;

                counter++;
            }
            return null;
        }

        public void InsertVertex(IGraphVertex newVertex, IGraphVertex neightbor)
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
            insertTime = sw.Elapsed.TotalMilliseconds;
        }

        public long VertexsCount()
        {
            return (m_Vertex != null) ? m_Vertex.Count : 0;
        }
        
        public long EdgesCount()
        {
            return (m_Edge != null) ? m_Edge.Count : 0;
        }

        public void InsertEdge(IGraphVertex v1, IGraphVertex v2)
        {
            GraphEdge newEdge = new GraphEdge(v1, v2);
            m_Edge.AddFirst(newEdge);
        }

        public IGraphVertex GetVertexByValue(T otherValue)
        {
            IGraphVertex ret = null;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            foreach (IGraphVertex tmp in m_Vertex)
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

        public IGraphVertex GetVertex(IGraphVertex other)
        {
            IGraphVertex ret = null;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            if (m_Vertex.Contains(other))
                ret = new GraphVertex<T>();
            sw.Stop();
            findVertexTime = sw.Elapsed.TotalMilliseconds;
            return ret;
        }

        public bool Contains(IGraphVertex other)
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

        public IGraphVertex GetVertexEquels(IGraphVertex other)
        {
            IGraphVertex ret = null;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            foreach (IGraphVertex tmp in m_Vertex)
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
