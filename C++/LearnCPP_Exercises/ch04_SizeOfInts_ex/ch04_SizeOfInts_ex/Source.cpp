#include "std_lib_facilities.h"
//Find fastest and least integer types

int main()
{
	cout << "least 8: " << sizeof(int_least8_t) * 8 << "bits\n";
	cout << "least 16: " << sizeof(int_least16_t) * 8 << "bits\n";
	cout << "least 32: " << sizeof(int_least32_t) * 8 << "bits\n";
	cout << '\n';
	cout << "fast 8: " << sizeof(int_fast8_t) * 8 << "bits\n";
	cout << "fast 16: " << sizeof(int_fast16_t) * 8 << "bits\n";
	cout << "fast 32: " << sizeof(int_fast32_t) * 8 << "bits\n";

	return 0;
}


