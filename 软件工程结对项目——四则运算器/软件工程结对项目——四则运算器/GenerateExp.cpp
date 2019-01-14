#include"GenerateExp.h"
#include<ctime>
#include<random>
#include<cmath>
#include<cstdlib>
#include<functional>
#include<fstream>
using namespace std;

default_random_engine generator(time(NULL));
normal_distribution<double> lendis(5, 3);
normal_distribution<double> numdis(5, 2);
auto lendice = bind(lendis, generator);
auto numdice = bind(numdis, generator);

int Exp[50];
int p = 0;
//mode=1 ������mode=2 ����������mode=3�������˷���
//�������ʽ�ӳ���
int RandExpLen()
{
	int randnum = lround(lendice());
	if (randnum < 2)
		randnum = 2;
	else if (randnum > 10)
		randnum = 10;
	return randnum;
}

//����������
int RandSymbol(int mode)
{
	int randnum;
	if (mode == 1)
		randnum = rand() % 4 + 101;
	else if (mode == 2)
		randnum = rand() % 4 + 101;
	else if (mode == 3)
		randnum = rand() % 5 + 101;
	else if (mode == 4)
		randnum = rand() % 2;
	return randnum;
}

//�������ʽ�������ָ���
int RandExpNum(int maxnum)
{
	int randnum = lround(numdice());
	if (randnum < 0)
		randnum = 0;
	else if (randnum > maxnum)
		randnum = maxnum;
	return randnum;
}

//�������һ��1~3������
int GetEasy()
{
	return rand() % 3 + 1;
}

//������ʽ
int* BuildExp(int mode)
{
	memset(Exp, 0, sizeof(Exp));
	bool HavePow = false;
	int expnum = RandExpLen();
	int lastbracket = 0;
	p = 0;
	for (int j = 1; j <= expnum; j++)
	{
		if (j == expnum)//���һ�����ֵ��ж�
		{
			Exp[p++] = RandExpNum(10);
			if (Exp[p - 2] == 105)
				Exp[p - 1] = GetEasy(); //����һ��1~3����
			if (Exp[p - 2] == 104 && Exp[p - 1] == 0)//�жϷ�ĸ0
				Exp[p - 1] = 1;
			if (lastbracket != 0)//����δƥ�������ţ������һλǿ�����������
				Exp[p++] = 107;
			break;
		}
		else
		{
			Exp[p++] = RandExpNum(10);//���������
			if (Exp[p - 2] == 105)
				Exp[p - 1] = GetEasy();
			if (Exp[p - 2] == 104 && Exp[p - 1] == 0)//�жϷ�ĸ0
				Exp[p - 1] = 1;
			if (RandSymbol(4) && lastbracket > 2)//������
			{
				Exp[p++] = 107;
				lastbracket = 0;
			}
			Exp[p++] = RandSymbol(mode);//�����������
			{//���˷�����
				if (Exp[p - 1] == 105 && HavePow)
					Exp[p - 1] = RandSymbol(1);
				else if (Exp[p - 1] == 105)
					HavePow = true;
			}
			if (RandSymbol(4) && j < expnum - 1 && lastbracket == 0 && Exp[p - 1] < 104)//������
			{
				Exp[p++] = 106;
				lastbracket = 1;
			}
		}
		if (lastbracket != 0)
			lastbracket++;
	}
	return Exp;
}

//��ӡ��ǰ���ɵ���ʽ
char* PrintExp(int mode)
{
	char *CExp = new char[100];
	int k = 0;
	for (int i = 0; i < p; i++)
	{
		if (Exp[i] == 101)
		{
			printf(" + ");
			CExp[k++] = '+';
		}
		else if (Exp[i] == 102)
		{
			printf(" - ");
			CExp[k++] = '-';
		}
		else if (Exp[i] == 103)
		{
			printf(" * ");
			CExp[k++] = '*';
		}
			
		else if (Exp[i] == 104)
		{
			printf(" / ");
			CExp[k++] = '/';
		}
			
		else if (Exp[i] == 105)
		{
			if (mode == 1)
			{
				printf(" ^ ");
				CExp[k++] = '^';
			}
			else
			{
				printf(" ** ");
				CExp[k++] = '*';
				CExp[k++] = '*';
			}
				
		}
		else if (Exp[i] == 106)
		{
			printf("(");
			CExp[k++] = '(';
		}
		else if (Exp[i] == 107)
		{
			printf(")");
			CExp[k++] = ')';
		}
		else
		{
			printf("%d", Exp[i]);
			CExp[k++] = Exp[i]+'0';
		}	
	}
	CExp[k++] = '\n';
	CExp[k++] = '\n';
	CExp[k] = '\0';
	printf("= ");
	return CExp;
}

