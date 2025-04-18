#include <iostream>
#include <vector>
using namespace std;

int main()
{

	vector<string> numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven",
								"eight", "nine"};

	int userInput;
	cout << "Please enter a number between 0 and nine to see how the number is spelled.\n";
	cin >> userInput;

	if (userInput >= 0 && userInput <= 9)
	{
		cout << "The number " << userInput << " is spelled as: " << numbers[userInput] << endl; 
	}
	else
	{
		cout << "Please enter a valid number" << endl; 
	}

	return 0;
}