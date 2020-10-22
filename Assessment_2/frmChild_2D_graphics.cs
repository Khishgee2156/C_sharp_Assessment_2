//****************************************************************
// Programmer: Tengerkhishig Svyeta
// Date: 10/18/2020
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64-bit
// Purpose: This form draws a robot using 2D shapes.
//**************************************************************** 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_2
{
    public partial class frmChild_2D_graphics : Form
    {
        public frmChild_2D_graphics()
        {
            InitializeComponent();

        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void frmChild_2D_graphics_Paint(object sender, PaintEventArgs e)
        {   
            //Creating graphics object
            Graphics graphics = e.Graphics;

            //Creating a pen object
            Pen pen = new Pen(Color.Black);

            //Creating brush object
            Brush brush = new SolidBrush(Color.LightGray);


            //Drawing antena
            graphics.DrawLine(pen,300,50,300,150);
            graphics.DrawLine(pen,290,75,310,75);
            graphics.DrawLine(pen,285,100,315,100);
            graphics.DrawLine(pen, 280, 125, 320, 125);
            //

            //Drawing head triangle
            brush = new SolidBrush(Color.LightGray);
            Point[] triangle = {new Point(250,170), new Point(300, 150), new Point(350, 170) };
            graphics.FillPolygon(brush,triangle);
            graphics.DrawPolygon(pen,triangle);
            //

            //Drawing head rectangle
            Rectangle rectangle = new Rectangle(250,171,100,90);
            graphics.DrawRectangle(pen,rectangle);
            graphics.FillRectangle(brush,rectangle);
            graphics.DrawLine(pen,250,171,250,260);
            //


            //Drawing face
            
            //Drawing eyes
            graphics.DrawEllipse(pen,270,190,15,15);
            graphics.DrawEllipse(pen, 315, 190, 15, 15);

            //Painting eyes
            brush = new SolidBrush(Color.Cyan);
            graphics.FillEllipse(brush, 270, 190, 15, 15);
            graphics.FillEllipse(brush, 315, 190, 15, 15);

            //Drawing a nose
            Point[] nose = { new Point(290, 220), new Point(300, 210), new Point(310, 220) };
            brush = new SolidBrush(Color.Yellow);
            graphics.FillPolygon(brush,nose);
            graphics.DrawPolygon(pen, nose);


            //Drawing a mouth
            brush = new SolidBrush(Color.White);
            graphics.FillEllipse(brush,270,230,60,15);
            graphics.DrawEllipse(pen, 270, 230, 60, 15);
            //

            //Drawing a neck
            brush = new SolidBrush(Color.Gray);
            graphics.FillRectangle(brush,280,261,40,10);
            graphics.DrawRectangle(pen, 280, 261, 40, 10);
            //

            //Drawing a body
            brush = new SolidBrush(Color.LightGray);
            graphics.FillRectangle(brush,200,270,200,250);
            graphics.DrawRectangle(pen, 200, 270, 200, 250);
            //

            //Drawing a neck tie.
            brush = new SolidBrush(Color.LightSalmon);
            graphics.FillEllipse(brush,295,290,15,15);
            graphics.DrawEllipse(pen, 295, 290, 15, 15);

            Point[] rightSide = {new Point(311,297), new Point(335,288), new Point(335, 300)};
            graphics.FillPolygon(brush,rightSide);
            graphics.DrawPolygon(pen,rightSide);

            Point[] leftSide = { new Point(295, 297), new Point(271, 288), new Point(271, 300) };
            graphics.FillPolygon(brush, leftSide);
            graphics.DrawPolygon(pen,leftSide);
            //

            //Drawing buttons on the shirt
            brush = new SolidBrush(Color.ForestGreen);
            for (int i = 0, center=320; i < 5; i++, center=center+30)
            {
                graphics.FillEllipse(brush, 295, center, 15, 15);
                graphics.DrawEllipse(pen, 295, center, 15, 15);
            }
            //


            //Drawing arms
            brush = new SolidBrush(Color.DarkSlateGray);
            graphics.FillRectangle(brush,402,280,10,60);
            graphics.FillRectangle(brush,189,280,10,60);

            brush = new SolidBrush(Color.LightGray);
            graphics.FillRectangle(brush, 413, 270, 20, 200);
            graphics.DrawRectangle(pen,413,270,20,200);

            graphics.FillRectangle(brush,167,270,20,200);
            graphics.DrawRectangle(pen, 167, 270, 20, 200);
            //

            //brush = new SolidBrush(Color.LightGray);
            //graphics.FillRectangle(brush, 200, 270, 200, 250);
            //graphics.DrawRectangle(pen, 200, 270, 200, 250);

            //Drawing legs
            brush = new SolidBrush(Color.DarkSlateGray);
            graphics.FillRectangle(brush,210,522,180,20);

            brush = new SolidBrush(Color.LightGray);
            graphics.FillRectangle(brush,220,544,50,200);
            graphics.FillRectangle(brush,330, 544, 50, 200);

            graphics.DrawRectangle(pen, 220, 544, 50, 200);
            graphics.DrawRectangle(pen, 330, 544, 50, 200);

            //



        }

        private void BtnClose_Click(object sender, EventArgs e)
        {   
            //Closing this particular form
            this.Close();
        }
    }
}
