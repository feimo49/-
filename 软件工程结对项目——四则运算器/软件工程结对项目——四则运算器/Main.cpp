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
	if (argc < 3)
	{
		printf("Please input TWO parameters!\n");
		system("pause");
		return 0;
	}
	if (!strcmp(argv[1], "-i"))
	{
		srand((unsigned)time(NULL));
		int n = atoi(argv[2]);
		cout << "��ϣ��ʹ�����ַ�ʽ��ʾ�˷���(����1ѡ��ģʽ1������2ѡ��ģʽ2��mode-1��^/mode-2:**" << endl;
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
	}
	if (strcmp(argv[1], "-i")) //�����ʽ����������
	{
		printf("Please input in the correct form!\n");
		system("pause");
		return 0;
	}
	int flag = 0;
	for (int i = 0; i <= strlen(argv[2]);i++)
	{
		if (argv[2][i]<'0' || argv[2][i]>'9')
			flag = 1;
	}
	if (flag == 1) //��������ֵ����
		printf("Please input a NUMBER!\n");
	system("pause");
	return 0;
}