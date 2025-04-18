#include "std_lib_facilities.h"
/*User inputs three numbers and program outputs them in numeric order*/
int main()
{
	int n;
	cout << "Please enter amount of elemnts.\n";
	cin >> n;

	vector<int>numbers(n);
	
	cout << "Enter the numbers.\n";

	for (int i = 0; i < n; ++i)
	{
		cin >> numbers[i];
	}

	sort(numbers.begin(), numbers.end());

	cout << "Here are the numbers in ascedning order: \n";

	for (int num : numbers)
	{
		cout << num << " ";
	}
	cout << endl;


	return 0;
}


