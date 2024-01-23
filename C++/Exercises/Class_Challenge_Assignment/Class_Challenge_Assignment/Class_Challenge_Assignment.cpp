
#include <iostream>
#include <cmath>
using namespace std;


class Shape
{
public:
	string color; 
};

class Rectangle : public Shape
{
public:
	double width;
	double height;

	double getArea()
	{
		return width * height;
	}
};

class Triangle : public Shape
{
public: 
	int base;
	int height;

	double getArea()
	{
		return 0.5 * base * height;
	}
};

class Circle : public Shape
{
public:
	int radius; 

	double getArea()
	{
		return 3.14 * radius;
	}
};
int main()
{
	Rectangle rect;
	Triangle tri;
	Circle cir; 

	rect.color = "red";
	rect.width = 10;
	rect.height = 15;

	tri.color = "blue";
	tri.base = 4;
	tri.height = 5;
	
	cir.color = "yellow";
	cir.radius = 3;

	cout << "Area of Rectangle: " << rect.getArea() << "...which is the color " << rect.color << endl;
	cout << "Area of Triangle: " << tri.getArea() << "...which is the color " << tri.color << endl;
	cout << "Area of cCircle: " << cir.getArea() << "...which is the color " << cir.color << endl;
}

