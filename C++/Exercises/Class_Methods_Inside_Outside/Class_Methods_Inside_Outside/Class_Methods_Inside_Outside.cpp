
#include <iostream>
using namespace std;


class InsideClass               //Class
{
public:                       //Access Specifier
    void insideClassMethod() // Method/function defined inside the class
    {
        cout << "Example of Inside Class Method";
    }
};
int main()
{
    InsideClass newObject;          // Create an object of MyClass
    newObject.insideClassMethod(); // Call the method
    return 0; 
    
}




class OutsideClass
{
public:
	void outsideClassMethod(); 
};

void OutsideClass::outsideClassMethod()     // Method/function definition outside the class
{
	cout << "Text from the outside class method"; 
}

int main()
{
	OutsideClass outsideObject;
	outsideObject.outsideClassMethod();
	return 0; 
}

