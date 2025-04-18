#include "std_lib_facilities.h"

int main()
{
	cout << "Enter a number and will determine if its odd or even: \n";
	int num;
	cin >> num;

	if (num % 2 == 0)
	{
		cout << num << " is an even number.\n";
	}
	else
	{
		cout << num << " is an odd number.\n";
	}
	return 0;
}


