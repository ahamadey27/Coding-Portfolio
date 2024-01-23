
#include <iostream>
using namespace std; 

int main()
{
	string firstNames[5] = { "Bill", "Sam", "Ryan", "Tom", "Sean" };
	cout << firstNames[4]; //look up 5th element of an array 

	
	string firstNames[5] = { "Bill", "Sam", "Ryan", "Tom", "Sean" };
	for (int i = 0; i < 5; i++)
	{
		cout << i << " = " << firstNames[i] << '\n'; //outputs each elemnt of array with its index 
	}
}

