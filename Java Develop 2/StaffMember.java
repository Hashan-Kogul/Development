abstract class StaffMember extends Person
{
	double basicsalary;
	final double allowence=7800.00;
	double loaninstallment;
	
	StaffMember(String name,String nic,int age,double basicsalary,double loaninstallment)
	{
		super(name,nic,age);
		this.basicsalary=basicsalary;
		this.loaninstallment=loaninstallment;
	}
	
	abstract public double getSalary();
}

