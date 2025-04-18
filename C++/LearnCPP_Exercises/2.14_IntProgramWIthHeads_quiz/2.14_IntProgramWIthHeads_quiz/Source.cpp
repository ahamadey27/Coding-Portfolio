#include "std_lib_facilities.h"
#include "io.h"
//Head and two .cpp files that reads and two seperate ints from user, adds them together and ouputs the answer

int main()

{
	int x{ readNumber() };
	int y{ readNumber() };

	writeAnswer(x + y);

	return 0;
}


