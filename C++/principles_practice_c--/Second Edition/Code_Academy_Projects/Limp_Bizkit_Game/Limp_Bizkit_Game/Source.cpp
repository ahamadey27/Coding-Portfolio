#include <iostream>
#include <string>
using namespace std;

int main()
{
    cout << "Sup, bro. Wanna play a game of Limp Bizkit? You 'in' or you 'out'?\n";
    string introChoice;
    cin >> introChoice;

    if (introChoice == "in")
    {
        cout << "Sick bro...let's get this mother started. I'll throw on some 311..one sec.\n";
        cout << "So what's your name, bro?\n";
        cout << "(hint: must be a bro name)\n";
        string broName;
        cin >> broName;

        if (broName == "Chad" || broName == "Brad" || broName == "Kyle" || broName == "Chet" || broName == "Trey" ||
            broName == "Chaz" || broName == "Brock" || broName == "Brett" || broName == "Bryce" || broName == "Bryant" ||
            broName == "Bryson")
        {
            cout << "Sick name, bro. Let's get this party started.\n";
            cout << "Wanna use a Wheat Thin, a Ritz, or a Saltine? Choose wisely, bro\n";
            string crackerChoice;
            cin >> crackerChoice;

            if (crackerChoice == "Wheat Thin" || crackerChoice == "Ritz" || crackerChoice == "Saltine")
            {
                cout << "You know the drill, " << broName << ". Last one to nut on the " << crackerChoice << " has to eat it.\n";
                cout << "Are you ready, bro? 'Yes' or 'No'\n";
                string readyChoice;
                cin >> readyChoice;

                if (readyChoice == "Yes")
                {
                    cout << "OK, bros. Here we go.\n";
                    cout << broName << " is cycling through very erotic thoughts so he can spludge on the " << crackerChoice << " before the other bros.\n";
                    cout << "The year is 1998...the year of the Limp Bizkit...choose the right babe to beat the other bros.\n";
                    cout << "1 for Pamela Anderson.\n2 for Carmen Electra\n3 for Jenny McCarthy\n4 for Britney Spears\n5 for Christina Aguilera\n6 for Jessica Simpson\n";

                    int babeChoice;
                    cin >> babeChoice;

                    if (babeChoice == 2 || babeChoice == 3 || babeChoice == 4 || babeChoice == 6)
                    {
                        cout << "You chose wisely, bro. You're the first to nut on the " << crackerChoice << ".\n";
                        cout << "You win, bro. You're the Limp Bizkit champion.\n";
                        return 0;
                    }
                    else
                    {
                        cout << "Sorry, bro. You chose the wrong babe. You're the last to nut on the " << crackerChoice << ".\n";
                        cout << "You lose, bro. You gotta eat the " << crackerChoice << ".\n";
                        return 0;
                    }
                }
                else
                {
                    cout << "Sorry, bro. You gotta be in it to win it.\n";
                    return 0;
                }
            }
            else
            {
                cout << "Sorry, bro...don't have that stocked in the mini fridge...I guess go out and grab some " << crackerChoice << ", bro.\n";
                return 0;
            }
        }
        else
        {
            cout << "Sorry, bro...getting bad vibes on your end\n";
            return 0;
        }
    }
    else
    {
        cout << "Whatever, bro. Peace.\n";
        return 0;
    }
}
