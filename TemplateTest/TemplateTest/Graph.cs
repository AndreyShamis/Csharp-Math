using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateTest
{
    public class Graph<T>
    {
        private ArrayList vertex = new ArrayList();
        private ArrayList edge = new ArrayList();

        public void InsertVertex(GraphVertex<T> newVertex)
        {
            vertex.Add(newVertex);
        }

        public void InsertVertex(GraphVertex<T> newVertex, GraphVertex<T> neightbor)
        {
            // Check if neightbor exist
            if (this.GetVertex(neightbor) != null)
            {
                vertex.Add(newVertex);
                InsertEdge(newVertex, neightbor);
            }
            else
            {
                Console.Out.WriteLine("Neightbor not found");
            }
        }

        public long VertexsCount()
        {
            return (vertex != null) ? vertex.Count : 0;
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
            foreach (IGraphVertex tmp in vertex)
            {
                if ( EqualityComparer<T>.Default.Equals( otherValue,((GraphVertex<T>)tmp).value))
                    return tmp;
            }
            return null;
        }

        public IGraphVertex GetVertex(GraphVertex<T> other)
        {
            foreach (IGraphVertex tmp in vertex)
            {
                if (other.Equals(tmp))
                    return tmp;
            }
            return null;
        }

    }
}
