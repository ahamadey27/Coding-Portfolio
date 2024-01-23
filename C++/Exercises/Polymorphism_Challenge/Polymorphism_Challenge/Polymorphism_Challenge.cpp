
#include <iostream>
using namespace std;


class Animal //Base Class
{
public:
	void animalSound()
	{
		cout << "Sound that an animal makes \n";
	}
};

class Pig : public Animal //Derived Class
{
public:
	void animalSound()
	{
		cout << "Pig says oink oink \n";

	}
};

class Dog : public Animal //Derived Class
{
public:
	void animalSound()
	{
		cout << "Dog goes bark bark";
	}
};

int main()
{
	Animal myAnimal;
	Pig myPig;
	Dog myDog;

	myAnimal.animalSound();
	myPig.animalSound();
	myDog.animalSound();
	return 0; 
}
