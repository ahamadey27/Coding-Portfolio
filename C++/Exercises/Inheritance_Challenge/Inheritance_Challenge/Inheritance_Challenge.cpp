

#include <iostream>
using namespace std;



class Compressors
{
public:
	string brand = "Empirical Labs";
	void CompType() 
	{
		cout << "digital compressor";
	}
};
   
class Outboard: public Compressors
{
public:
	string model = "Distressor";
};

int main()
{
	Outboard myOutboard;
	myOutboard.CompType();
	cout << myOutboard.brand + " " + myOutboard.model;
	return 0;
}


