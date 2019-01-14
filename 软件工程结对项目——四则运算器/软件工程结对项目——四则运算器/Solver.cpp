#include"Solver.h"
#include<stack>
using namespace std;
extern int p;
//运算符和可处理十进制数之间的转换
num cal(num n1, num n2, int opera)
{
	if (opera == 101)
		return n1 + n2;
	else if (opera == 102)
		return n1 - n2;
	else if (opera == 103)
		return n1 * n2;
	else if (opera == 104)
		return n1 / n2;
	else if (opera == 105)
		return n1 ^ n2;
}

//将四则运算映射到一串十进制数，0-100为运算数
//其中101-104分别代表+，-，*，/，105为乘方，106为左括号,107为右括号
num get_ans(int * operation)
{
	stack <int> operators;
	stack <num> operand;
	for (int i = 0; i < p; i++)
	{
		if (operation[i] >= 0 && operation[i] <= 100)
		{
			num temp(operation[i]);
			operand.push(temp);
		}
		else if (operation[i] == 105 || operation[i] == 106)	//左括号与乘方必定入栈
			operators.push(operation[i]);
		else if (operation[i] == 103 || operation[i] == 104)	//乘除会弹出乘方与乘除
		{
			while (!operators.empty() && (operators.top() == 103 || operators.top() == 104 || operators.top() == 105))
			{
				int opera = operators.top();
				operators.pop();
				num n1 = operand.top();
				operand.pop();
				num n2 = operand.top();
				operand.pop();
				operand.push(cal(n2, n1, opera));
			}
			operators.push(operation[i]);
		}
		else if (operation[i] == 101 || operation[i] == 102)		//加减可能弹出乘除与乘方
		{
			while (!operators.empty() && (operators.top() != 106 && operators.top() != 107))
			{
				int opera = operators.top();
				operators.pop();
				num n1 = operand.top();
				operand.pop();
				num n2 = operand.top();
				operand.pop();
				operand.push(cal(n2, n1, opera));
			}
			operators.push(operation[i]);
		}
		else if (operation[i] == 107)				//右括号会一直弹出直至左括号
		{
			while (operators.top() != 106)
			{
				int opera = operators.top();
				operators.pop();
				num n1 = operand.top();
				operand.pop();
				num n2 = operand.top();
				operand.pop();
				operand.push(cal(n2, n1, opera));
			}
			operators.pop();
		}
	}
	while (!operators.empty())
	{
		int opera = operators.top();
		operators.pop();
		num n1 = operand.top();
		operand.pop();
		num n2 = operand.top();
		operand.pop();
		operand.push(cal(n2, n1, opera));
	}
	return operand.top();
}