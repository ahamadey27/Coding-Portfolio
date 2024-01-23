
#include <iostream>
using namespace std;

void nameFunction(string fname, string lname)
{
	cout << fname << " " << lname << " is the name of this person." << '\n';
}

int numberFunction(int x, int y)
{
	return x + y; 
}

int main()
{
	nameFunction("Alex", "Hamadey");
	nameFunction("Bill", "Smith");
	nameFunction("Jane", "Jerry");
	cout << numberFunction(5, 10); 

	return 0;
}

