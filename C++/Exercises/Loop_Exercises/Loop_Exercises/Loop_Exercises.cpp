

#include <iostream>
using namespace std;

int main()
{
    int i = 0;
    while (i < 5) //while loop
    {
        cout << i << '\n';
        i++;
    }

    for (int i = 0; i < 20; i++) //for looop 
    {
        cout << i << '\n';
    }
       

    int myNumber[5] = { 10, 20, 30, 40, 50 }; //for each loop
    for (int i : myNumber)
    {
        cout << i << '\n'; 
    }
    return 0; 

    for (int i = 0; i < 10; i++) //for loop with break...will stop at 5
    {
        if (i == 6)
        {
            break;
        }

        cout << i << '\n';
    }

    int i = 0; //continue example...this will break and exlude 4 and continue to 10
    while (i < 10)
    {
        if (i == 4)
        {
            i++;
            continue; 
        }
        cout << i << '\n';
        i++; 
    }


}

