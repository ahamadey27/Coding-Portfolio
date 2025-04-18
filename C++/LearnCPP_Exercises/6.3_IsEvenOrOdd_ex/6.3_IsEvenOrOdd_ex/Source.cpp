#include <iostream>

//Write a program that asks the user to input an integer, 
//and tells the user whether the number is even or odd. Write a constexpr function called isEven()
//that returns true if an integer passed to it is even, and false otherwise.
//Use the remainder operator to test whether the integer parameter is even. Make sure isEven()
// works with both positive and negative numbers.


constexpr bool isEven(int x)
{
	return (x % 2 == 0); 
}
int main()
{
	std::cout << "Please enter an integer.\n";
	int x{};
	std::cin >> x; 

	if (isEven(x))
	{
		std::cout << x << " is an even number.\n";
	}
	else
	{
		std::cout << x << " is an odd number.\n";
	}
	
	return 0;
}