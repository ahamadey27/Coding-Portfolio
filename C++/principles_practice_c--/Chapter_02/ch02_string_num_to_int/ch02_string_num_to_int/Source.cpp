#include "std_lib_facilities.h"

int main()
{
	cout << "Enter zero, one, two three or four and will output the coresspending integer.\n";
	string numString;
	cin >> numString;

	if (numString == "zero")
	{
		cout << "You entered: 0.\n";
	}
	else if (numString == "one")
	{
		cout << "You entered: 1.\n";
	}
	else if (numString == "two")
	{
		cout << "You entered: 2.\n";
	}
	else if (numString == "three")
	{
		cout << "You entered: 3.\n";
	}
	else if (numString == "four")
	{
		cout << "You entered: 4.\n";
	}

	return 0;
}


