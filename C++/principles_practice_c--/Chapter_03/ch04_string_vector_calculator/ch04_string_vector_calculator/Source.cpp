#include <iostream>
#include <vector>
#include <string>
#include <cctype>
using namespace std;

int getNumberFromInput(const string& input, const vector<string>& numbers)
{
	for (int i = 0; i < numbers.size(); i++)
	{
		if (input == numbers[i])
		{
			return i;
		}
	}

	if (input.size() == 1 && isdigit(input[0]))
	{
		return input[0] - '0';  // Convert character to integer
	}

	return -1;
}


int main()
{

	vector<string> numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven",
								"eight", "nine" };

	string input1, input2;
	char op;
	int num1 = -1, num2 = -1;


	cout << "please spell or enter an between 0 and 9.\n";
	cin >> input1;

	num1 = getNumberFromInput(input1, numbers);
	if (num1 == -1)
	{
		cout << "Invalid Input.\n";
		return 1;
	}
	

	std::cout << "Enter + , - , * or / \n";
	std::cin >> op;

	cout << "please spell or enter an between 0 and 9.\n";
	cin >> input2;

	num2 = getNumberFromInput(input2, numbers);
	if (num2 == -1)
	{
		cout << "Invalid Input.\n";
		return 1;
	}

	double result = 0;

	switch (op)
	{
	case '+':
		result = num1 + num2;
		break;
	case '-':
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
		result = static_cast<double>(num1) / num2;
		break;
	default:
		std::cout << "Error! Invalid operator" << std::endl;
		return 1;
	}

	cout << "Result: " << result << "\n";

	return 0;

}