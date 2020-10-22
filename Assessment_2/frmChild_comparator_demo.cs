//****************************************************************
// Programmer: Tengerkhishig Svyeta
// Date: 10/19/2020
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64-bit
// Purpose: This form displays students names and ages in the list box
// and sort students by their name and age
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
    public partial class frmChild_comparator_demo : Form
    {   
        //Creating student array
        private student[] students = new student[10];


        public frmChild_comparator_demo()
        {
            InitializeComponent();

            //Calling a function
            loadData();

            //Calling a function
            displayStudents();
        }

        //This function assings 10 different
        //student objects to students array
        public void loadData()
        {
            students[0] = new student("Jimi","Hendrich",76);
            students[1] = new student("Alden", "Cantrell", 93);
            students[2] = new student("Kierra", "Gentry", 19);
            students[3] = new student("Pierre", "Cox", 35);
            students[4] = new student("Thomas", "Crane", 23);
            students[5] = new student("Tom", "Holland", 62);
            students[6] = new student("Miranda", "Shaffer", 80);
            students[7] = new student("Brent", "Barling", 18);
            students[8] = new student("Dimitri", "Zlatko", 46);
            students[9] = new student("Connor", "Fernand", 59);
        }

        
        //This function displays students in the list box
        public void displayStudents()
        {

            string header = "Firstname " + " " + " Lastname" + " " + "Age";
            lstBox_students.Items.Add(header);

            for (int i = 0; i < students.Length; i++ )
            {
                lstBox_students.Items.Add(students[i].studentDetail());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {   
            //Closing this particular form
            this.Close();
        }


        //This function sorts students by their age 
        //when the button is clicked
        private void btnSortByAge_Click(object sender, EventArgs e)
        {
            Array.Sort(students);
            lstBox_students.Items.Clear();
            displayStudents();
        }

        private void btnSortByName_Click(object sender, EventArgs e)
        {
            Array.Sort(students, student.sortStudentsByTheirFirstname());
            lstBox_students.Items.Clear();
            displayStudents();
        }
    }
}
