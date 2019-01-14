#include"Preprocessor.h"
//����ʽת��Ϊ�ɴ����ʮ���ƴ�
//+:101; -:102; *:103; /:104; ^:105; (:106; ):107
void Preprocess(char * formula, int * Expression)
{
	int flag=0,temp = -1, pos = 0;
	for (int i = 0; formula[i] != '\0'; i++)
	{
		if (formula[i] == ' ')		//�ո�����
			continue;
		if (formula[i] >= '0'&&formula[i] <= '9') //��������
		{
			if (temp == -1)			//����Ϊ0ʱ����֮ǰδ�������ֽ�������Ϊ-1
				temp = 0;
			temp *= 10;
			temp += formula[i] - '0';
		}
		else
		{
			if (temp != -1)			//�����ֺ�������һ�������ַ��ţ���֮ǰ�ۼӵ���������
			{
				Expression[pos++] = temp;
				temp = -1;
			}
			if (formula[i] == '+')
				Expression[pos++] = 101;
			else if (formula[i] == '-')
				Expression[pos++] = 102;
			else if (formula[i] == '*')			//�ƺź�����һ���ǿո��ַ�Ϊ�˺���Ϊ�˷�������Ϊ�˺�
			{
				int j;
				for (j = i + 1; formula[j] == ' '; j++);
				if (formula[j] == '*')
				{
					Expression[pos++] = 105;
					i = j;
				}
				else
					Expression[pos++] = 103;
			}
			else if (formula[i] == '/')
				Expression[pos++] = 104;
			else if (formula[i] == '^')
				Expression[pos++] = 105;
			else if (formula[i] == '(')
				Expression[pos++] = 106;
			else if (formula[i] == ')')
				Expression[pos++] = 107;
		}
	}
	if (temp != -1)
	{
		Expression[pos++] = temp;
		temp = -1;
	}
}