#include <iostream>
#include <string_view>
#include <string>

//Write a program that asks for the name and age of two people, then prints which person is older.

std::string getName(int num)
{
	std::cout << "Please enter your name of a person" << num <<": \n";
	std::string name{};
	std::getline(std::cin >> std::ws, name); //read a full line of text into name with no white space

	return name;
}

int getAge(std::string_view sv)
{
	std::cout << "Please enter age of a person" << sv << ": \n";
	int age{};
	std::cin >> age; 

	return age;
}

void printOlder(std::string_view name1, int age1, std::string_view name2, int age2)
{
	if (age1 > age2)
	{
	std::cout << name1 << "age" << age1 << " is older than " << name2 << '.\n';
	}
	
	else
	{
	std::cout << name2 << "age" << age2 << " is older than " << name1 << '.\n';
	}
}


int main()
{

	const std::string name1{ getName(1) };
	const int age1{ getAge(name1) };

	const std::string name2{ getName(2) };
	const int age2{ getAge(name2) };

	printOlder(name1, age1, name2, age2);
	



	return 0;
}