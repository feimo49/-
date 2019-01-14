#pragma once

#include<math.h>
#include<iostream>
#include<fstream>
using namespace std;

class num {
private:
	int numerator;		//����
	int denominator;	//��ĸ
	int gcd;			//���Լ��
	int symbol;			//�����
	int flag;			//���û����־����ֹ�ظ�����
	void get_gcd(int x, int y)    //�����Լ��
	{
		if (y == 0)
			gcd = x;
		else
			get_gcd(y, x%y);
	}
	void reduction()	//����
	{
		if (numerator != 0)		//���Ӳ�Ϊ0
		{
			symbol = symbol * (numerator / abs(numerator))*(denominator / abs(denominator));
			numerator = abs(numerator);
			denominator = abs(denominator);
			get_gcd(numerator, denominator);
		}
		else                   //����Ϊ0
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
	friend num operator ^(num &a, num &b);	//��֤b�ķ�ĸΪ1
	friend int operator == (num &a, num &b);
};
