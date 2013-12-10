using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointInTriangleC
{
    public partial class Form1 : Form
    {
        ArrayList arr = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        static Random rnd = new Random();
        private Point getPointByProbabilityBeInTriangle(Triangle tr, short probability)
        {
            rnd.Next(1, 3);
            return new Point();
        }

        private Point getPointOutSide(Triangle tr)
        {
            int MAX_TRYS = 100;
            int countTrys = 0;
            Point ret = new Point();
            while (countTrys++ < MAX_TRYS)
            {
                double p4x = 0;
                double p4y = 0;
                int DIPLKSER = 3;

                int rnda = rnd.Next(1, DIPLKSER);
                if (rnda == 1)
                    p4x = GetRandomNumber(tr.PointX.x, tr.PointY.x);
                else if (rnda == 2)
                    p4x = GetRandomNumber(tr.PointX.x, tr.PointZ.x);
                else if (rnda == 3)
                    p4x = GetRandomNumber(tr.PointY.x, tr.PointZ.x);


                rnda = rnd.Next(1, DIPLKSER);
                if (rnda == 1)
                    p4y = GetRandomNumber(tr.PointX.y, tr.PointY.y);
                else if (rnda == 2)
                    p4y = GetRandomNumber(tr.PointX.y, tr.PointZ.y);
                else if (rnda == 3)
                    p4y = GetRandomNumber(tr.PointY.y, tr.PointZ.y);

                ret = new Point(p4x, p4y);

                if (!tr.isPointInside(ret))
                    return ret;

            }
            return ret;
        }

        private Point getPointInSide(Triangle tr)
        {
            int MAX_TRYS = 100;
            int countTrys = 0;
            Point ret = new Point();
            while (countTrys++ < MAX_TRYS)
            {
                double p4x = 0;
                double p4y = 0;
                int DIPLKSER = 3;
                if (countTrys == 500000)
                {
                    Console.WriteLine(tr.ToString() + tr.GetBiggestLine().GetLength());
                }
                int rnda = rnd.Next(1, DIPLKSER);
                if (rnda == 1)
                    p4x = GetRandomNumber(tr.PointX.x, tr.PointY.x);
                else if (rnda == 2)
                    p4x = GetRandomNumber(tr.PointX.x, tr.PointZ.x);
                else if (rnda == 3)
                    p4x = GetRandomNumber(tr.PointY.x, tr.PointZ.x);

                
                rnda = rnd.Next(1, DIPLKSER);
                if (rnda == 1)
                    p4y = GetRandomNumber(tr.PointX.y, tr.PointY.y);
                else if (rnda == 2)
                    p4y = GetRandomNumber(tr.PointX.y, tr.PointZ.y);
                else if (rnda == 3)
                    p4y = GetRandomNumber(tr.PointY.y, tr.PointZ.y);

                ret = new Point(p4x, p4y);

                if (tr.isPointInside(ret))
                    return ret;

            }
            return ret;
        }

        ArrayList _Pointobjects = new ArrayList();
        StringBuilder log = new StringBuilder();
        private void button1_Click(object sender, EventArgs e)
        {
            // refr();
            log.Clear();
            txtLog.Text = "";
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Convert.ToInt32(numericUpDown1.Value);

            ThreadPool.QueueUserWorkItem(new WaitCallback((s) => Generate2()));

        }

        public ArrayList _objects = new ArrayList();
        

        private static Int32 _RADIUS = 100;

        
        public static double GetRandomNumber(double minimum, double maximum)
        {
            return rnd.NextDouble() * (maximum - minimum) + minimum;
        }

        private delegate void EventHandle();
        public void Generate2()
        {
            int con = 0;
            int MAX_SIZE = Convert.ToInt32(MaxPref.Value);
            int MIN_SIZE = Convert.ToInt32(minPref.Value);
            int pointNoise = Convert.ToInt32(chance.Value);
            //Random r = new Random();
            Random ins = new Random();
  
            int trys = Convert.ToInt32(numericUpDown1.Value);
            double temp = Convert.ToDouble((double)(trys /100 ));
            int PercentForVew = Convert.ToInt32( Math.Round(temp));
            for (int i = 0; i < trys; i++)
            {

                double p1x = ins.Next(MIN_SIZE, MAX_SIZE) + rnd.NextDouble();
                double p2x = ins.Next(MIN_SIZE, MAX_SIZE) + rnd.NextDouble();
                double p3x = ins.Next(MIN_SIZE, MAX_SIZE) + rnd.NextDouble();
                double p1y = ins.Next(MIN_SIZE, MAX_SIZE) + rnd.NextDouble();
                double p2y = ins.Next(MIN_SIZE, MAX_SIZE) + rnd.NextDouble();
                double p3y = ins.Next(MIN_SIZE, MAX_SIZE) + rnd.NextDouble();
                Point newP1 = new Point(p1x, p1y);
                Point newP2 = new Point(p2x, p2y);
                Point newP3 = new Point(p3x, p3y);
                Triangle tr = new Triangle(newP1, newP2, newP3);
                Point newP4 ;

                //newP4 = getPointOutSide(tr);
                newP4 = getPointInSide(tr);
                
                _Pointobjects.Add(newP1);
                _Pointobjects.Add(newP2);
                _Pointobjects.Add(newP3);
                _Pointobjects.Add(newP4);
                _objects.Add(tr);
                ThreadPool.QueueUserWorkItem(new WaitCallback((s) => GraphicTable.refr(_objects, _Pointobjects, sleepTime)));
                //Point newP4 = new Point(pointNoise + ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble(), pointNoise + ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble());

                bool isInside = tr.isPointInside(newP4);
                if (isInside)
                    con++;
                try
                {
                   // refr();
                    progressBar1.BeginInvoke((MethodInvoker)delegate(){progressBar1.Value = i;});
                    if (i % PercentForVew == 0 || i%50 == 0)
                    {
 //                       _objects.Clear();
                        ThreadPool.QueueUserWorkItem(new WaitCallback((s) => UpdateCreateProcess(con + "/" + trys + " " + Math.Round(100.000000 * con / i, 7) + "% [" + MIN_SIZE + " / " + MAX_SIZE + "]")));
                    }
                }
                catch (Exception) { }

                if (checkBox1.Checked)
                {
                    //    log.Append(isInside.ToString() + "  :: " + newP1.ToString() + " " + newP2.ToString() + " " + newP3.ToString() + " " + newP4.ToString() + "\r\n");
                    txtLog.BeginInvoke((MethodInvoker)delegate()
                    {

                        try
                        {
                            if (txtLog.TextLength > 2500)
                                txtLog.Text = txtLog.Text.Substring(0, 2400);
                            txtLog.Text =
                            isInside.ToString() + "  :: " + newP1.ToString() + " " + newP2.ToString() + " "
                            + newP3.ToString() + " " + newP4.ToString() + "\r\n" + txtLog.Text;
                        }
                        catch (Exception) { }
                    });
                }
                Thread.Sleep(200*sleepTime);
                _objects.Clear();
                _Pointobjects.Clear();
                
            }
            listBox1.BeginInvoke((MethodInvoker)delegate() {
            listBox1.Items.Add(con.ToString() + "/" + trys + " " + Math.Round(100.000000 * con / trys, 7) + "% [" + MIN_SIZE + " / " + MAX_SIZE + "]");});
        }

        private void UpdateCreateProcess(string str)
        {
            label1.BeginInvoke((MethodInvoker)delegate(){label1.Text = str;});       
        }
        
        private void MaxPref_ValueChanged(object sender, EventArgs e)
        {
            if (MaxPref.Value < minPref.Value)
            {
                minPref.Value = MaxPref.Value;
            }
        }

        private void minPref_ValueChanged(object sender, EventArgs e)
        {
            if (minPref.Value > MaxPref.Value)
            {
                MaxPref.Value = minPref.Value;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sleepTime = 1;
            //GraphicTable.piB = new PictureBox();
            
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _objects.Add(new Triangle(new Point(400,150),new Point(10,250),new Point(340,350)));
            GraphicTable.refr(_objects, _Pointobjects, sleepTime);
        }

        public int sleepTime { get; set; }





        //public void Generate1()
        //{
        //    int con = 0;
        //    int MAX_SIZE = Convert.ToInt32(MaxPref.Value);
        //    int MIN_SIZE = Convert.ToInt32(minPref.Value);
        //    int pointNoise = Convert.ToInt32(chance.Value);
        //    Random r = new Random();
        //    Random ins = new Random();
        //    string ret = "";

        //    progressBar1.Minimum = 0;
        //    progressBar1.Maximum = Convert.ToInt32(numericUpDown1.Value);
        //    txtLog.Text = "";
        //    for (int i = 0; i < numericUpDown1.Value; i++)
        //    {

        //        Point newP1 = new Point(ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble(), ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble());
        //        Point newP2 = new Point(ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble(), ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble());
        //        Point newP3 = new Point(ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble(), ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble());
        //        Point newP4 = new Point(pointNoise + ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble(), pointNoise + ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble());
        //        //arr.Add(
        //        Triangle tr = new Triangle(newP1, newP2, newP3);
        //        bool isInside = tr.isPointInside(newP4);
        //        if (isInside)
        //            con++;
        //        ret = isInside.ToString() + "  :: " + newP1.ToString() + " " + newP2.ToString() + " " + newP3.ToString() + " " + newP4.ToString() + "\r\n" + ret;
        //        //arr.Add(tr);
        //        progressBar1.Value = i;
        //        if (i % 100 == 0)
        //        {
        //            txtLog.Text = ret + txtLog.Text;
        //            ret = "";
        //        }

        //    }
        //    txtLog.Text = ret + txtLog.Text;
        //    listBox1.Items.Add(con.ToString() + "/" + numericUpDown1.Value + " [" + MIN_SIZE + " / " + MAX_SIZE + "]");
        //}
        
        
    }
}
