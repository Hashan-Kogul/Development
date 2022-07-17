import java.util.Scanner;
class BankAccount {
	String acctype;
	String accHolderName;
	double balance;
	double minbalance=500;
	double annualint;
	
	void bankaccount(String acctype,String accHolderName,double balance,double annualint){
		System.out.println("The Account type is : "+acctype);
		System.out.println("The Account Holder name is : "+accHolderName);
		System.out.println("The Account balance is : "+balance);
		System.out.println("The Account Annual Intrest is : "+annualint);
	}
	
	void deposit(double ammount,double balance){
		balance+=ammount;
		System.out.println("Now Your Account balance is : "+balance);
	}
	
	void withdraw(double ammount,double balance){
		if(ammount<balance){
			balance-=ammount;
			System.out.println("Now Your Account balance is : "+balance);
		}
		else
			System.out.println("Now Your Account balance is insufficiant");
		}
	void checkbalance(String accHolderName,double balance){
		System.out.println("The Account Holder name is : "+accHolderName);
		System.out.println("Now Your Account balance is : "+balance);
		
	}
	
	public static void main(String []args){
		System.out.println("-----Program for Bank Account-----");
		BankAccount bank=new BankAccount();
		String accHolderName;
		double balance;
		double ammount;
		Scanner ch=new Scanner(System.in);
		System.out.print("Enter Account Holder name : ");
		accHolderName=ch.nextLine();
		System.out.print("Enter Account Balance : ");
		balance=ch.nextInt();
		System.out.println("Choice your Account type // Serving Account-S // Current Account-C  : ");
		char type=ch.next().charAt(0);
		SavingAccount save=new SavingAccount();
		CurrentAccount current=new CurrentAccount();
		switch(type){
			case 'S':
			save.bankaccount("Saving",accHolderName,balance ,0.0);
			break;
			case 'C':
			current.bankaccount("Current",accHolderName,balance ,0.0);
			break;
			default:
			System.out.println("Wrong option Selected");
		}	
			
		System.out.println("Choice your need // Your Accout details-M // Deposit-D // Withdra-W // Checkbalance-B //  : ");
		char need=ch.next().charAt(0);
		switch(need){
			case 'M':
			bank.bankaccount("",accHolderName,balance ,0.0);
			break;
			case 'D':
			Scanner d=new Scanner(System.in);
			System.out.print("Enter your Diposit Ammount: ");
			ammount=d.nextInt();
			bank.deposit(ammount,balance);
			break;
			case 'W':
			Scanner w=new Scanner(System.in);
			System.out.print("Enter your Withdra Ammount: ");
			ammount=w.nextInt();
			bank.withdraw(ammount,balance);
			break;
			case 'B':
			bank.checkbalance(accHolderName,balance);
			break;
			default:
			System.out.println("Wrong option Selected");
		}
			
	}
	
}
class SavingAccount extends BankAccount{
	String acctype;
	String accHolderName;
	double balance;
	double minbalance=500;
	double annualint;
	
	void bankaccount(String acctype,String accHolderName,double balance,double annualint){
		System.out.println("The Account type is : "+acctype);
		System.out.println("The Account Holder name is : "+accHolderName);
		System.out.println("The Account balance is : "+balance);
		System.out.println("The Account Annual Intrest is : "+annualint);
	}
	
}
class CurrentAccount extends BankAccount{
	String acctype;
	String accHolderName;
	double balance;
	double minbalance=500;
	double annualint;
	
	void bankaccount(String acctype,String accHolderName,double balance,double annualint){
		System.out.println("The Account type is : "+acctype);
		System.out.println("The Account Holder name is : "+accHolderName);
		System.out.println("The Account balance is : "+balance);
		System.out.println("The Account Annual Intrest is : "+annualint);
	}
	
}