#include "Judge.h"
#include<cstring>

/*Ҫ���û�����𰸲������Ƚ�*/
int judge(num res)
{
	char ans[50];
	//cout << "������𰸣�";
	cin.getline(ans, 50, '\n');
	int formflag = Check(ans);		//�жϴ𰸸�ʽ�Ƿ���ȷ
	if (formflag)//����𰸸�ʽ��ȷ
	{
		//sign��ʾ�𰸷��ţ�ansnum[0]Ϊ���ӣ�ansnum[1]Ϊ��ĸ
		int ansnum[2] = { 0 , 1 };
		int sign = turn2num(ans, ansnum);
		if (ansnum[1] != 0)							//�жϷ�ĸ�Ƿ�Ϊ0
		{
			num yourres(ansnum[0], ansnum[1], sign);
			if (yourres == res)
			{
				cout << "Bingo~" << endl<<endl;
				return 1;
			}
			else
				cout << "Wrong��" << endl;
		}
		else
			cout << "Math Error" << endl;
		cout << "��ȷ��Ϊ��";
		res.print();
	}
	else
		cout << "Error���𰸸�ʽ����" << endl;
	cout << endl;
	return 0;
}

//�жϴ𰸸�ʽ
int Check(char * ans)
{
	int flag[50] = { 0 }, pos = 0;
	for (int i = 0; ans[i] == ' '; i++)		//ȥ��ǰ�ÿո�
		flag[i] = 1;
	while (ans[pos])						//ȥ����������ո�
	{
		if (ans[pos] == '/')
		{
			for (int i = pos - 1; ans[i] == ' '; i--)
				flag[i] = 1;
			for (int i = pos + 1; ans[i] == ' '; i++)
				flag[i] = 1;
		}
		pos++;
	}
	for (int i = pos - 1; i >= 0 && ans[i] == ' '; i--)		//ȥ�����ÿո�
		flag[i] = 1;
	char temp[50] = { 0 };
	int top = 0;
	for (int i = 0; ans[i]; i++)
	{
		if (flag[i] == 0)
			temp[top++] = ans[i];
	}
	strcpy(ans, temp);
	int formflag = 1, count_div = 0;
	//�жϴ𰸸�ʽ�������������ַ���2�������ϳ��Ż򸺺�λ�ò���ȷ���ʽ����
	for (int i = 0; ans[i] != 0; i++)
	{
		if (ans[i] >= '0'&&ans[i] <= '9')
			continue;
		else if (ans[i] == '/'&&count_div < 1)
		{
			count_div++;
			continue;
		}
		else if (ans[i] == '-' && (i == 0 || ans[i - 1] == '/' || ans[i - 1] == '-'))
			continue;
		else
		{
			formflag = 0;
			break;
		}
	}
	return formflag;
}

//�����ַ���תΪʮ����
int turn2num(char * ans, int *ansnum)
{
	int pos = 0, sign = 1;
	for (int i = 0; ans[i] != '\0'; i++)
	{
		if (ans[i] == '-')
			sign *= -1;
		if (ans[i] >= '0'&&ans[i] <= '9')
			ansnum[pos] = ansnum[pos] * 10 + ans[i] - '0';
		else if (ans[i] == '/')
		{
			pos++;
			ansnum[pos] = 0;
		}
	}
	return sign;
}