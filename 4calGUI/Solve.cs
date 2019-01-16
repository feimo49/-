using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4calGUI
{
    class Solve
    {
        Num Cal(Num n1, Num n2, int opera)
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
            else
            {
                Num error = new Num(-1);
                return error;
            }
        }

        public Num get_ans(int[] operation, int length)
        {
            Stack<int> operators = new Stack<int>();
            Stack<Num> operand = new Stack<Num>();
            for (int i = 0; i < length; i++)
            {
                if (operation[i] >= 0 && operation[i] <= 100)
                {
                    Num temp = new Num(operation[i]);
                    operand.Push(temp);
                }
                else if (operation[i] == 105 || operation[i] == 106)    //左括号与乘方必定入栈
                    operators.Push(operation[i]);
                else if (operation[i] == 103 || operation[i] == 104)    //乘除会弹出乘方与乘除
                {
                    while (operators.Count!=0 && (operators.Peek() == 103 || operators.Peek() == 104 || operators.Peek() == 105))
                    {
                        int opera = operators.Pop();
                        Num n1 = operand.Pop();
                        Num n2 = operand.Pop();
                        operand.Push(Cal(n2, n1, opera));
                    }
                    operators.Push(operation[i]);
                }
                else if (operation[i] == 101 || operation[i] == 102)        //加减可能弹出乘除与乘方
                {
                    while (operators.Count!=0 && (operators.Peek() != 106 && operators.Peek() != 107))
                    {
                        int opera = operators.Pop();
                        Num n1 = operand.Pop();
                        Num n2 = operand.Pop();
                        operand.Push(Cal(n2, n1, opera));
                    }
                    operators.Push(operation[i]);
                }
                else if (operation[i] == 107)               //右括号会一直弹出直至左括号
                {
                    while (operators.Peek() != 106)
                    {
                        int opera = operators.Pop();
                        Num n1 = operand.Pop();
                        Num n2 = operand.Pop();
                        operand.Push(Cal(n2, n1, opera));
                    }
                    operators.Pop();
                }
            }
            while (operators.Count!=0)
            {
                int opera = operators.Pop();
                Num n1 = operand.Pop();
                Num n2 = operand.Pop();
                operand.Push(Cal(n2, n1, opera));
            }
            return operand.Pop();
        }
    }
}
