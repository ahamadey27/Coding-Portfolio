

#include <iostream>
using namespace std;


class AccessModifiers
{
public:
    int xPublic;

private: 
    int xPrivate;
};
int main()
{
    AccessModifiers AccessObject;
    AccessObject.xPublic = 100;
    AccessObject.xPrivate= 200;

    
}

