#include <iostream>
using namespace std;

/*Guessing game where computer try to guess user number within seven tries*/

int main()
{
	int lower = 1;
	int upper = 100;
	int guess;
	char response; 

	std::cout << "Think of a number between " << lower << " and " << upper << ".\n";
	std::cout << "I will try to guess it. Respond with:\n";
	std::cout << "'h' if my guess is too high,\n";
	std::cout << "'l' if my guess is too low,\n";
	std::cout << "'c' if my guess is correct.\n";

	while (lower <= upper)
	{
		guess = (lower + upper) / 2;
		cout << "Is your number " << guess << "? (h/l/c): \n";
		cin >> response;

		if (response == 'h')
		{
			upper = guess - 1;
		}

		else if (response == 'l')
		{
			lower = guess + 1;
		}

		else if (response == 'c')
		{
			cout << "I guess your number " << guess << "\n";
		}
		else
		{
			cout << "Invalid response. Use the h, l or c keys";
		}
	}

	if (lower > upper)
	{
		cout << "There is an error";
	}

	return 0;
}