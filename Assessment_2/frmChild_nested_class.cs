//****************************************************************
// Programmer: Tengerkhishig Svyeta
// Date: 10/22/2020
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64-bit
// Purpose: This form constructs student objects and 
// display student objects in the list box by using a nested class.
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
    public partial class frmChild_nested_class : Form
    {

        //Creating a list to store student objects.
        private List<student> students = new List<student>();

        
        
        public frmChild_nested_class()
        {
            InitializeComponent();
            //Calling a function
            createStudents();
        }


        //This function creates student objects
        //and them to a list
        //and return a reference of the list
        public void createStudents()
        {   
            //Constructing student objects
            student student1 = new student("Eric","Clapton",25);
            student student2 = new student("Orlanda", "Bloom", 37);
            student student3 = new student("Kobe", "Braynt", 42);
            student student4 = new student("Daniel", "Craig", 18);

            //Creating inner object
            student.inner_student_class student_objects = new student.inner_student_class();

            //Adding students to a private list using function
            //addStudent with a help of inner_object that is name
            //student_objects.
            student_objects.addStudent(student1);
            student_objects.addStudent(student2);
            student_objects.addStudent(student3);
            student_objects.addStudent(student4);
            //Assinging reference of student_objects to
            //student variable
            students = student_objects.getStudents();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closing this particular form
            this.Close();
        }

        private void btnDisplayStudents_Click(object sender, EventArgs e)
        {
            string text = "firstname " + " " +" lastname" + " " +" Age";
            lstStudents.Items.Add(text);
            foreach (student current_student in students)
            {
                lstStudents.Items.Add(current_student.studentDetail());
            }

            
        }
    }
}
