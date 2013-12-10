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
        public static long  VertexCounter;
        public T            value { set; get; }
        private ArrayList   neightbors = null;
        private ArrayList   edgeNeightbors = null;
        public long         id { get; internal set; }


        public GraphVertex()
        {
            id = VertexCounter; 
            VertexCounter++;
        }

        public bool AddNeightbor(GraphVertex<T>  neightbor)
        {
            neightbors.Add(neightbor);
            return true;
        }

        public bool RemoveNeightbor(GraphVertex<T> neightborToRemove)
        {
            neightbors.Remove(neightborToRemove);
            return true;
        }

    }
}
