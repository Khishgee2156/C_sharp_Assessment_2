//****************************************************************
// Programmer: Tengerkhishig Svyeta
// Date: 10/18/2020
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64-bit
// Purpose: This form is for openning other child forms.
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTask1_Click(object sender, EventArgs e)
        {
            //This button opens a child form that demonstrates 2D graphic.
            new frmChild_2D_graphics().ShowDialog();
        }

        private void btnTask2_Click(object sender, EventArgs e)
        {
            //This button opens a child form that demonstrates drag and drop
            //operation that displays an image in a PictureBox control
            new frmChild_drag_and_drop().ShowDialog();
        }

        private void btnNestedClass_Click(object sender, EventArgs e)
        {
            //This button opens a child form that demonstrates a use of nested class
            new frmChild_nested_class().ShowDialog();
            
        }

        private void btnOpenComparatorFrm_Click(object sender, EventArgs e)
        {
            //This button opens a child form that demonstrates a use of comparator
            new frmChild_comparator_demo().ShowDialog();
        }
    }
}
