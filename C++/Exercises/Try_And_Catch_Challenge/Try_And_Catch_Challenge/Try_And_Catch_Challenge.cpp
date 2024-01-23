
#include <iostream>
using namespace std;

int main()
{
    try
    {
        int age = 15;
        if (age >= 18)
        {
            cout << "Enter da club";
        }
        else
        {
            throw "To young to enter da club"; 
        }
    }

    catch (...)
    {
        cout << "Access Denied!\n";
    }

}

