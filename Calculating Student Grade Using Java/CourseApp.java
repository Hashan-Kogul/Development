import java.util.Scanner;
class CourseApp
{
	public static void main(String []args)
	{
		//Object for student
		Student s1=new Student("Hashan Kogul","Male","2018ICTS85","2018");
		
		s1.setName("Hashan Kogul");
		System.out.println("Student Name Is : "+s1.getName());
		
		s1.setGender("Male");
		System.out.println("Student Gender Is : "+s1.getGender());
		
		s1.setRegistrationNumber("2018ICTS85");
		System.out.println("Student Registration Number Is : "+s1.getRegistrationNumber());
		
		s1.setAcademicYear("2018");
		System.out.println("Student Academic Year Is : "+s1.getAcademicYear());
		
		System.out.println("**********************************************");
		System.out.println("Course Details are given below ");
		
		//Object for BICT Course
		Course c1=new Course("BICT",120,"Mr.Senthooran");
		Course c2=new Course("BICT",120,"Mr.Senthooran",100,"Hashan");
		
		c1.setCourseName("BICT");
		System.out.println("Course Name Is : "+c1.getCourseName());
			
		c1.setCredits(120);
		System.out.println("Course Credits : "+c1.getCredits());
		
		c1.setInCharge("Mr.Senthooran");
		System.out.println("Course IN-Charge : "+c1.getInCharge());
		
		c2.setTotalHours(100);
		System.out.println("Course Total Hours : "+c2.getTotalHours());
		
		System.out.println("**********************************************");
		
		//Course 2 for BS Course
		Course c3=new Course("BS",100,"Mr.Vasanth");
		Course c4=new Course("BS",100,"Mr.Vasanth",120,"Hashan");
		
		c3.setCourseName("BS");
		System.out.println("Course Name Is : "+c3.getCourseName());
		
		c3.setCredits(100);
		System.out.println("Course Credits : "+c3.getCredits());
		
		c3.setInCharge("Mr.Vasanth");
		System.out.println("Course IN-Charge : "+c3.getInCharge());
		
		c4.setTotalHours(120);
		System.out.println("Course Total Hours : "+c4.getTotalHours());
		
		System.out.println("**********************************************");
		
		//Course 3 for Applied Science Course
		Course c5=new Course("Applied Science",110,"Mr.Kumar");
		Course c6=new Course("Applied Science",110,"Mr.Kumar",130,"Hashan");
		
		c5.setCourseName("Applied Science");
		System.out.println("Course Name Is : "+c5.getCourseName());
		
		c5.setCredits(110);
		System.out.println("Course Credits : "+c5.getCredits());
		
		c5.setInCharge("Mr.Kumar");
		System.out.println("Course IN-Charge : "+c5.getInCharge());
		
		c6.setTotalHours(130);
		System.out.println("Course Total Hours : "+c6.getTotalHours());
		
		System.out.println("**********************************************");
		
		
		Scanner sc=new Scanner(System.in);
		System.out.println("Enter the choice : ");
		String choice=sc.nextLine();
		
		if(choice.equals("BICT"))
		{
			//Calling Methods
			System.out.println("Course Availability : "+c1.checkCourse());
			c2.checkDuration();
			c2.printCourseDetails();
			System.out.println("Attendence Persentage Is : "+c2.attendencePercentage());
			
			System.out.println("**********************************************");
			System.out.println("Course Details are given below ");
			c2.printCourseDetails();
			System.out.println("**********************************************");
			c4.printCourseDetails();
			System.out.println("**********************************************");
			c6.printCourseDetails();
		}
		else if(choice.equals("BS"))
		{
			//Course 2 methods
			System.out.println("Course Availability : "+c3.checkCourse());
			c4.checkDuration();
			c4.printCourseDetails();
			System.out.println("Attendence Persentage Is : "+c4.attendencePercentage());
			
			System.out.println("**********************************************");
			System.out.println("Course Details are given below ");
			c2.printCourseDetails();
			System.out.println("**********************************************");
			c4.printCourseDetails();
			System.out.println("**********************************************");
			c6.printCourseDetails();
		}
		else if(choice.equals("Applied Science"))
		{
			//Course 2 methods
			System.out.println("Course Availability : "+c5.checkCourse());
			c6.checkDuration();
			c6.printCourseDetails();
			System.out.println("Attendence Persentage Is : "+c6.attendencePercentage());
			
			System.out.println("**********************************************");
			System.out.println("Course Details are given below ");
			c2.printCourseDetails();
			System.out.println("**********************************************");
			c4.printCourseDetails();
			System.out.println("**********************************************");
			c6.printCourseDetails();
		}
		else
		{
			System.out.println("Course is not Available");
		}
	}
}