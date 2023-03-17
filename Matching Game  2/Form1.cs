using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Matching_Game__2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Pen blackPen = new Pen(Color.Black, 3);
        }

        int i,j;
        double[] v = new double[5];
        double[] b = new double[5];

        //questions


        private void label1_Click(object sender, EventArgs e)
        {
            for(i=0;i<5;i++)
            {
                v[i] = 0;
            }
            v[1] = 1;
            PointF point1 = new PointF(label1.Location.X, label1.Location.Y);
        }

        
        //Answers
        private void label2_Click(object sender, EventArgs e)
        {


            for (i = 0; i < 5; i++)
            {
                b[i] = 0;
            }
            b[1] = 1;
            PointF point2 = new PointF(label2.Location.X, label2.Location.Y);
        }




        public void DrawLinePointF(PaintEventArgs e)
        {
            for(i=0;i<5;i++)
            {
                for(j=0;j<5;j++)
                {
                    if (v[i] == b[j])
                    {

                        
                        

                        // Draw line to screen.
                        e.Graphics.DrawLine(blackPen, point1, point2);
                    }

                }
            }




            
        }



    }
}
