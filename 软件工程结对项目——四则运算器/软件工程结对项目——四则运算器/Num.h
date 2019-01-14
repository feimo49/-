#pragma once

#include<math.h>
#include<iostream>
#include<fstream>
using namespace std;

class num {
private:
	int numerator;		//分子
	int denominator;	//分母
	int gcd;			//最大公约数
	int symbol;			//运算符
	int flag;			//设置化简标志，防止重复化简
	void get_gcd(int x, int y)    //求最大公约数
	{
		if (y == 0)
			gcd = x;
		else
			get_gcd(y, x%y);
	}
	void reduction()	//化简
	{
		if (numerator != 0)		//分子不为0
		{
			symbol = symbol * (numerator / abs(numerator))*(denominator / abs(denominator));
			numerator = abs(numerator);
			denominator = abs(denominator);
			get_gcd(numerator, denominator);
		}
		else                   //分子为0
		{
			denominator = 1;
			gcd = 1;
			symbol = 1;
		}
		flag = 1;
	}
public:
	num();
	num(int x);
	num(int x, int y, int sign);
	void print();
	void print(char * formula, ofstream & outtofile);
	friend num operator +(num &a, num &b);
	friend num operator -(num &a, num &b);
	friend num operator *(num &a, num &b);
	friend num operator /(num &a, num &b);
	friend num operator ^(num &a, num &b);	//保证b的分母为1
	friend int operator == (num &a, num &b);
};
