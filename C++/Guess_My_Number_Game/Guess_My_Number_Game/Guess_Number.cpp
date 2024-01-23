#include <iostream>
using namespace std; 

int main()
{
	int secretNum = 7;
	int guessNum;
	bool notGuessed = true;
	while (notGuessed)
	{
		cout << "Please guess a number between 1 and 10:\n";
		cin >> guessNum; '\n';

		if (guessNum == secretNum)
		{
			cout << "Congrats you guessed the number";
			notGuessed = false;
		}

		if (guessNum > secretNum)
		{
			cout << "Your guess is too high. ";
		}

		if (guessNum < secretNum)
		{
			cout << "Your guess is too low. ";
		}

		//exit the loop if the user guesses the correct number

	}
	
	


	

	


}