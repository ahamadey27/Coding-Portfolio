#include "std_lib_facilities.h"
//function from input.cpp file read from main Source.cpp 
int getInteger();

int main()
{
	int x{ getInteger() };
	int y{ getInteger() };

	cout << x << " + " << y << " is " << x + y << "\n";

	return 0;
}


