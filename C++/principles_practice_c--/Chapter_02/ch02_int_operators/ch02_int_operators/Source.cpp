#include "std_lib_facilities.h"
/*user enters two ints and program determines smaller, larger, sum
difference, prodcut and ration*/
int main()
{
	cout << "Please enter two numbers: \n";
	int num1, num2;
	cin >> num1 >> num2;
	cout << "You entered " << num1 << " and " << num2 << ".\n";

	int MaxNum = max(num1, num2);
	int minNum = min(num1, num2); 
	if (num1 == num2)
	{
		cout << "Both" << num1 << " and " << num2 << " are the same.\n";
	}

	int sum = num1 + num2;
	int dif = num1 - num2;
	int prd = num1 * num2;
	int ratio = num1 / num2; 

	cout << "The sum of these numbers are " << sum << ". The differnce is " <<
		dif << ". The product is " << prd << " and the ratio is " << ratio << ".\n";

	



	return 0;
}


