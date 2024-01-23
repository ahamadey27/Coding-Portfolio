
#include <iostream>
using namespace std;

class carsAvailable             // The class
{
public:                   // Access specifier
    int modelNumber;     // Attribute (int variable)
    string modelName; // Attribute (string variable)
    int modelYear;
};

int main()
{
    carsAvailable carObj1;
    carObj1.modelNumber = 1325;
    carObj1.modelName = "BMW";
    carObj1.modelYear = 2020; 

    carsAvailable carObj2;
    carObj2.modelNumber = 14564;
    carObj2.modelName = "Aston Martin";
    carObj2.modelYear = 2021;

    carsAvailable carObj3;
    carObj3.modelNumber = 1325;
    carObj3.modelName = "Porsche";
    carObj3.modelYear = 2022;

    cout << "Car 1\n";
    cout << "Model Number: " << carObj1.modelNumber << '\n' << "Model Name: " << carObj1.modelName << '\n' << "Model Year: " << carObj1.modelYear << '\n';
    cout << "Car 2\n";
    cout << "Model Number: " << carObj2.modelNumber << '\n' << "Model Name: " << carObj2.modelName << '\n' << "Model Year: " << carObj2.modelYear << '\n';
    cout << "Car 3\n"; 
    cout << "Model Number: " << carObj3.modelNumber << '\n' << "Model Name: " << carObj3.modelName << '\n' << "Model Year: " << carObj3.modelYear << '\n';

    return 0; 
}

