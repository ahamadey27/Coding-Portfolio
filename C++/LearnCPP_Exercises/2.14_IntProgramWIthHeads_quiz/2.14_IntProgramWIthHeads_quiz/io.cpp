#include "std_lib_facilities.h"

int readNumber()
{
	cout << "Please enter an integer and we'll add them together.\n";
	int intX{};
	cin >> intX;
	return intX;
}

void writeAnswer(int intX)
{
	cout << "The answer is : " << intX << '\n';
}
