#include <iostream>
#include <utility> //for swapping variabale values

//program should display:

/*Enter an integer : 4
Enter a larger integer : 2
Swapping the values
The smaller value is 2
The larger value is 4*/

int main()
{
	std::cout << "Enter an integer: \n";
	int small{}; 
	std::cin >> small;	

	std::cout << "Enter a larger integer: \n";
	int large{};
	std::cin >> large; 

	//if user enters wrong order
	if (small > large)
	{
		std::cout << "Swapping values.\n";
		std::swap(small, large);

		//swap funtion same as:
		/*int temp{large};
		* large = small;
		* small = temp;
		*/
	}

	std::cout << "The smaller value is: " << small << '\n';
	std::cout << "The larger value is: " << large << '\n';
	return 0;
}