#include "std_lib_facilities.h"

double expression()
{
	double left = term();
	Token t = ts.get();
	while (true)
	{
		switch (t.kind)
		{
		case '+':
			left += term();
			t = ts.get();
			break;
		case '-':
			left -= term();
			t = ts.get();
			break;
		default: 
			ts.pushback(t);
			return left; 
		}
	}
}

double term()
{
	double left = primary();
	Token t = ts.get();
	while(true)
	{
		switch (t.kind)
		{
		case '*':
			left *= primary();
			t = ts.get();
			break;
		case '/':
			double d = primary();
			if (d == 0)
			{
				error("Divided by 0");
			}
			left /= d;
			t = ts.get();
			break;
		default:
			ts.pushback(t);
			return left; 
		}
	}
}

int main()
{
	cout << "Please enter expression using + , -, * or /.\n";
	cout << "Add an 'x' to end the expression.\n";

	int lval;
	int rval;

	cin >> lval; 
	if (!cin)
	{
		error("No firsthand operator"); 
	}

	for (char op; cin >> op;)
	{
		if (op != 'x')
		{
			cin >> rval;
		}
		if (!cin)
		{
			error("No secondhand operator");
		}

		switch(op)
		{
		case '+':
			lval += rval;
			break;

		case '-':
			lval -= rval;
			break;

		case '*':
			lval *= rval;
			break;

		case '/':
			lval /= rval;
			break;
		default:
			cout << "Result: " << lval << "\n";
		}	

	}
	error("Bad expression");
}


