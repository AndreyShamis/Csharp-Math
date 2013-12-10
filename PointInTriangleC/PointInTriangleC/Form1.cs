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
        
        private static Color BoardColor = Color.Black;
        private static Int32 _RADIUS = 100;
        //====================================================================================================
        public void refr()
        {

        try
            {
                gr.Clear(BoardColor);
                Pen RadiusForApPen = null;
                for (int i = 0; i < _objects.Count; i++)
                {
                    Triangle _tap = (Triangle)_objects[i];
                    int t =     rnd.Next(1, 9);
                    if(t == 1)      RadiusForApPen = new Pen(System.Drawing.Color.Ivory);
                    else if(t ==2)  RadiusForApPen = new Pen(System.Drawing.Color.Aquamarine);
                    else if (t == 3)RadiusForApPen = new Pen(System.Drawing.Color.Red);
                    else if (t == 4)RadiusForApPen = new Pen(System.Drawing.Color.Green);
                    else if (t == 5)RadiusForApPen = new Pen(System.Drawing.Color.Yellow);
                    else if (t == 6)RadiusForApPen = new Pen(System.Drawing.Color.MistyRose);
                    else if (t == 7)RadiusForApPen = new Pen(System.Drawing.Color.PaleVioletRed);
                    else RadiusForApPen = new Pen(System.Drawing.Color.Purple);
                    gr.DrawLine(RadiusForApPen,(float)_tap.LineX.PointX.x,(float)_tap.LineX.PointX.y,(float)_tap.LineX.PointY.x,(float)_tap.LineX.PointY.y);
                    gr.DrawLine(RadiusForApPen,(float)_tap.LineY.PointX.x,(float)_tap.LineY.PointX.y,(float)_tap.LineY.PointY.x,(float)_tap.LineY.PointY.y);
                    gr.DrawLine(RadiusForApPen,(float)_tap.LineZ.PointX.x,(float)_tap.LineZ.PointX.y,(float)_tap.LineZ.PointY.x,(float)_tap.LineZ.PointY.y);
                    
                    string drawString = "Shetah:" + _tap.GetSheteah() +"\r\nBLine:" + _tap.GetBiggestLine().GetLength() + "\r\n" + "STime:" + sleepTime;
                    System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 8);
                    System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);

                    gr.DrawString(drawString, drawFont, drawBrush, (int) 0, (int) 0);
                    drawFont.Dispose();
                    drawBrush.Dispose();

                }

                System.Drawing.Font txtFont = new System.Drawing.Font("Arial", 7);
                System.Drawing.SolidBrush txtColor = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                RadiusForApPen = new Pen(System.Drawing.Color.Blue);
                for (int i = 0; i < _Pointobjects.Count; i++)
                {
                    Point _tap = (Point)_Pointobjects[i];
                    gr.DrawPie(RadiusForApPen, new Rectangle((int)_tap.x-3, (int)_tap.y-3, 6, 6), 90, 360);
                    string drawString = _tap.ToString();
                    gr.DrawString(drawString, txtFont, txtColor, (int)_tap.x - 16, (int)_tap.y - 26);
                }
                piB.Image = bm;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("refr:" + ex.Message);
            }
        }

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
            Random r = new Random();
            Random ins = new Random();
  
            int trys = Convert.ToInt32(numericUpDown1.Value);
            double temp = Convert.ToDouble((double)(trys /100 ));
            int PercentForVew = Convert.ToInt32( Math.Round(temp));
            for (int i = 0; i < trys; i++)
            {

                double p1x = ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble();
                double p2x = ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble();
                double p3x = ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble();
                double p1y = ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble();
                double p2y = ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble();
                double p3y = ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble();
                Point newP1 = new Point(p1x, p1y);
                Point newP2 = new Point(p2x, p2y);
                Point newP3 = new Point(p3x, p3y);

                Triangle tr = new Triangle(newP1, newP2, newP3);

                double p4x = 0;
                double p4y = 0;
                int DIPLKSER = 3;
                Point newP4 ;

                if (p4x != p4y)
                {
                    int rnda = rnd.Next(1, DIPLKSER);
                    if (rnda == 1)
                        p4x = GetRandomNumber(tr.PointX.x, tr.PointY.x);
                    else if (rnda == 2)
                        p4x = GetRandomNumber(tr.PointX.x, tr.PointZ.x);
                    else if (rnda == 3)
                        p4x = GetRandomNumber(tr.PointY.x, tr.PointZ.x);
                    else if (rnda == 4)
                        p4x = GetRandomNumber(0, ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble());
                    else
                        p4x = ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble();


                    rnda = rnd.Next(1, DIPLKSER);
                    if (rnda == 1)
                        p4y = GetRandomNumber(tr.PointX.y, tr.PointY.y);
                    else if (rnda == 2)
                        p4y = GetRandomNumber(tr.PointX.y, tr.PointZ.y);
                    else if (rnda == 3)
                        p4y = GetRandomNumber(tr.PointY.y, tr.PointZ.y);
                    else if (rnda == 4)
                        p4y = GetRandomNumber(0, ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble());
                    else
                        p4y = ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble();

                    newP4 = new Point(pointNoise + p4x, pointNoise + p4y);


                }
                else
                {
                    //newP4 = getPointOutSide(tr);
                    newP4 = getPointInSide(tr);
                }
                _Pointobjects.Add(newP1);
                _Pointobjects.Add(newP2);
                _Pointobjects.Add(newP3);
                _Pointobjects.Add(newP4);
                _objects.Add(tr);
                ThreadPool.QueueUserWorkItem(new WaitCallback((s) => refr()));
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
                Thread.Sleep(3*sleepTime);

                _objects.Clear();
                _Pointobjects.Clear();
                
            }
            txtLog.BeginInvoke((MethodInvoker)delegate(){txtLog.Text = txtLog.Text + log.ToString();});
            listBox1.BeginInvoke((MethodInvoker)delegate() {
                listBox1.Items.Add(con.ToString() + "/" + trys + " " + Math.Round(100.000000 * con / trys, 7) + "% [" + MIN_SIZE + " / " + MAX_SIZE + "]");});
        }

        private void UpdateCreateProcess(string str)
        {
            label1.BeginInvoke((MethodInvoker)delegate(){label1.Text = str;});       
        }

        public void Generate1()
        {
            int con = 0;
            int MAX_SIZE = Convert.ToInt32(MaxPref.Value);
            int MIN_SIZE = Convert.ToInt32(minPref.Value);
            int pointNoise = Convert.ToInt32(chance.Value);
            Random r = new Random();
            Random ins = new Random();
            string ret = "";

            progressBar1.Minimum = 0;
            progressBar1.Maximum = Convert.ToInt32(numericUpDown1.Value);
            txtLog.Text = "";
            for (int i = 0; i < numericUpDown1.Value; i++)
            {

                Point newP1 = new Point(ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble(), ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble());
                Point newP2 = new Point(ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble(), ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble());
                Point newP3 = new Point(ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble(), ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble());
                Point newP4 = new Point(pointNoise + ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble(), pointNoise + ins.Next(MIN_SIZE, MAX_SIZE) + r.NextDouble());
                //arr.Add(
                Triangle tr = new Triangle(newP1, newP2, newP3);
                bool isInside = tr.isPointInside(newP4);
                if (isInside)
                    con++;
                ret = isInside.ToString() + "  :: " + newP1.ToString() + " " + newP2.ToString() + " " + newP3.ToString() + " " + newP4.ToString() + "\r\n" + ret;
                //arr.Add(tr);
                progressBar1.Value = i;
                if (i % 100 == 0)
                {
                    txtLog.Text = ret + txtLog.Text;
                    ret = "";
                }

            }
            txtLog.Text = ret + txtLog.Text;
            listBox1.Items.Add(con.ToString() + "/" + numericUpDown1.Value + " [" + MIN_SIZE + " / " + MAX_SIZE + "]");
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MaxPref_ValueChanged(object sender, EventArgs e)
        {
            if (MaxPref.Value < minPref.Value)
            {
                //minPref.Maximum = MaxPref.Minimum;
                minPref.Value = MaxPref.Value;
            }
        }

        private void minPref_ValueChanged(object sender, EventArgs e)
        {
            if (minPref.Value > MaxPref.Value)
            {
                //MaxPref.Minimum= minPref.Maximum;
                MaxPref.Value = minPref.Value;
            }
        }

        private PictureBox piB;
        private Bitmap bm;
        private Graphics gr;
        private static Int32 _BOARDX = 355;
        private static Int32 _BOARDY = 355;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            sleepTime = 1;
            piB = new PictureBox();
            piB.Parent = this;
            piB.Location = new System.Drawing.Point(10, 10);
            piB.Size = new Size(_BOARDX, _BOARDY);
            piB.BackColor = Color.Black;
            piB.AllowDrop = true;

            //this.piB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnImage_MouseDown);
            //this.piB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnImage_MouseUp);
            //this.piB.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragDrop);
            bm = new Bitmap(piB.Width, piB.Height);
            gr = Graphics.FromImage(bm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _objects.Add(new Triangle(new Point(400,150),new Point(10,250),new Point(340,350)));
            refr();
        }


        public int sleepTime { get; set; }
    }
}
