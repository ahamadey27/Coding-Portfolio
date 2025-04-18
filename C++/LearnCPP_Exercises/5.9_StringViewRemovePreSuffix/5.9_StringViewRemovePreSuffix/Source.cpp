//#include "std_lib_facilities.h"
#include <iostream>
#include <string_view>

int main()
{
	std::string_view str{ "Peach" };
	std::cout << str << '\n';

	//Remove 1 character from the left side of the view
	str.remove_prefix(1);
	std::cout << str << '\n';

	//Remove 2 character from the right side of the view
	str.remove_suffix(2);
	std::cout << str << '\n';

	str = "Peach234"; //reset value 
	std::cout << str << '\n';
	return 0;
}


