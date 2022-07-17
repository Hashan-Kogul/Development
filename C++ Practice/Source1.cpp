#include <iostream>
using namespace std;
int main()
{
	string name;
	int total = 0;
	int mark;
	int average;
	int i;

	cout << "Enter the name : " << endl;
	cin >> name;

	for (i = 1; i <=5; i++)
	{
		cout << "Enter the mark : " << endl;
		cin >> mark;
		total += mark;
	}
	average = total / 5;

	cout << "Total marks is : " << total << endl;
	cout << "Average mark is : " <<average<<endl;

	if (average >= 80 && average <= 100)
		cout << "A" << endl;
	else if (average >= 65 && average < 80)
		cout << "B" << endl;
	else if (average >= 50 && average < 65)
		cout << "C" << endl;
	else if (average >= 35 && average < 50)
		cout << "D" << endl;
	else
		cout << "E"<<endl;


	system("pause");
	return 0;
}