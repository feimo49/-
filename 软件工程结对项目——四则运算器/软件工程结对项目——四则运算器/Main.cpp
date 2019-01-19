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
		cout << "您希望使用哪种方式表示乘方？(输入1选择模式1，输入2选择模式2）mode-1：^/mode-2:**" << endl;
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
		printf("本轮题目正确率：%d/%d\n", ac, n);
	}
	if (strcmp(argv[1], "-i")) //输入格式不合理的情况
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
	if (flag == 1) //输入非数字的情况
		printf("Please input a NUMBER!\n");
	system("pause");
	return 0;
}