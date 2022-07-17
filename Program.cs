using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial02
{
    class Student
    {
        string Sname, Saddress, rgnum;
        int Sage;

        public void get_student_details()
        {
            Console.Write("Enter Student Name :");
            Sname = Console.ReadLine();
            Console.Write("Enter Student Age :");
            Sage = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Registration Number :");
            rgnum = Console.ReadLine();
            Console.Write("Enter Student Address :");
            Saddress = Console.ReadLine();
        }

        public void print_student_details()
        {
            Console.WriteLine();
            Console.WriteLine("Student Name is :{0}\nStudent Age is :{1}\nStudent Registration Number is :{2}\nStudent Adress is :{3}", Sname, Sage, rgnum, Saddress);
        }



        public void getGPA()
        {
            double[,] gpa = new double[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine();
                    Console.Write("Enter {0} Year {1} Semester GPA :", i + 1, j + 1);
                    gpa[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }


            double sum = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sum = sum + gpa[i, j];
                }
            }

            Console.WriteLine();
            Console.Write("Student's Award is :");
            double fgpa = sum / 2;

            if (fgpa > 3.70)
            {
                Console.WriteLine("First Class");
            }
            else if (fgpa > 3.30)
            {
                Console.WriteLine("Second Class(Upper)");
            }
            else if (fgpa > 3)
            {
                Console.WriteLine("Second Class(Lower)");
            }
            else if (fgpa > 2)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Ungraguate");
            }
        }
    }



    class Teacher
    {
        string Tname, Tid, Taddress;
        int Tage;

        public void get_teacher_Details()
        {
            Console.WriteLine();
            Console.Write("Enter Teacher Name :");
            Tname = Console.ReadLine();
            Console.Write("Enter Teacher Age :");
            Tage = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Teacher ID Number :");
            Tid = Console.ReadLine();
            Console.Write("Enter Teacher Address :");
            Taddress = Console.ReadLine();
        }

        public void print_teacher_details()
        {
            Console.WriteLine();
            Console.WriteLine("Teacher Name is :{0}\nTeacher Age is :{1}\nTeacher Id Number is :{2}\nTeacher Adress is :{3}", Tname, Tage, Tid, Taddress);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student ob1 = new Student();
            ob1.get_student_details();
            ob1.print_student_details();
            ob1.getGPA();

            Teacher ob2 = new Teacher();
            ob2.get_teacher_Details();
            ob2.print_teacher_details();

            Console.ReadKey();
        }
    }
}
