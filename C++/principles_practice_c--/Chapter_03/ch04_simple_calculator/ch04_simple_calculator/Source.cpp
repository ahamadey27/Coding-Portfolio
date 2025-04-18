#include <iostream>


int main()
{
	double num1, num2;;
	
	char op;

	std::cout << "Enter first number: \n";
	std::cin >> num1;

	std::cout << "Enter + , - , * or / \n";
	std::cin >> op; 

	std::cout << "Enter second number : \n";
	std::cin >> num2; 

	double result; 

	switch (op)
	{
	case '+' :
		result = num1 + num2;
		break;
	case '-' : 
		result = num1 - num2;
		break;
	case '*':
		result = num1 * num2;
		break;
	case '/':
		if (num2 == 0)
		{
			std::cout << "Error Division by 0" << std::endl; 
			return 1; 
		}
		result = num1 / num2;
		break;
	default:
		std::cout << "Error! Invalid operator" << std::endl;
		return 1;
	}

	std::cout << "Result: " << result << "\n";
	return 0;
}