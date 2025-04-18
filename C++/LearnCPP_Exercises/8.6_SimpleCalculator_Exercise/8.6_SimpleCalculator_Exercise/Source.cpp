//Simple calculator 
#include <iostream>

int calculator(int int1, int int2, char op)
{
	switch (op)
	{
	case '+':
		return int1 + int2;
	case '-':
		return int1 - int2;
	case '/':
		return int1 / int2;
	case '*':
		return int1 * int2;
	default:
		std::cout << "Cannot make this operation.\n";
		return 0;
	}
}

int main()
{
	std::cout << "Please enter an integer.\n";
	int int1{};
	std::cin >> int1;

	std::cout << "Please enter another ineger.\n";
	int int2{};
	std::cin >> int2; 

	std::cout << "Please enter if +, -, / or *: ";
	char op{};
	std::cin >> op;

	int result{ calculator(int1, int2, op) };
	 
	std::cout << "The result is: " << int1 << ' ' << op << ' ' << int2 << " is " << result << '\n';

	return 0;
}