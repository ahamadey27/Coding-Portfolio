//Write a function int accumulate(int x). This function should return the sum of all of the values of x 
// that have been passed to this function.

#include <iostream>

int accumulate(int x)
{
	static int sum{ 0 }; //initializes sum to 0 at start of program 
	sum += x;
	return sum;
	

	

}

int main()
{
	std::cout << accumulate(4) << '\n';
	std::cout << accumulate(2) << '\n';
	std::cout << accumulate(2) << '\n';
	std::cout << accumulate(1) << '\n';

	return 0;
}