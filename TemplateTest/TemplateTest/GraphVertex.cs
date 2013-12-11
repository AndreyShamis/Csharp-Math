using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateTest
{
    public class GraphVertex<T> :  IGraphVertex
    {
        protected static long  VertexCounter;
        public T            value { set; get; }
        private LinkedList<GraphVertex<T>> neightbors = new LinkedList<GraphVertex<T>>();
        public long         id { get; internal set; }
        public bool colored { set; get; }

        public int GetNeightborsCount()
        {
            return neightbors.Count;
        }

        public GraphVertex()
        {
            id = VertexCounter; 
            VertexCounter++;
            colored = false;
        }

        public bool AddNeightbor(GraphVertex<T>  neightbor)
        {
            neightbors.AddFirst(neightbor);
            return true;
        }

        public bool RemoveNeightbor(GraphVertex<T> neightborToRemove)
        {
            neightbors.Remove(neightborToRemove);
            return true;
        }

    }
}
