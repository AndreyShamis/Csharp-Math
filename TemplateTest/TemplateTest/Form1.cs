using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Graph<int> gra = new Graph<int>();

        private static Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            Tem<int> t = new Tem<int>();
            Tem <string> r = new Tem<string>();
            t.Test();
            t.Hi(t);
            r.Hi(r);
            GraphVertex<int> ver1 = new GraphVertex<int>();
            GraphVertex<int> ver2 = new GraphVertex<int>();

            GraphVertex<int> ver4 = new GraphVertex<int>();

            ver1.value = 15;
            ver2.value = 14;
            GraphVertex<int> prev = new GraphVertex<int>(); 
            
            for (int i = 0; i < 133000; i++)
            {
                GraphVertex<int> ver3 = new GraphVertex<int>();
                ver3.value = i;
                
                int te = rnd.Next(1, 10);
                if (te == 3 && i > 2)
                {
                    gra.InsertVertex(ver3, prev);
                }
                else
                {
                    gra.InsertVertex(ver3);
                    if (te == 7)
                    {
                        gra.InsertEdge(prev, ver3);
                    }
                }
                prev = ver3;
            }

            gra.InsertVertex(ver1);
            gra.InsertVertex(ver2);
            gra.InsertVertex(ver1, ver4);
            gra.InsertEdge(ver1, ver2);
        }
    }
}
