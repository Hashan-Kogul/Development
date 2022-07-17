class Cricketer
{
	protected String name;
	protected String birthdate;
	protected double height;
	protected String country;
	protected String role;
	
	Cricketer(String name,String birthdate,double height,String country)
	{
		this.name=name;
		this.birthdate=birthdate;
		this.height=height;
		this.country=country;
	}
	
	public void setRole(String role)
	{
		this.role=role;
	}
	
	public String getRole()
	{
		return role;
	}
	
	public void printDetails()
	{
		System.out.println("Name : "+name);
		System.out.println("Birthdate : "+birthdate);
		System.out.println("Height : "+height);
		System.out.println("Country : "+country);
	}
}

class Batsman extends Cricketer
{
	protected int runs;
	protected int innings;
	protected int ballfaced;
	double BattingStrikerate;
	
	Batsman(String name,String birthdate,double height,String country,int runs,int innings,int ballfaced)
	{
		super(name,birthdate,height,country);
		this.runs=runs;
		this.innings=innings;
		this.ballfaced=ballfaced;
	}
	
	public double getBattingAverage()
	{
		double BattingAverage=runs/innings;
		return BattingAverage;
	}
	
	public double getBattingStrikerate()
	{
		BattingStrikerate=100*runs/ballfaced;
		return BattingStrikerate;
	}
	
	public boolean checkSuitability()
	{
		if(BattingStrikerate>100)
		{
		
			return true;
		}
		
		return false;
	}
	
	public int calculateHightest(int[] array)
	{
		int max=array[0];
		
		for(int i=1; i<array.length; ++i)
		{
			if(array[i]>max)
			{
				max=array[i];
			}
		}
		return max;
		
	}
	
	public void printDetails()
	{
		super.printDetails();
	}
	
	public void setRole(String role)
	{
		super.setRole(role);
	}
	
	public String getRole()
	{
		return role;
	}
}

class Bowler extends Cricketer
{
	protected int runs;
	protected int wickets;
	protected int balls;
	
	Bowler(String name,String birthdate,double height,String country,int runs,int wickets,int balls)
	{
		super(name,birthdate,height,country);
		this.runs=runs;
		this.wickets=wickets;
		this.balls=balls;
	}
	
	public double getBowlingAverage()
	{
		double BowlingAverage=runs/wickets;
		return BowlingAverage;
	}
	
	public double getBowlingEconomyrate()
	{
		double overs=balls/6;
		double BowlingEconomyRate=runs/overs;
		return BowlingEconomyRate;
	}
	
	public double getBowlingStrikerate()
	{
		double BowlingStrikeRate=balls/wickets;
		return BowlingStrikeRate;
	}
	
	public void printDetails()
	{
		super.printDetails();
	}
	
	public void setRole(String role)
	{
		super.setRole(role);
	}
	
	
	public String getRole()
	{
		return role;
	}
}

class Match
{
	
	int[] arrRank={1,2,3,4,5,6,7};
	String[] arrCountry={"India","South Africa","England","Australia","Afghanistan","Sri Lanka","Bangladesh"};
	int a,b;
	
	protected String team01;
	protected String team02;
	
	Match(String team01,String team02)
	{
		this.team01=team01;
		this.team02=team02;
	}
	
	public String getWinningTeam()
	{
		for(int i=0; i<arrCountry.length; ++i)
		{
			if(arrCountry[i]==team01)
			{
				a=arrRank[i];
			}
			else if(arrCountry[i]==team02)
			{
				b=arrRank[i];
			}
		}
		
		if(a<b)
		{
			return arrCountry[a-1];
		}
		else
		{
			return arrCountry[b-1];
		}

		
	}
	
	public static void main(String args[])
	{	
		
			int[] array={12,45,96,78,23,69,85,63,45,10};
		
		
		Batsman ob1=new Batsman("Dinesh Chandimal","18/11/1989",5.8,"Sri Lanka",774,46,746);
		ob1.printDetails();
		System.out.println("Batting Average : "+ob1.getBattingAverage());
		System.out.println("Batting Strike Rate : "+ob1.getBattingStrikerate());
		System.out.println("Suitability : "+ob1.checkSuitability());
		System.out.println("Highest Score : "+ob1.calculateHightest(array));
		ob1.setRole("Batsman");
		System.out.println("Role : "+ob1.getRole());
		
		System.out.println(" ");
		System.out.println("                                  ");
		System.out.println(" ");
		
		Bowler ob2=new Bowler("Lasith Malinga","28/08/1983",5.6,"Sri Lanka",1780,90,1451);
		ob2.printDetails();
		System.out.println("Bowling Average : "+ob2.getBowlingAverage());
		System.out.println("Bowling Economy Rate : "+ob2.getBowlingEconomyrate());
		System.out.println("Bowling Strike Rate : "+ob2.getBowlingStrikerate());
		ob2.setRole("bowler");
		System.out.println("Role : "+ob2.getRole());
		
		
		System.out.println(" ");
		System.out.println("                                  ");
		System.out.println(" ");
		
		
		Match ob3=new Match("India","Australia");
		System.out.println("Winning Team : "+ob3.getWinningTeam());
	}
}