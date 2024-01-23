// StringFunctionChallenge.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
using namespace std;

int main()
{
    string longString = "FIJIFJDKsdfj!FK";
    string longChanged = "AIFGHJDF"; 
    cout << "The length of longString is: " << longString.length(); 
    cout << " and the the third character is " << longString[2] <<"\n";
    cout << "We're going to change the 5th character in longChanged to a 5";
    longChanged[4] = '5'; 
    cout << longChanged; 
    
}

