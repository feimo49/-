#include"Preprocessor.h"
//将算式转化为可处理的十进制串
//+:101; -:102; *:103; /:104; ^:105; (:106; ):107
void Preprocess(char * formula, int * Expression)
{
	int flag=0,temp = -1, pos = 0;
	for (int i = 0; formula[i] != '\0'; i++)
	{
		if (formula[i] == ' ')		//空格跳过
			continue;
		if (formula[i] >= '0'&&formula[i] <= '9') //遇到数字
		{
			if (temp == -1)			//数字为0时，若之前未碰到数字将计数置为-1
				temp = 0;
			temp *= 10;
			temp += formula[i] - '0';
		}
		else
		{
			if (temp != -1)			//在数字后遇到第一个非数字符号，将之前累加的数字置入
			{
				Expression[pos++] = temp;
				temp = -1;
			}
			if (formula[i] == '+')
				Expression[pos++] = 101;
			else if (formula[i] == '-')
				Expression[pos++] = 102;
			else if (formula[i] == '*')			//称号后若第一个非空格字符为乘号则为乘方，否则为乘号
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