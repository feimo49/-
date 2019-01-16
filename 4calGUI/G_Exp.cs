using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4calGUI
{
    class G_Exp
    {
        public int []Exp=new int[50];
        public int p = 0;
        public string strsave;
        //mode=1 基础，mode=2 包含分数，mode=3，包含乘方。
        //随机生成式子长度
        int RandExpLen()
        {
            return cal4.rand.Next(2, 11);
        }

        //随机生成算符
        int RandSymbol(int mode)
        {
            int randnum=-1;
            if (mode == 1)
                randnum = cal4.rand.Next(0,4) + 101;
            else if (mode == 2)
                randnum = cal4.rand.Next(0, 4) + 101;
            else if (mode == 3)
                randnum = cal4.rand.Next(0, 5) + 101;
            else if (mode == 4)
                randnum = cal4.rand.Next(0, 5);
            return randnum;
        }

        //随机生成式子中数字个数
        int RandExpNum(int maxnum)
        {
            return cal4.rand.Next(0, maxnum);
        }

        //随机生成一个1~3的数字
        int GetEasy()
        {
            return cal4.rand.Next(0, 3) + 1;
        }

        //生成算式
        public int[] BuildExp(int mode)
        {
            bool HavePow = false;
            int expnum = RandExpLen();
            int lastbracket = 0;
            p = 0;
            for (int j = 1; j <= expnum; j++)
            {
                if (j == expnum)//最后一个数字的判断
                {
                    Exp[p++] = RandExpNum(10);
                    if (p>1&&Exp[p - 2] == 105)
                        Exp[p - 1] = GetEasy(); //返回一个1~3的数
                    if (p>1&&Exp[p - 2] == 104 && Exp[p - 1] == 0)//判断分母0
                        Exp[p - 1] = 1;
                    if (lastbracket != 0)//若有未匹配左括号，则最后一位强制添加右括号
                        Exp[p++] = 107;
                    break;
                }
                else
                {
                    Exp[p++] = RandExpNum(10);//生成随机数
                    if (p>1&&Exp[p - 2] == 105)
                        Exp[p - 1] = GetEasy();
                    if (p>1&&Exp[p - 2] == 104 && Exp[p - 1] == 0)//判断分母0
                        Exp[p - 1] = 1;
                    if (RandSymbol(4)==1 && lastbracket > 2)//右括号
                    {
                        Exp[p++] = 107;
                        lastbracket = 0;
                    }
                    Exp[p++] = RandSymbol(mode);//生成随机符号
                    {//检查乘方个数
                        if (Exp[p - 1] == 105 && HavePow)
                            Exp[p - 1] = RandSymbol(1);
                        else if (Exp[p - 1] == 105)
                            HavePow = true;
                    }
                    if (RandSymbol(4)==1 && j < expnum - 1 && lastbracket == 0 && Exp[p - 1] < 104)//左括号
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

        //打印当前生成的算式
        public void PrintExp()
        {
            char []CExp = new char[100];
            int k = 0;
            for (int i = 0; i < p; i++)
            {
                if (Exp[i] == 101)
                { 
                    CExp[k++] = '+';
                }
                else if (Exp[i] == 102)
                {
                    CExp[k++] = '-';
                }
                else if (Exp[i] == 103)
                {
                    CExp[k++] = '*';
                }

                else if (Exp[i] == 104)
                {
                    CExp[k++] = '/';
                }

                else if (Exp[i] == 105)
                { 
                        CExp[k++] = '^';
                }
                else if (Exp[i] == 106)
                {
                    CExp[k++] = '(';
                }
                else if (Exp[i] == 107)
                {
                    CExp[k++] = ')';
                }
                else
                {
                    CExp[k++] = (char)(Exp[i] + 48);
                }
            }
            CExp[k++] = '=';
            CExp[k++] = '\n';
            CExp[k] = '\0';
            strsave = new string(CExp);
        }

        public string C_Tostring()
        {
            string save = "";
            for(int i=0;i<p;i++)
            {
                if (Exp[i] == 101)
                {
                    save+= '+';
                }
                else if (Exp[i] == 102)
                {
                    save+= '-';
                }
                else if (Exp[i] == 103)
                {
                    save+= '*';
                }

                else if (Exp[i] == 104)
                {
                    save+= '/';
                }

                else if (Exp[i] == 105)
                {
                    save+= '^';
                }
                else if (Exp[i] == 106)
                {
                    save+= '(';
                }
                else if (Exp[i] == 107)
                {
                    save+= ')';
                }
                else
                {
                    save+= (char)(Exp[i] + 48);
                }
            }
            return save;
        }
    }
}
