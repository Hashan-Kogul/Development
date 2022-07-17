class Student extends Person
{
	private double gpa1;
	private double gpa2;
	private double gpa3;
	private double gpa4;
	private double finalgpa;
	private String result;
	
	Student(String name,String nic,int age,double gpa1,double gpa2,double gpa3,double gpa4)
	{
		super(name,nic,age);
		this.gpa1=gpa1;
		this.gpa2=gpa2;
		this.gpa3=gpa3;
		this.gpa4=gpa4;
	}
	
	public double calculateFinalGpa()
	{
		finalgpa=(gpa1+gpa2+gpa3+gpa4)/4;
		return finalgpa;
	}
	
	public String getFinalResult()
	{

		if(calculateFinalGpa()>=3.70)
		{
			result="First Class";
			return result;
		}
		else if(3.30 <= calculateFinalGpa())
		{
			result="Second Class(Upper Division)";
			return result;
		}
		else if(3.00 <= calculateFinalGpa())
		{
			result = "Second Class(Lower Division)";
			return result;
		}
		else
		{
			result = "Pass";
			return result;
		}

	}
}