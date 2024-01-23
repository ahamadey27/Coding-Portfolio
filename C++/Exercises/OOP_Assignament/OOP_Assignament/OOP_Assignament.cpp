

#include <iostream>
using namespace std;

class Dog
{
public:
    string Breed; //properties (state and structure) 
    string Color; //
    int Height;
    int Weight; 

    void Sit() //methods (behaviors)
    {
        cout << Breed << " sits.\n"; 
    }

    void Shake() //methods
    {
        cout << Breed << " shakes.\n"; 
    }

    void LayDown() //methods 
    {
        cout << Breed << " layes down.";
    }
};

int main()
{
    Dog myDog;

    myDog.Breed = "Hound";
    myDog.Color = "Brown"; 
    myDog.Height = 24; 
    myDog.Weight = 75; 

    cout << "My Dog is a " << myDog.Color << " " << myDog.Breed << " that weighs " << myDog.Weight << " pounds and is " << myDog.Height << " inches high with the following skills: \n"; 

    myDog.Sit();
    myDog.Shake();
    myDog.LayDown();

    return 0; 
    
}

