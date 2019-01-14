#include"Solver.h"
#include<stack>
using namespace std;
extern int p;
//������Ϳɴ���ʮ������֮���ת��
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

//����������ӳ�䵽һ��ʮ��������0-100Ϊ������
//����101-104�ֱ����+��-��*��/��105Ϊ�˷���106Ϊ������,107Ϊ������
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
		else if (operation[i] == 105 || operation[i] == 106)	//��������˷��ض���ջ
			operators.push(operation[i]);
		else if (operation[i] == 103 || operation[i] == 104)	//�˳��ᵯ���˷���˳�
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
		else if (operation[i] == 101 || operation[i] == 102)		//�Ӽ����ܵ����˳���˷�
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
		else if (operation[i] == 107)				//�����Ż�һֱ����ֱ��������
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