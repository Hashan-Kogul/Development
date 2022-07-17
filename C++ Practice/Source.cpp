#include <iostream>
using namespace std;

	int fact(int num)
	{
		if (num == 1)
		{
			return 1;
		}
		else
		{
			int factorial = num * fact(num - 1);
			return factorial;
		}
	}
	int main1()
	{
		int num;
		cout << "Enter a number : " << endl;
		cin >> num;
		cout << "Factorial is : " << fact(num) << endl;

		system("pause");
		return 0;
	}