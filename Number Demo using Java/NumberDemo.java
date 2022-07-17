//2018 PAST PAPER ANSWER
import java.util.Scanner;

class IntegerNumbers
{
	int a[]=new int[10];
	IntegerNumbers(int a[])
	{
		this.a=a;
	}
	
	int sum(int a[])
	{
		int sum=0;
		for(int i=0;i<a.length;i++)
		{
			sum+=a[i];
		}
		return sum;
	}
	
	void print(int b[])
	{
		for(int i=0;i<b.length;i++)
		{
			System.out.println(b[i]);
		}
	}
}
final class NegativeNumbers extends IntegerNumbers
{
	NegativeNumbers(int a[])
	{
		super(a);
	}
	int countNegative()
	{
		int count=0;
		for(int i=0;i<super.a.length;i++)
		{
			if(super.a[i]<0)
				count++;
			
		}
		return count;
	}
	void printNegative()
	{
		int len=countNegative();
		int j=0;
		int arr[]=new int[len];
		for(int i=0;i<super.a.length;i++)
		{
			if(super.a[i]<0)
			{
				arr[j]=super.a[i];
				j++;
			}
		}
		System.out.println("The negative numbers in the array ");
		super.print(arr);
		System.out.println("The summation of the negative numbers: ");
		System.out.println(sum(arr));
	}
}
class WholeNumbers extends IntegerNumbers
{
	int []x;
	WholeNumbers(int []a)
	{
		super(a);
		
	}
	int countWhole()
	{
		int count=0;
		for(int i=0;i<a.length;i++)
		{
			if(a[i]>=0)
				count++;
		}
		return count;
	}
	void storeWhole()
	{
		int xlen=countWhole();
		x=new int[xlen];
		int j=0;
		for(int i=0;i<super.a.length;i++)
		{
			if(super.a[i]>=0)
			{
				x[j]=super.a[i];
				j++;
			}
		}
	}

}
class EvenNumber extends WholeNumbers
{
	EvenNumber(int []a)
	{
		super(a);
	}
	void findEven()
	{
		System.out.println("Even numbers are:");
		super.storeWhole();
		
		for(int i=0;i<super.x.length;i++)
		{
			if(super.x[i]%2==0)
			{
				System.out.println(super.x[i]);
			}
		}
	}
	
}
class OddNumber extends WholeNumbers
{
	OddNumber(int []a)
	{
		super(a);
	}
	void findOdd()
	{
		System.out.println("Odd numbers are:");
		super.storeWhole();
		for(int i=0;i<super.x.length;i++)
		{
			if(super.x[i]%2!=0)
			{
				System.out.println(super.x[i]);
			}
		}
	}
}


class NumberDemo
{
	
		Scanner sc=new Scanner(System.in);
		int y[]=new int[10];
		//int []y={0,1,2,3,-4,5,6,-7,8,9};
		void getArray()
		{
			System.out.println("Enter the numbers for the array:");
			for(int i=0;i<y.length;i++)
			{
				//System.out.print(i+ " :");
				y[i]=sc.nextInt();
			}
		}
		
	public static void main(String []args)
	{
		NumberDemo nd=new NumberDemo();
		nd.getArray();
		
		IntegerNumbers inum=new IntegerNumbers(nd.y);
		System.out.println("The summation of the elements are:");
		System.out.println(inum.sum(nd.y));
		
		NegativeNumbers ng=new NegativeNumbers(nd.y);
		ng.printNegative();
		
		EvenNumber en=new EvenNumber(nd.y);
		en.findEven();
		
		OddNumber on=new OddNumber(nd.y);
		on.findOdd();

	}
}
