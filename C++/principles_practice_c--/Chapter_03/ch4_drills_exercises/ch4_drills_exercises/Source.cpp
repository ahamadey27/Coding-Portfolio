#include <iostream>

int main()
{
	std::cout << "please tyoe one number\n";
	double int1;
	std::cin >> int1;
	std::cout << "please type in another number\n";
	double int2;
	std::cin >> int2;
	//while (std::cin >> int1 >> int2)
		if (int1 > int2)
		{
			std::cout << "The smaller value is: " << int2 << "\n";
			std::cout << "The larger value is: " << int1 << "\n";
			if (std::abs(int1 - int2) <= 0.1)
			{
			std::cout << "The numbers are almost equal" << "\n";
			}
		}
		else if (int2 > int1)
		{
			std::cout << "The smaller value is: " << int1 << "\n";
			std::cout << "The larger value is: " << int2 << "\n";
			if (std::abs(int1 - int2) <= 0.1)
			{
				std::cout << "The numbers are almost equal" << "\n";
			}
		}

		else if (int1 == int2)
		{
			std::cout << int1 << " and " << int2 << " are equal\n";
		}
		return 0;

	
}