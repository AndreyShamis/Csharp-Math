using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTest
{
    public static class GraphicTable
    {
        public static PictureBox piB = new PictureBox();
        public static Bitmap bm;
        public static Graphics gr;
        public static Int32 _BOARDX = 355;
        public static Int32 _BOARDY = 355;
        private static Color BoardColor = Color.Black;
        static Random rnd = new Random();

        private static Pen GetColorForTriangle()
        {
            Pen RadiusForApPen = null;
            int t = rnd.Next(1, 9);
            if (t == 1) RadiusForApPen = new Pen(System.Drawing.Color.Ivory);
            else if (t == 2) RadiusForApPen = new Pen(System.Drawing.Color.Aquamarine);
            else if (t == 3) RadiusForApPen = new Pen(System.Drawing.Color.Red);
            else if (t == 4) RadiusForApPen = new Pen(System.Drawing.Color.Green);
            else if (t == 5) RadiusForApPen = new Pen(System.Drawing.Color.Yellow);
            else if (t == 6) RadiusForApPen = new Pen(System.Drawing.Color.MistyRose);
            else if (t == 7) RadiusForApPen = new Pen(System.Drawing.Color.PaleVioletRed);
            else RadiusForApPen = new Pen(System.Drawing.Color.Purple);

            return RadiusForApPen;
        }

        //====================================================================================================
        public static void refr(ArrayList _objects, ArrayList _Pointobjects, int sleepTime)
        {

            try
            {
                gr.Clear(BoardColor);
                Pen RadiusForApPen = null;
                for (int i = 0; i < _objects.Count; i++)
                {
                    
                    //Triangle _tap = (Triangle)_objects[i];
                    //RadiusForApPen = GetColorForTriangle();
                    //gr.DrawLine(RadiusForApPen, (float)_tap.LineX.PointX.x, (float)_tap.LineX.PointX.y, (float)_tap.LineX.PointY.x, (float)_tap.LineX.PointY.y);
                }

                System.Drawing.Font txtFont = new System.Drawing.Font("Arial", 7);
                System.Drawing.SolidBrush txtColor = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                RadiusForApPen = new Pen(System.Drawing.Color.Blue);
                for (int i = 0; i < _Pointobjects.Count; i++)
                {
                    //Point _tap = (Point)_Pointobjects[i];
                    //GraphicTable.gr.DrawPie(RadiusForApPen, new Rectangle((int)_tap.x - 3, (int)_tap.y - 3, 6, 6), 90, 360);
                    //string drawString = _tap.ToString();
                    //GraphicTable.gr.DrawString(drawString, txtFont, txtColor, (int)_tap.x - 16, (int)_tap.y - 26);
                }
                GraphicTable.piB.Image = GraphicTable.bm;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("refr:" + ex.Message);
            }
        }

    }
}
