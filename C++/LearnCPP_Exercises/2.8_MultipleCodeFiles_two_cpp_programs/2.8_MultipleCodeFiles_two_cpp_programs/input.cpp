#include <iostream>

int getInteger()
{
	std::cout << "Enter an integer: \n";
	int x{};
	std::cin >> x; 
	return x;
}