using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TemplateTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Graph<int> gra = new Graph<int>();

        private StringBuilder log = new StringBuilder();
        private string sync = "";
        private void PrintLog(string str)
        {
            if (chkWriteLog.Checked)
            {
                if (chkPrintLog.Checked)
                {
                    lock (sync)
                    {
                        log.Append(str + "\r\n");
                    }
                }
                else
                {
                    log.Append(str + "\r\n");
                }
            }
        }

        private static Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback((s) => GenerateGraph()));
        }

        private void GenerateGraph()
        {
            Tem<int> t = new Tem<int>();
            Tem<string> r = new Tem<string>();
            t.Test();
            t.Hi(t);
            r.Hi(r);
            GraphVertex<int> ver1 = new GraphVertex<int>();
            GraphVertex<int> ver2 = new GraphVertex<int>();
            GraphVertex<int> ver4 = new GraphVertex<int>();
            ver1.value = 15;
            ver2.value = 14;
            GraphVertex<int> prev = new GraphVertex<int>();
            int generateSize = 0;
            generateSize = Convert.ToInt32(nmbNumberOvVertexInGraph.Value) * 100;
            PrintLog("Start generate " + generateSize + " Vertexs");
            GraphVertex<int> ver3 = null;
            for (int i = 0; i < generateSize; i++)
            {
                ver3 = new GraphVertex<int>();
                ver3.value = i;

                int te = rnd.Next(1, 10);
                if (te == 3 && i > 2)
                {
                    gra.InsertVertex(ver3, prev);
                    ThreadPool.QueueUserWorkItem(new WaitCallback((s) => PrintLog("ADD: Vertex. ID:\t\t\t" + ver3.id)));
                }
                else
                {
                    gra.InsertVertex(ver3);
                    if (te == 7)
                    {
                        ThreadPool.QueueUserWorkItem(new WaitCallback((s) => PrintLog("ADD: Edge. ID is\t\t [ " + ver3.id + " ]")));
                        gra.InsertEdge(prev, ver3);
                        //Thread.Sleep(1);
                    }

                    
                }
                
                prev = ver3;
            }

            gra.InsertVertex(ver1);
            gra.InsertVertex(ver2);
            gra.InsertVertex(ver1, ver4);
            gra.InsertEdge(ver1, ver2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicTable.piB.Parent = this;
            GraphicTable.piB.Location = new System.Drawing.Point(10, 10);
            GraphicTable.piB.Size = new Size(GraphicTable._BOARDX, GraphicTable._BOARDY);
            GraphicTable.piB.BackColor = Color.Black;
            GraphicTable.piB.AllowDrop = true;

            //this.piB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnImage_MouseDown);
            //this.piB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnImage_MouseUp);
            //this.piB.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragDrop);
            GraphicTable.bm = new Bitmap(GraphicTable.piB.Width, GraphicTable.piB.Height);
            GraphicTable.gr = Graphics.FromImage(GraphicTable.bm);


            chart1.ChartAreas[0].Axes[0].Title = "Time";
            chart1.ChartAreas[0].Axes[1].Title = "Milliseconds";
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].MarkerStyle = MarkerStyle.Circle;
            chart1.Series[0].LegendText = "Insert Time";

            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[1].LegendText = "Find Time";
            chart1.Series[1].MarkerStyle = MarkerStyle.Diamond;
            chart1.Series[1].Color = Color.Green;

            chart1.Series[2].ChartType = SeriesChartType.Line;
            chart1.Series[2].LegendText = "Add Time";
            chart1.Series[2].MarkerStyle = MarkerStyle.Diamond;
            chart1.Series[2].Color = Color.LightPink;


            chart2.ChartAreas[0].Axes[0].Title = "Time";
            chart2.ChartAreas[0].Axes[1].Title = "Milliseconds";
            chart2.Series[0].ChartType = SeriesChartType.Line;
            chart2.Series[0].MarkerStyle = MarkerStyle.Circle;
            chart2.Series[0].LegendText = "Insert Time";

            chart2.Series[1].ChartType = SeriesChartType.Line;
            chart2.Series[1].LegendText = "Find Time";
            chart2.Series[1].MarkerStyle = MarkerStyle.Diamond;
            chart2.Series[1].Color = Color.Green;

            chart2.Series[2].ChartType = SeriesChartType.Line;
            chart2.Series[2].LegendText = "Add Time";
            chart2.Series[2].MarkerStyle = MarkerStyle.Diamond;
            chart2.Series[2].Color = Color.LightPink;


            chart3.ChartAreas[0].Axes[0].Title = "| V |";
            chart3.ChartAreas[0].Axes[1].Title = "Milliseconds";
            chart3.Series[0].ChartType = SeriesChartType.Line;
            chart3.Series[0].MarkerStyle = MarkerStyle.Circle;
            chart3.Series[0].LegendText = "Insert Time";

            chart3.Series[1].ChartType = SeriesChartType.Line;
            chart3.Series[1].LegendText = "Find Time";
            chart3.Series[1].MarkerStyle = MarkerStyle.Diamond;
            chart3.Series[1].Color = Color.Green;

            chart3.Series[2].ChartType = SeriesChartType.Line;
            chart3.Series[2].LegendText = "Add Time";
            chart3.Series[2].MarkerStyle = MarkerStyle.Diamond;
            chart3.Series[2].Color = Color.LightPink;
        
        }

        private int x_i = 0;
        private long prevCount = -1;
        private long prevCountSec = -1;
        private void tmrFast_Tick(object sender, EventArgs e)
        {
            long count = gra.VertexsCount();
            lblEdgeSize.Text = gra.EdgesCount().ToString();
            lblVertexSize.Text = count.ToString();
            if (count > 0)
                lblGraphParameter.Text = "" + Math.Round ((gra.EdgesCount() + 0.000) / count,2);

            lblGraphInsertTime.Text = "" + gra.insertTime;
            lblGraphFindTime.Text = "" + gra.findVertexTime;
            lblGraphFindByValueTime.Text = "" + gra.findVertexByValueTime;

            lblAddTime.Text = "" + gra.addTime;

            
            //for (int i = 1; i <= 30; i++)
            //{
            chart1.Series[0].Points.AddXY(x_i, gra.insertTime);
            chart1.Series[1].Points.AddXY(x_i, gra.findVertexTime);
            chart1.Series[2].Points.AddXY(x_i, gra.addTime);

            

            if (prevCount != count)
            {
                chart2.Series[0].Points.AddXY(count, gra.insertTime);
                chart2.Series[1].Points.AddXY(count, gra.findVertexTime);
                chart2.Series[2].Points.AddXY(count, gra.addTime);
                prevCount = count;
            }
                //    t = Tuple.Create(t.Item2, t.Item1 + t.Item2);
            //}
            x_i++;
            //txtLog.BeginInvoke((MethodInvoker)delegate()
            //{
            if (chkPrintLog.Checked)
            {
                lock (sync)
                {
                    txtLog.Text = log + txtLog.Text;
                    log.Clear();
                }
            }
            //});
        }

        private void cmdClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
        }

        private void tmrSec_Tick(object sender, EventArgs e)
        {
            long count = gra.VertexsCount();
            if (prevCountSec != count)
            {
                chart3.Series[0].Points.AddXY(count, gra.insertTime);
                chart3.Series[1].Points.AddXY(count, gra.findVertexTime);
                chart3.Series[2].Points.AddXY(count, gra.addTime);
                prevCountSec = count;
            }
        
        }
    }
}
