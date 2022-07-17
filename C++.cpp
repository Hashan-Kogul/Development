#include <iostream>
#include <string>
using namespace std;
void dnaCount(char dna[]) {
	int cG1 = 0, cT1 = 0, cA1 = 0, cC1 = 0;
	int index = 20;

	for (int i = 0; i < index; i++)
	{
		if (dna[i] == 'G') {
			cG1++;
		}
		if (dna[i] == 'T') {
			cT1++;
		}
		if (dna[i] == 'A') {
			cA1++;
		}
		if (dna[i] == 'C') {
			cC1++;
		}
	}

	cout << "Amount of G " << cG1 << endl;
	cout << "Amount of T " << cT1 << endl;
	cout << "Amount of A " << cA1 << endl;
	cout << "Amount of C " << cC1 << endl;

}

void dnaMax(char dna[]) {
	int cG1 = 0, cT1 = 0, cA1 = 0, cC1 = 0;
	int index = 20;

	for (int i = 0; i < index; i++)
	{
		if (dna[i] == 'G') {
			cG1++;
		}
		if (dna[i] == 'T') {
			cT1++;
		}
		if (dna[i] == 'A') {
			cA1++;
		}
		if (dna[i] == 'C') {
			cC1++;
		}
	}

	int maximus = cG1;
	string printerV;

	if (maximus < cT1)
	{
		maximus = cT1;
		printerV = "T";
	}

	else if (maximus < cA1)
	{
		maximus = cA1;
		printerV = "A";
	}
	else if (maximus < cC1)
	{
		maximus = cC1;
		printerV = "C";
	}
	else
	{
		maximus = cG1;
		printerV = "G";
	}
	cout << printerV << " is the Maximum and it's value is " << maximus << endl;

}


void change(char dna[]) {
	int cG1 = 0, cT1 = 0, cA1 = 0, cC1 = 0;
	int index = 20;

	cout << "Before :  ";
	for (int i = 0; i < index; i++)
	{
		cout << dna[i] << " ";
	}
	cout << endl;

	for (int i = 0; i < index; i++)
	{
		if (dna[i] == 'G') {
			dna[i]='C';
		}
		else if (dna[i] == 'T') {
			dna[i] = 'A';
		}
		else if (dna[i] == 'A') {
			dna[i] = 'U';
		}
		else if (dna[i] == 'C') {
			dna[i] = 'G';
		}
	}
	

	cout << "After  :  ";
	for (int i = 0; i < index; i++)
	{
		cout << dna[i] << " ";
	}
	cout << endl;


}

int main() 
{

	char DNA[] = { 'G','T','A','A','T','C','C','C','G','T','A','G','C','T','T','G','C','C','G','A' };

	dnaCount(DNA);
	dnaMax(DNA);
	change(DNA);
	
	cout << endl;
	return 0;
}