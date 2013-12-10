using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateTest
{
    public class GraphEdge
    {
        public IGraphVertex Vertex1 { set; get; }
        public IGraphVertex Vertex2 { set; get; }
        public static long VertexCounter;
        public GraphEdge(IGraphVertex v1, IGraphVertex v2)
        {
            Vertex1 = v1;
            Vertex2 = v2;
            VertexCounter++;
        }
        public GraphEdge()
        {
            VertexCounter++;
        }
    }
}
