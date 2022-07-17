class AcademicStaff extends StaffMember
{
	final double academicallowence=25.00;
	
	AcademicStaff(String name,String nic,int age,double basicsalary,double loaninstallment)
	{
		super(name,nic,age,basicsalary,loaninstallment);
	}
	
	public double getSalary()
	{
		double totalSalary=basicsalary+allowence+(basicsalary/100)*academicallowence-loaninstallment;
		return totalSalary;
	}
	
}