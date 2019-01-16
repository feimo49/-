using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4calGUI
{
    class Judge
    {
        /*要求用户输入答案并与结果比较*/
        public int judge(Num res,string ans)
        {
            int formflag = Check(ans);      //判断答案格式是否正确
            if (formflag == 1)//如果答案格式正确
            {
                //sign表示答案符号，ansnum[0]为分子，ansnum[1]为分母
                int[] ansnum = new int[] { 0, 1 };
                int sign = turn2num(ans, ansnum);
                if (ansnum[1] != 0)                         //判断分母是否为0
                {
                    Num yourres = new Num(ansnum[0], ansnum[1], sign);
                    if (yourres == res)
                    {
                        return 1;
                    }
                    else
                        return 0;
                }
                else
                    return 0;
            }
            else
                return 3;
        }

        //判断答案格式
        int Check(string ans)
        {
            int[] flag = new int[50];
            int pos = 0;
            for (int i = 0; i < 50; i++)
                flag[i] = 0;
            for (int i = 0; ans[i] == ' '; i++)     //去除前置空格
                flag[i] = 1;
            while (pos<ans.Length)                        //去除除号两侧空格
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
            for (int i = pos - 1; i >= 0 && ans[i] == ' '; i--)     //去除后置空格
                flag[i] = 1;
            string temp="";
            int top = 0;
            for (int i = 0; i<ans.Length; i++)
            {
                if (flag[i] == 0)
                    temp+= ans[i];
            }
            ans=temp;
            int formflag = 1, count_div = 0;
            //判断答案格式，若出现其余字符或2个及以上除号或负号位置不正确则格式错误
            for (int i = 0; i<ans.Length; i++)
            {
                if (ans[i] >= '0' && ans[i] <= '9')
                    continue;
                else if (ans[i] == '/' && count_div < 1)
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

        //将答案字符串转为十进制
        int turn2num(string ans, int[] ansnum)
        {
            int pos = 0, sign = 1;
            for (int i = 0; i<ans.Length; i++)
            {
                if (ans[i] == '-')
                    sign *= -1;
                if (ans[i] >= '0' && ans[i] <= '9')
                    ansnum[pos] = ansnum[pos] * 10 + ans[i] - '0';
                else if (ans[i] == '/')
                {
                    pos++;
                    ansnum[pos] = 0;
                }
            }
            return sign;
        }
    }
}
