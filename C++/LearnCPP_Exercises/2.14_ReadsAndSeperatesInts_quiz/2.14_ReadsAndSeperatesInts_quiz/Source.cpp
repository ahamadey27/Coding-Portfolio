#include "std_lib_facilities.h"
//Single program that reads and two seperate ints from user, adds them together and ouputs the answer

int readNumber()
{
	cout << "Please enter an integer and we'll add them together.\n";
	int intX {};
	cin >> intX;
	return intX;
}

void writeAnswer(int intX)
{
	cout << "The answer is : " << intX << '\n';
}
int main()

{
	int x{ readNumber() };
	int y{ readNumber() };

	writeAnswer(x + y);

	return 0;
}


