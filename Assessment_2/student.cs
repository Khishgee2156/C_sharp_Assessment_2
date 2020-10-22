//****************************************************************
// Programmer: Tengerkhishig Svyeta
// Date: 10/22/2020
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64-bit
// Purpose: This student class is for creating student object
// also this class is a nesting class of inner_student_class
// moreover this class implements comparator for sorting students
//**************************************************************** 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    class student : IComparable
    {   
        //Defining fields
        private string firstname;
        private string lastname;
        private int age;


        //Constructor of student class
        public student(string inFname, string inLname, int inAge)
        {
            firstname = inFname;
            lastname = inLname;
            age = inAge;
        }

        //Defining nested class
        public class inner_student_class
        {
            //Creating a list to store student objects
            private List<student> students = new List<student>();

            //This function adds a student object into the list
            public void addStudent(student inStudent)
            {
                students.Add(inStudent);    
            }

            //This function return student list
            public List<student> getStudents()
            {
                return students;
            }

        }


        //this function returns firstname of a student
        public string getfirstName()
        {
            return firstname;
        }


        //this function returns lastname of a student
        public string getlastName()
        {
            return lastname;
        }

        //this function returns age of a student
        public int getAge()
        {
            return age;
        }

        //this function returns details of a student
        public string studentDetail()
        {
            return firstname + "\t" + lastname + "\t" + age;
        }

        //Comparaing two student objects by their age
        public int CompareTo(object inStudent)
        {
            student student1 = (student)inStudent;
            return this.getAge().CompareTo(student1.getAge());
        }

        //Creating comparator to sort students by name
        public class sortStudentsByTheirFirstnameHelper : IComparer
        {
            public int Compare(object inStudent1, object inStudent2)
            {
                student student1 = (student)inStudent1;
                student student2 = (student)inStudent2;

                return String.Compare(student1.getfirstName(), student2.getfirstName());

            }
        }


        //Defining static function to call comparator
        public static IComparer sortStudentsByTheirFirstname()
        {
            return (IComparer)new sortStudentsByTheirFirstnameHelper();
        }

    }
}
