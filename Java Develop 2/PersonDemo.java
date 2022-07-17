class PersonDemo
{
	public static void main(String[] args)
	{
		System.out.println("-----Student------");
		Student ob1=new Student("Hashan Kogul","990863490v",22,3.6,3.7,3.8,3.9);
		ob1.print();
		System.out.println("Final GPA: "+ob1.calculateFinalGpa());
		System.out.println("Final Result: "+ob1.getFinalResult());

		System.out.println("**************************");

		System.out.println("------Academic Staff---------");
		AcademicStaff ob2=new AcademicStaff("James Bond","809645890v",40,92500.50,22400.25);
		ob2.print();
		System.out.println("Salary: "+ob2.getSalary());

		System.out.println("****************************");

		System.out.println("-------Non Academic Staff----------");
		NonAcademicStaff ob3=new NonAcademicStaff("James Victor","938564785v",27,41500.50,17800.30,8);
		ob3.print();
		System.out.println("Over time Amount: "+ob3.overtimeAmount());
		System.out.println("Total Salary: "+ob3.getSalary());


	}
}