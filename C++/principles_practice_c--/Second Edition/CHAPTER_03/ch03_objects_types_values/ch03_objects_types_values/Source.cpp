#include "std_lib_facilities.h"

int main()
{

	cout << " Please enter your first name (followed by 'Enter'):\n";
	string first_name;
	cin >> first_name;
	cout << "Hello, " << first_name << "!\n"; 


	/*variable examples
	* int number_steps = 39
	* double flying_time = 3.5
	* char decimal_point = '.'
	* string name = "Annemarie"
	* bool is_true = true
	*/

	/*
	//Input name and age in months
	cout << "Please enter name and age.\n";
	string first_name;
	int age;

	cin >> first_name;
	cin >> age;
	
	double age_in_months = age * 12;
	
	cout << "Hello, " << first_name << " you are " << age_in_months << " months old!\n";

	return 0;*/

	/*
	//Operator exercise 
	cout << "Please enter a floating-point value: ";
	double n;
	cin >> n;
	cout << "n == " << n
		<< "\nn+1 == " << n + 1
		<< "\nthree times n == " << 3 * n
		<< "\ntwice n == " << n + n
		<< "\nn squared == " << n * n
		<< "\nhalf of n == " << n / 2
		<< "\nsquare root of n == " << sqrt(n)
		<< '\n'; // another name for newline ("end of line") in output
	*/


	/*
	//read first and second name
	cout << "Please enter your first and second names\n";
	string first;
	string last;
	cin >> first >> last; 
	string full_name = first + ' ' +  last;
	cout << "Hello, " << full_name << " it's good to meet you!\n";
	*/

	/*
	//Find repeated words
	int number_of_words = 0;
	string previous = " "; //Not a word
	string current;
	while (cin >> current) 
	{
		++number_of_words; //increase word count
		if (previous == current)
		{
			cout << "Word number " << number_of_words << " repeated: " << current << '\n';
			previous = current;
		}

	}*/



} 
