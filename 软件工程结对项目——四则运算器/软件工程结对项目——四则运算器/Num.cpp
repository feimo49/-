#include"Num.h"

num::num()
{
	numerator = 0;
	denominator = 1;
	symbol = 1;
	flag = 0;
}
num::num(int x)
{
	numerator = x;
	denominator = 1;
	symbol = 1;
	flag = 0;
}
num::num(int x, int y, int sign)
{
	numerator = x;
	denominator = y;
	symbol = sign;
	flag = 0;
}

void num::print()
{
	if (!flag)
		reduction();
	if (symbol < 0)
		cout << "-";
	cout << numerator / gcd;
	if (denominator / gcd != 1)
		cout << "/" << denominator / gcd;
	cout << endl;
}
void num::print(char * formula, ofstream & outtofile)
{
	if (!flag)
		reduction();
	outtofile << formula << " = ";
	if (symbol < 0)
		outtofile << "-";
	outtofile << numerator / gcd;
	if (denominator / gcd != 1)
		outtofile << "/" << denominator / gcd;
	outtofile << endl;
}

int operator == (num &a, num &b)
{
	if (!a.flag)
		a.reduction();
	if (!b.flag)
		b.reduction();
	int numerator1 = a.numerator / a.gcd;
	int numerator2 = b.numerator / b.gcd;
	int denominator1 = a.denominator / a.gcd;
	int denominator2 = b.denominator / b.gcd;
	if (a.symbol != b.symbol)
		return 0;
	else if (numerator1 != numerator2 || denominator1 != denominator2)
		return 0;
	else
		return 1;
}

num operator +(num &a, num &b)
{
	num c;
	c.numerator = a.numerator*b.denominator + a.denominator*b.numerator;
	c.denominator = a.denominator*b.denominator;
	return c;
}
num operator -(num &a, num &b)
{
	num c;
	c.numerator = a.numerator*b.denominator - a.denominator*b.numerator;
	c.denominator = a.denominator*b.denominator;
	return c;
}
num operator *(num &a, num &b)
{
	num c;
	c.numerator = a.numerator*b.numerator;
	c.denominator = a.denominator*b.denominator;
	return c;
}
num operator /(num &a, num &b)
{
	num c;
	if (b.numerator != 0)
		c.numerator = a.numerator*b.denominator;
	c.denominator = a.denominator*b.numerator;
	return c;
}
num operator ^(num &a, num &b)
{
	num c(1);
	for (int i = 0; i < b.numerator; i++)
		c = c * a;
	return c;
}
