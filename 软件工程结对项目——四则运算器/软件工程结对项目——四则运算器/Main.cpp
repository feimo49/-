#include<iostream>
#include<fstream>
#include<ctime>
#include<stdlib.h>
#include"Num.h"
#include"Solver.h"
#include"Judge.h"
#include"GenerateExp.h"

using namespace std;

int main(int argc, char * argv[])
{
	if (!strcmp(argv[1], "-i"))
	{
		srand((unsigned)time(NULL));
		int n = atoi(argv[2]);
		cout << "��ϣ��ʹ�����ַ�ʽ��ʾ�˷�����m1��^/m2:**��" << endl;
		int m;
		cin >>m;
		getchar();
		ofstream OutputFile("ques.txt");
		int ac = 0;
		for (int i = 0; i < n; i++)
		{
			char *t;
			num useranswer;
			int * save = BuildExp(3);
			t = PrintExp(m);
			OutputFile << t;
			if(judge(get_ans(save)))
				ac++;
		}
		printf("������Ŀ��ȷ�ʣ�%d/%d\n", ac, n);
		system("pause");
	}
	return 0;
}