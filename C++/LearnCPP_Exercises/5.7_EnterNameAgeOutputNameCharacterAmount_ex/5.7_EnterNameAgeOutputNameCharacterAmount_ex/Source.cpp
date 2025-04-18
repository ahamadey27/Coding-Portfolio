#include <iostream>
#include <string> //enables std::string and std::getline

/*Write a program that asks the user to enter their full name and their age.
As output, tell the user the sum of their age and the number of characters in their name 
(use the std::string::length() member function to get the length of the string). 
For simplicity, count any spaces in the name as a character.*/


int main()
{
	std::cout << "Please enter your full name.\n";
	std::string fullName{};
	std::getline(std::cin >> std::ws, fullName); //two arguments for this. cin and variable string name. std::ws removes white spaace
	
	std::cout << "Enter your age as well.\n";
	int age{};
	std::cin >> age; 

	// age is signed, and name.length() is unsigned -- we shouldn't mix these
   // We'll convert name.length() to a signed value

	int nameLength {static_cast<int>(fullName.length())}; // get number of chars in name 

	std::cout << "Your age plus name length is: " << age + nameLength << '\n';
	return 0;
}

