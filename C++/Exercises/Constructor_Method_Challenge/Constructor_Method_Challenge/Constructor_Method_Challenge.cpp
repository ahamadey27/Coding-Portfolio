

#include <iostream>
using namespace std;


class constructorClass        // The class
{
public:                     // Access specifier
    constructorClass()     // Constructor
    {
        cout << "Constructor Class Output";
    }
};

int main()
{
    constructorClass constructorObject; // Create an object of MyClass (THIS IS THE CONTRUCTOR)
        return 0; 
}

