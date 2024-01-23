// ConditioanlStatements.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std; 

//Use if to specify a block of code to be executed, if a specified condition is true
//Use else to specify a block of code to be executed, if the same condition is false
//Use else if to specify a new condition to test, if the first condition is false
//Use switch to specify many alternative blocks of code to be executed
int main()
{
	int moneyAmount = 0; 
	if (moneyAmount > 500)
	{
		cout << "You have enough money.";
	}
	
	else if (moneyAmount < 500)
	{
		cout << "Be Careful";
	}
	else
	{
		cout << "Get lost and GOOD DAY"; 
	}
		
	int newNumber = 10;
	string didYouWinBingo = (newNumber >= 18) ? "You won a bingo" : "You lost a bingo"; 
	cout << didYouWinBingo;  


	return 0; 
  
}

