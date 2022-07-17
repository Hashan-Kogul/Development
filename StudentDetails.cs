//2018ICTS85 ICAE01 TICT 2134
using system;
namespace StudentDetails
{

    class Student
    {
        private string name;
        private string gender;
        private string registrationNumber;
        private int academicYear = 2018;
        private string[] awardsLists;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }

            set
            {
                registrationNumber = value;
            }
        }

        //Read only
        public int AcademicYear
        { 
            get
            {
                return academicYear;
            }
        }

        public string[] AwardsList
        {
            get
            {
                return awardsLists;
            }
            set
            {
                awardsLists = value;
            }
        }

        Student()
        {
            name = null;
            gender = null;
            registrationNumber = null;
            academicYear = 0;
            awardsLists = null;
        }

        Student(string name, string registrationNumber, int academicYear)
        {
            this.name = name;
            this.registrationNumber = registrationNumber;
            this.academicYear = academicYear;
        }

        Student(string name, string gender, string registrationNumber, int academicYear)
        {
            this.name = name;
            this.gender = gender;
            this.registrationNumber = registrationNumber;
            this.academicYear = academicYear;
        }

        public void printDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Registration Number: " + registrationNumber);
            Console.WriteLine("Academic Year: " + academicYear);

        }

        public void printAward()
        {
            for(int i=0; i < awardsLists.Length; i++)
            {
                Console.WriteLine(awardsLists[i]);
            }
        }


    }

    class ExtraCurricular : Student
    {
        int id;
        int year;
        string sports;
        string aesthetics;
        string societies;
        int rank;

        ExtraCurricular()
        {
            id = 0;
            year = 0;
            sports = null;
            aesthetics = null;
            societies = null;
            rank = 0;
        }

        ExtraCurricular(string name, string registrationNumber, int academicYear) : base(name,registrationNumber,academicYear)
        {
            
        }

        ExtraCurricular(string sports, string aesthetics, string societies, int rank)
        {
            this.sports = sports;
            this.aesthetics = aesthetics;
            this.societies = societies;
            this.rank = rank;
        }

        public Boolean eligibiltyCheck()
        {
            if (rank > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void printDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Registration Number: " + RegistrationNumber);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Sports: " + sports);
            Console.WriteLine("Aesethetics: " + aesthetics);
            Console.WriteLine("Societies: " + societies);
            Console.WriteLine("Rank: " + rank);
        }



    }

    class Course : Student
    {
        //Delegate
        public delegate void NewDelegate();

        private string courseName;
        private int credits;
        private string inCharge;
        private int totalHours;

        public Course(string courseName, int credits, string inCharge)
        {
            this.courseName = courseName;
            this.credits = credits;
            this.inCharge = inCharge;
        }
        public Course(string courseName, int credits, string inCharge, int totalHours)
        {
            this.courseName = courseName;
            this.credits = credits;
            this.inCharge = inCharge;
            this.totalHours = totalHours;
        }

        public string CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                courseName = value;
            }

        }

        public int Credits
        {
            get
            {
                return credits;
            }
            set
            {
                credits = value; 
            }
        }

        public string Incharge
        {
            get
            {
                return inCharge;
            }

            set
            {
                inCharge = value;
            }
        }

        public int TotalHours
        {
            get
            {
                return totalHours;
            }
            set
            {
                totalHours = value;
            }
        }

        public Boolean checkCourse()
        {
            if(courseName=="C++" || courseName == "JAVA")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void checkDuration()
        {
            if (totalHours > 15)
            {
                Console.WriteLine("The Duration Exceeds the Limit");
            }
            else
            {
                Console.WriteLine("Duration is Limited");
            }
        }

        public void printCourseDetails()
        {
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Credits: " + credits);
            Console.WriteLine("In-Charge: " + inCharge);
            Console.WriteLine("Total Hours: " + totalHours);
        }

        public int attandencePercentage()
        {
            int n;
            Console.Write("Enter the number of lectures attended: ");
            n = Convert.ToInt32(Console.ReadLine());

            return n * (10 / 3);
        }

    }

    abstract class Grade : Course
    {
        public Grade()
        {

        }
        Boolean nonCredit = false;

        public void checkCredits()
        {
            if (nonCredit == true)
            {
                Console.WriteLine("Non-Credit Subject");
            }
        }

        public abstract char distinction();
    }


    class StudentApp
    {
        static void Main(string[] args)
        {
            Student[] studentList = new Student[]
            {
                new Student {Name="Jhon",Gender="M",RegistrationNumber="2017/ICTS/01" },
                new Student {Name="Meera",Gender="F",RegistrationNumber="2017/ICTS/14" }
            };
            Course[] courseList = new Course[]
            {
                new Course {CourseName="C++", Credits=1, InCharge="Dr.Margret", TotalHours=15 },
                new Course{CourseName="Java", Credits=2, inCharge="Mr.Kevin",TotalHours=30}
            };

            Student ob = new Student();
            ob.AwardsList[]= { "Dean's List Award 2018/2019", "Second Year Best Performance Award-2018", "Faculty Award - 2020" };

            Console.WriteLine("Welcome");
            Console.WriteLine("----------------------------------");

            NewDelegate del1 = studentList[1].printDetails();

            for (int i = 0; i < actorList.Length; i++)
            {
                
                del1 = StudentList[i].printDetails;
                del1();
            }

  
        }
    }
}