import java.util.Scanner;
class Course
{
	private String courseName;
	private int credits;
	private String inCharge;
	private int totalHours;
	private String student;
	
	Course(String courseName,int credits,String inCharge)
	{
		this.courseName=courseName;
		this.credits=credits;
		this.inCharge=inCharge;
	}
	
	Course(String courseName,int credits,String inCharge,int totalHours,String student)
	{
		this.courseName=courseName;
		this.credits=credits;
		this.inCharge=inCharge;
		this.totalHours=totalHours;
		this.student=student;
	}
	
	//getter method for courseName
	public String getCourseName()
	{
		return courseName;
	}
	
	//getter method for credits
	public int getCredits()
	{
		return credits;
	}
	
	//getter method for In-Charge
	public String getInCharge()
	{
		return inCharge;
	}
	
	//getter method for TotalHours
	public int getTotalHours()
	{
		return totalHours;
	}
	
	//setter method for courseName
	public void setCourseName(String courseName)
	{
		this.courseName=courseName;
	}
	
	//setter method for credits
	public void setCredits(int credits)
	{
		this.credits=credits;
	}
	
	//setter method for In-Charge
	public void setInCharge(String inCharge)
	{
		this.inCharge=inCharge;
	}
	
	//setter method for TotalHours
	public void setTotalHours(int totalHours)
	{
		this.totalHours=totalHours;
	}
	
	boolean checkCourse()
	{
		if(courseName=="BICT" || courseName=="BS" || courseName=="Applied Science")
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
		if (totalHours>15)
		{
			System.out.println("Course Duration : The duration exceeds the limit");
		}
		else
		{
			System.out.println("Course Duration : Duration is limited");
		}
	}
	
	public void printCourseDetails()
	{
		System.out.println("Course Name Is : "+courseName);
		System.out.println("Credits : "+credits);
		System.out.println("Course In-Charge : "+inCharge);
		System.out.println("Course Total-Hours : "+totalHours);
	}
	
	public double attendencePercentage()
	{
		Scanner sc=new Scanner(System.in);
		System.out.println("Enter the number of lectures attended : ");
		int n=sc.nextInt();
		
		double percentage=n*(10/3);
		return percentage;
	}
	
}