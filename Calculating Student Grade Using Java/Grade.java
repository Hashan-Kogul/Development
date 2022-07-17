class Grade extends Course
{
	boolean nonCredit=false;
	
	public void checkCredit()
	{
		if (nonCredit==0)
		{
			System.out.println("Non Credit Subject");
		}
	}
}

	