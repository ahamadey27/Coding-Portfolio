#include "std_lib_facilities.h"

int main()
{

	cout << "Enter amount of miles that will be converted to Km.\n";
	int miles;
	cin >> miles; 

	double kmConversion;
	kmConversion = miles / 1.609;
	cout << miles << " is about " << kmConversion << " kilomters.\n";
		
	return 0;
}


