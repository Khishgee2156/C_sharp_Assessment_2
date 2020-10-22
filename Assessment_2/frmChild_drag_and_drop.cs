//****************************************************************
// Programmer: Tengerkhishig Svyeta
// Date: 10/18/2020
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64-bit
// Purpose: This form is for demonstrating a drag and drop
// operation on an image and display the image in a PictureBox
// control.
//**************************************************************** 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_2
{
    public partial class frmChild_drag_and_drop : Form
    {
        private Bitmap imageToDisplay;

        public frmChild_drag_and_drop()
        {
            InitializeComponent();

            //Making background color of pictureBox white
            pictureBox.BackColor = Color.White;
            
            //Setting a border style of pictureBox
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closing this particular form
            this.Close();
        }

        private void frmChild_drag_and_drop_Load(object sender, EventArgs e)
        {
            //Enable drag && drop for this form
            this.AllowDrop = true;

            //Add event handlers for drag and drop functionality
            this.DragEnter += new DragEventHandler(frmChild_drag_and_drop_DragEnter);
            this.DragDrop += new DragEventHandler(frmChild_drag_and_drop_DragDrop);
        }


        //This event fires when the mouse is released over the form
        private void frmChild_drag_and_drop_DragDrop(object sender, DragEventArgs e)
        {
            string[] imageList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (string image in imageList)
                imageToDisplay = new Bitmap(image);
                pictureBox.Image = (Image)imageToDisplay;
        }


        //This event fires when the mouse is dragged over the form
        private void frmChild_drag_and_drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
