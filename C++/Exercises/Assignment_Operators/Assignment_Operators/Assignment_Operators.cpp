

#include <iostream>
using namespace std; 

int main()
{
    int x = 10;
    int y = 30; 

    cout << (x = 20); cout << "\n";
    cout << (x += 3); cout << "\n";
    cout << (x &= 3); cout << "\n";
    cout << (x <<= 3); cout << "\n";

    cout << "\nLogical Operators\n"; 
    cout << (x > 20 && y < 15); cout << "\n";
    cout << (x < 7 || y > 34); cout << "\n";
    cout << !(x < 10 && y > 20); cout << "\n";


    return 0;

}