#include <iostream>
//User enters number 0-9 and prgream will tell user "number is prime" "number is not prime" 

bool isPrime(int x)
{
	if (x == 2 || x == 3 || x == 5 || x == 7)
	{
		return true;
	}
	else
		return false;
}
int main()
{
	std::cout << "Enter a number between 0 and 9.\n";
	int x{};
	std::cin >> x;

	if (isPrime(x))
	{
		std::cout << "The number " << x << " you entered is a prime number.\n";
	}
	else
		std::cout << "The number " << x << " you entered is not a prime number.\n";

	return 0;
}


