class Student
{
	private String name;
	private String gender;
	private String reg_number;
	private String academicyear;
	
	//getter method for name
	public String getName()
	{
		return name;
	}
	
	//getter method for gender
	public String getGender()
	{
		return gender;
	}
	
	//getter method for registration number
	public String getRegistrationNumber()
	{
		return reg_number;
	}
	
	//getter method for academicyear
	public String getAcademicYear()
	{
		return academicyear;
	}
		
	//setter method for name 
	public void setName(String name)
	{
		this.name=name;
	}
	
	//setter method for Gender 
	public void setGender(String gender)
	{
		this.gender=gender;
	}
	
	//setter method for reg_number 
	public void setRegistrationNumber(String reg_number)
	{
		this.reg_number=reg_number;
	}
	
	//setter method for AcademicYear
	public void setAcademicYear(String academicyear)
	{
		this.academicyear=academicyear;
	}
	
	Student(String name,String gender,String reg_number,String academicyear)
	{
		this.name=name;
		this.gender=gender;
		this.reg_number=reg_number;
		this.academicyear=academicyear;
	}
}