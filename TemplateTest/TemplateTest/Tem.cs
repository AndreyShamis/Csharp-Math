using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateTest
{
    public class Tem<T>
    {
        public int Foo { get { return 10; } }

        internal void Test()
        {
            
        }

        internal void Hi(Tem<T> t)
        {
           
            Console.Out.WriteLine("My type is " + typeof(T));
        }

    }
}
