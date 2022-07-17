class Person
{
	private String name;
	private String nic;
	private int age;
	
	Person(String name,String nic,int age)
	{
		this.name=name;
		this.nic=nic;
		this.age=age;
	}
	
	public void print()
	{
		System.out.println("Name : "+name);
		System.out.println("NIC : "+nic);
		System.out.println("Age : "+age);
	}
	
}
	