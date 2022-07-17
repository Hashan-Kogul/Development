class NonAcademicStaff extends StaffMember
{
	private double overtimehours;
	private double overtimepayment;
	
	NonAcademicStaff(String name,String nic,int age,double basicsalary,double loaninstallment,double overtimehours)
	{
		super(name,nic,age,basicsalary,loaninstallment);
		this.overtimehours=overtimehours;
	}
	
	public double overtimeAmount()
	{
		overtimepayment=(basicsalary/(20*8))*overtimehours;
		return overtimepayment;
	}
	
	public double getSalary()
	{
		double totalSalary=basicsalary+allowence+overtimepayment-loaninstallment;
		return totalSalary;
	}
}
