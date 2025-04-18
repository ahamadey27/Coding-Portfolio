#include <iostream>
#include <cstdlib> //for rand() and srand()
#include <ctime>

using namespace std;

int main()
{
	srand(time(0)); // Initialize random number generator

	int playerChoice;
	int computerChoice = rand() % 3; //Random number between 0 and 2

	cout << "Enter your choice: (0 for Rock, 1 for Paper, 2 for Scissors): \n";
	cin >> playerChoice;

	// Check for invalid input
	if (playerChoice < 0 || playerChoice > 2) {
		cout << "Invalid choice! Please enter 0, 1, or 2.\n";
		return 1;
	}

	//player choice
	if (playerChoice == 0) cout << "You choose Rock.\n";
	else if (playerChoice == 1) cout << "You choose Paper.\n";
	else if (playerChoice == 2) cout << "You choose Scissors.\n";

	//computer choice
	if (computerChoice == 0) cout << "Computer chooses Rock.\n";
	else if (computerChoice == 1) cout << "Computer chooses Paper.\n";
	else if (computerChoice == 2) cout << "Computer chooses Scissors.\n";

	if (playerChoice == computerChoice)
	{
		cout << "It's a tie!\n";
	}

	//all user wins possiblilties 
	else if ((playerChoice == 0 && computerChoice == 2) || //rock beats scissor
		(playerChoice == 1 && computerChoice == 0) || //paper beats rock
		(playerChoice == 2 && computerChoice == 1)) // scissors beats paper
	{
		cout << "You Win!\n";
	}
	else
	{
		cout << "You lose!\n";
	}

	return 0;
}