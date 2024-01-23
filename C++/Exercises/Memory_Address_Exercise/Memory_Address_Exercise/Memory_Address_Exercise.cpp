

#include <iostream>
using namespace std; 

int main()
{
	string carModel = "BMW"; 
	string &manufacturer = carModel; //creating a reference using & operator 
	string* pointer = &carModel; 


	cout << carModel << '\n';
	cout << manufacturer << '\n'; 
	cout << &manufacturer << '\n'; //use the & on the output to get the hexadicemal memory address 
	cout << pointer; //also points to the memory address and same output as 
}

