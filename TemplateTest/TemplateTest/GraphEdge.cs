using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateTest
{
    public class GraphEdge:IGraphEdge
    {
        public IGraphVertex     Vertex1 {internal set; get; }
        public IGraphVertex     Vertex2 { internal set; get; }
        protected static long   VertexCounter;

        public GraphEdge(IGraphVertex v1, IGraphVertex v2)
        {
            Vertex1 = v1;
            Vertex2 = v2;
            VertexCounter++;
        }
    }
}
