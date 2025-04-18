#include "std_lib_facilities.h"
//reads an int from user, doubles it using the doubleNumber() funtion and prints doubled num to console

int doubleNumber(int x)
{
	return 2 * x;
}

int main()
{

	cout << "Enter a number and it will be doubled.\n";
	int x; 
	cin >> x; 
	cout << "The number doubled is: " << doubleNumber(x) << ".\n"; 

	return 0;
}


