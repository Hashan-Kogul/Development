using System;

//creating namespace
namespace StudentDetails
{
	class Student
	{
		//declaring instance variables(private)
		private String name, regnum;
		String acYear = "2017/2018";
		private char gender;
		private String[] awardsList;

		//default constructor
		public Student() { }

		//default constructor
		public Student(String name, String regnum, String acYear)
		{
			this.Name = name;
			this.RegNum = regnum;
			this.acYear = acYear;
		}

		//parameterized constrctor
		public Student(String name, String regnum, char gender, String acYear)
		{
			//initializing the instance variables using properties
			this.Name = name;
			this.Gender = gender;
			this.RegNum = regnum;
			this.acYear = acYear;

		}

		//prop name
		public String Name
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

		//readonly prop -  acYear
		public String AccademicYear
		{
			get
			{
				return acYear;
			}


		}
		//prop - regnum
		public String RegNum
		{
			get
			{
				return regnum;
			}

			set
			{
				regnum = value;
			}
		}
		//prop-gender
		public char Gender
		{
			set
			{
				gender = value;
			}
			get
			{
				return gender;

			}

		}
		//prop-arads
		public String[] AwardsList
		{
			set
			{
				awardsList = value;
			}
			get
			{
				return awardsList;

			}

		}
		//printawards
		public void printAwards()
		{

			Console.WriteLine("Awards List of the Student:");

			for (int i = 0; i < awardsList.Length; i++)
			{
				Console.WriteLine((i + 1) + "." + awardsList[i]);
			}
		}
		//VIRTUAL METHOD- TO OVERRIDE
		public virtual void printDetails()
		{
			Console.WriteLine("Name: " + name + "\nGender: " + gender + "\nRegistration Number: " + regnum + "\nAcedamic Year: " + acYear);
			printAwards();
		}
	}
	//create the delegate outside all the class 
	public delegate void NewDelegate();

	class Course
	{
		//declaring instance variables
		private String coursename;
		private int credits;
		private String incharge;
		private int totalHours;
		//public Student student; //Student of Student class type


		//default constructor
		public Course() { }

		//parameterized constructor 01
		Course(string name, int credits, String incharge)
		{
			//initializing using properties
			this.Coursename = name;
			this.Credits = credits;
			this.InCharge = incharge;
		}

		//parameterized constructor 02
		Course(string name, int credits, String incharge, int totalHours)
		{

			//initializing using properties
			this.Coursename = name;
			this.Credits = credits;
			this.InCharge = incharge;
			this.TotalHours = totalHours;
		}


		//prop-Coursename
		public string Coursename
		{
			set
			{
				coursename = value;
			}
			get
			{
				return coursename;

			}

		}
		//prop - credits
		public int Credits
		{
			set
			{
				credits = value;
			}
			get
			{
				return credits;

			}

		}
		//prop- incharge
		public String InCharge
		{
			set
			{
				incharge = value;
			}
			get
			{
				return incharge;

			}

		}
		//prop- totalhours
		public int TotalHours
		{
			set
			{
				totalHours = value;
			}
			get
			{
				return totalHours;

			}

		}

		//checkCourseAvailability 
		public bool checkCourse(string name)
		{
			if (Coursename.Contains(name))
			{
				return true;
			}
			else
				return false;
		}

		//printCourseDetails 
		public void printCoursedetails()
		{

			Console.WriteLine("---------------------\nCourse Details\n---------------------");
			Console.WriteLine("Course Name:  " + Coursename);
			Console.WriteLine("Credits: " + Credits);
			Console.WriteLine("In Charge: " + InCharge);
			Console.WriteLine("Total Hours: " + TotalHours);
			//Console.WriteLine("Student: " + student.Name);

		}
		//checkDuration

		public void checkDuration()
		{
			if (TotalHours > 15)
			{
				Console.WriteLine("The duration exceeds the limit");
			}
			else
			{
				Console.WriteLine("Duration is limited");
			}
		}

		//attendance Percentage
		public void attendancePercentage()
		{
			Console.WriteLine("Enter the number of lectures attended: ");
			int lectures = Convert.ToInt32(Console.ReadLine());


			Console.WriteLine("The attendacne percentage is: " + lectures * (10 / 3));
		}


	}

	class ExtraCurricular:Student
	{
		int id, year, rank;
		String sports, aesthetic, societies;

		public ExtraCurricular() { }
		public ExtraCurricular(String name, String regnum, String acYear) : base(name, regnum, acYear)
		{

		}
		public ExtraCurricular(String sports, String aesthetic, String societies, int rank)
		{
			this.sports = sports;
			this.aesthetic = aesthetic;
			this.societies = societies;
			this.rank = rank;
		}
		bool eligibilityCheck()
		{
			if (rank > 5)
				return false;
			else
				return true;

		}

		//OVERRIDING PRINTDETAILS METHOD
		public override void printDetails()
		{
			Console.WriteLine("Rgistration Number: " + base.RegNum); //CALL PARENT CLASS METHOD
			Console.WriteLine("ID: " + id + "\nYear: " + year + "\nSports: " + sports + "\nAesthetic: " + aesthetic + "\nSocieties: " + societies + "\nRank: " + rank);
		}
	}//class Grades
	abstract class Grades : Course
	{
		//boolean type variable noncredit
		bool noncredit = false;

		//checkcredits
		public void checkCredits()
		{
			if (noncredit)
				Console.WriteLine("Non credit subject");
			else
				Console.WriteLine("Credit subject");

		}
	
		//ABSTRACT METHOD
		public abstract char distinction();
	}
	
	//class CourseApp
	class StudentApp
	{
		public static void Main(string[] args)
		{


			//Student array - object initializers
			Student[] stList = new Student[]
			{
				new Student{ Name="Jhon",Gender='M',RegNum="2017/ICTS/01"},
				new Student{ Name="Meera",Gender='F',RegNum="2017/ICTS/14"},
			};
			
			//Course array - object initializers
			Course[] crsList = new Course[]
			 {
				new Course{Coursename="C++",Credits=1,InCharge="Dr.Margret",TotalHours=15},
				new Course{Coursename="Java",Credits=2,InCharge="Mr.Kevin",TotalHours=30},

			 };

			//array
			String[] awards = { "Dean's List Award 2018/2019", "Second Year Best Performance Award - 2018", "Faculty Award - 2020" };
			Console.WriteLine("\n\n\n-------------------------------------------------");
			Console.WriteLine("Welcome");
			Console.WriteLine("---------------------------------");
			
			//set array awards to AwardsList
			stList[1].AwardsList = awards;
			stList[1].printDetails(); //invoke printDetails method
			Console.WriteLine("---------------------------------");
			
			//print all student names
			Console.WriteLine("Student Names: ");
			for (int i = 0; i < stList.Length; i++)
			{
				Console.WriteLine((i + 1) + "." + stList[i].Name);
			}
			Console.WriteLine("---------------------------------");
			
			//COURSE AVAILABILITY
			Console.WriteLine("--------------------- \nCOURSE AVAILABILITY\n---------------------");
			//printing all the Course names with a serial number
			Console.WriteLine("\n*********\nCourse Name\n***********");
			for (int i = 0; i < crsList.Length; i++)
			{
				Console.WriteLine(i + 1 + ") " + crsList[i].Coursename);
			}
			//CHECKING AVAILABILITY
			Console.Write("Enter the Course name to find availability: ");

			string crsName = Console.ReadLine();
			bool available = false;
			for (int i = 0; i < crsList.Length; i++)
			{
				if (crsList[i].checkCourse(crsName))
				{
					available = true;
					break;
				}

			}
			if (available)
			{
				Console.WriteLine("The course is available");

			}
			else Console.WriteLine("The course is not available");

			Console.WriteLine("---------------------------------");
			
			Console.WriteLine("--------------------- \nCOURSE DETAILS\n---------------------");
			
			//printing all the Course names with a serial number
			Console.WriteLine("\n*********\nCourse Name\n***********");
			for (int i = 0; i < crsList.Length; i++)
			{
				Console.WriteLine(i + 1 + ") " + crsList[i].Coursename);
			}
			int crsnum;


			Console.Write("Select the Course you need to find details: ");

			crsnum = Convert.ToInt32(Console.ReadLine());
			crsList[crsnum - 1].printCoursedetails();
			Console.WriteLine("---------------------------------");
			
			Console.WriteLine("--------------------- \nDURATION DETAILS\n---------------------");
			
			//printing all the Course names with a serial number
			Console.WriteLine("\n*********\nCourse Name\n***********");
			for (int i = 0; i < crsList.Length; i++)
			{
				Console.WriteLine(i + 1 + ") " + crsList[i].Coursename);
			}
			Console.WriteLine("Enter the number of the Course you need to find duration details: ");

			crsnum = Convert.ToInt32(Console.ReadLine());
			crsList[crsnum - 1].checkDuration();
			Console.WriteLine("---------------------------------");

			Console.WriteLine("--------------------- \nATTENDANCE PERCENTAGE\n---------------------");
			
			//printing all the Course names with a serial number
			Console.WriteLine("\n*********\nCourse Name\n***********");
			for (int i = 0; i < crsList.Length; i++)
			{
				Console.WriteLine(i + 1 + ") " + crsList[i].Coursename);
			}
			Console.WriteLine("Select the Course you need to find Attendance Percentage: ");
			crsnum = Convert.ToInt32(Console.ReadLine());
			//creating instance for delegate
			NewDelegate del1 = crsList[crsnum - 1].attendancePercentage;
			//using delegate to invoke attendancePercentage method
			del1();
			Console.WriteLine("-------------------------------------------------\n");

			Console.WriteLine("Thank You!");

			Console.ReadKey();
		}
	}


}



