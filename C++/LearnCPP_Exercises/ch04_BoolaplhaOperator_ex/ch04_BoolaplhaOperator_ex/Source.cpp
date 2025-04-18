#include <iostream>;
//using std boolalpha to change bool value from binary to 'true' or 'false'


bool isEqual(int x, int y)
{
	return x == y;
}

int main()
{
	std::cout << "Enter an integer: ";
	int x {};
	std::cin >> x; 

	std::cout << "Enter another integer: ";
	int y{};
	std::cin >> y; 

	std::cout << std::boolalpha; //prints bools as true or false. Can be applied sperately to std::cout as well

	std::cout << x << " and " << y << " are equal? ";
	std::cout << isEqual(x, y); //will return true or false

	std::cout << '\n';

	
	return 0;
}


