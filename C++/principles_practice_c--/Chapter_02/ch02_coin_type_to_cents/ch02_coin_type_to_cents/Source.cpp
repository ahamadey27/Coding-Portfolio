#include "std_lib_facilities.h"
//Enter the amount of change and will compute how many cents you have 
int main()
{
	int pennies, nickles, dimes, quarters, halfDollars;
	cout << "Enter the amount of pennies, nickles, dimes, quarters and half dollars.\nAnd we'll calculate how manny cents you have.\n";
	cout << "How many pennies, nickles, dimes, quarters and half dollars do you have?\n";
	cin >> pennies >> nickles >> dimes >> quarters >> halfDollars;

	int penniesAmount = pennies; 
	int nicklesAmount = nickles * 5;
	int dimesAmount = dimes * 10;
	int quartersAmount = quarters * 25;
	int halfDollarsAmount = halfDollars * 50;

	int totalAmount = penniesAmount + nicklesAmount + dimesAmount + quartersAmount + halfDollarsAmount; 

	cout << "You have: \nPennies: " << pennies << "\nNickles: " << nickles << "\nDimes: " << dimes << "\nQuarters: " << quarters << "\nHalf-Dollars: " << halfDollars << "\nTotal Amount of Cents: " << totalAmount;

	return 0;
}


