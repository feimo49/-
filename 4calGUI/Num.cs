using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4calGUI
{
    internal class Num
    {
        private int numerator;      //分子
        private int denominator;    //分母
        private int gcd;            //最大公约数
        private int symbol;         //运算符
        private int flag;           //设置化简标志，防止重复化简
        private void G_gcd(int x, int y)    //求最大公约数
        {
            if (y == 0)
                gcd = x;
            else
                G_gcd(y, x % y);
        }
        private void reduction()    //化简
        {
            if (numerator != 0)     //分子不为0
            {
                symbol = symbol * (numerator / System.Math.Abs(numerator)) * (denominator / System.Math.Abs(denominator));
                numerator = System.Math.Abs(numerator);
                denominator = System.Math.Abs(denominator);
                G_gcd(numerator, denominator);
            }
            else                   //分子为0
            {
                denominator = 1;
                gcd = 1;
                symbol = 1;
            }
            flag = 1;
        }

        public Num()
        {
            numerator = 0;
            denominator = 1;
            symbol = 1;
            flag = 0;
        }
        public Num(int x)
        {
            numerator = x;
            denominator = 1;
            symbol = 1;
            flag = 0;
        }
        public Num(int x, int y, int sign)
        {
            numerator = x;
            denominator = y;
            symbol = sign;
            flag = 0;
        }
        public void print()
        {
            if (flag==0)
                reduction();
            if (symbol < 0)
                Console.Write("-");
            Console.Write("{0}",numerator / gcd);
            if (denominator / gcd != 1)
                Console.Write("{0}", denominator / gcd);
            Console.Write("\n");
        }
        public void print(String formula, FileStream fileStream)
        {
            if (flag==0)
                reduction();
            byte[] Byte0 = System.Text.Encoding.UTF8.GetBytes(formula + "=");
            fileStream.Write(Byte0, 0, Byte0.Length);
            if(symbol<0)
            {
                byte[] Byte1 = System.Text.Encoding.UTF8.GetBytes("-");
                fileStream.Write(Byte1, 0, Byte1.Length);
            }
            byte[] Byte2 = System.Text.Encoding.UTF8.GetBytes((numerator/gcd).ToString());
            fileStream.Write(Byte2, 0, Byte2.Length);
            if(denominator/gcd!=1)
            {
                byte[] Byte3 = System.Text.Encoding.UTF8.GetBytes("/"+ (denominator / gcd).ToString());
                fileStream.Write(Byte3, 0, Byte3.Length);
            }
            byte[] Byte4 = System.Text.Encoding.UTF8.GetBytes("\r\n");
            fileStream.Write(Byte4, 0, Byte4.Length);
        }

        public static Num operator +(Num a, Num b)
        {
            Num c = new Num();
            c.numerator = a.numerator * b.denominator + a.denominator * b.numerator;
            c.denominator = a.denominator * b.denominator;
            return c;
        }
        public static Num operator -(Num a, Num b)
        {
            Num c = new Num();
            c.numerator = a.numerator * b.denominator - a.denominator * b.numerator;
            c.denominator = a.denominator * b.denominator;
            return c;
        }
        public static Num operator *(Num a, Num b)
        {
            Num c = new Num();
            c.numerator = a.numerator * b.numerator;
            c.denominator = a.denominator * b.denominator;
            return c;
        }

        public static Num operator /(Num a, Num b)
        {
            Num c=new Num();
            if (b.numerator != 0)
                c.numerator = a.numerator * b.denominator;
            c.denominator = a.denominator * b.numerator;
            return c;
        }

        public static Num operator ^(Num a, Num b)//保证b的分母为1
        {
            Num c=new Num(1);
            for (int i = 0; i < b.numerator; i++)
                c = c * a;
            return c;
        }
	    public static bool operator ==(Num a, Num b)
        {
            if (a.flag==0)
                a.reduction();
            if (b.flag==0)
                b.reduction();
            int numerator1 = a.numerator / a.gcd;
            int numerator2 = b.numerator / b.gcd;
            int denominator1 = a.denominator / a.gcd;
            int denominator2 = b.denominator / b.gcd;
            if (a.symbol != b.symbol)
                return false;
            else if (numerator1 != numerator2 || denominator1 != denominator2)
                return false;
            else
                return true;
        }

        public static bool operator !=(Num a, Num b)
        {
            if (a.flag == 0)
                a.reduction();
            if (b.flag == 0)
                b.reduction();
            int numerator1 = a.numerator / a.gcd;
            int numerator2 = b.numerator / b.gcd;
            int denominator1 = a.denominator / a.gcd;
            int denominator2 = b.denominator / b.gcd;
            if (a.symbol != b.symbol)
                return true;
            else if (numerator1 != numerator2 || denominator1 != denominator2)
                return true;
            else
                return false;
        }

        public string c_Tostring()
        {
            string res = "";
            if (symbol == -1)
                res += "-";
            res = res + (numerator / gcd).ToString();
            if(denominator/gcd!=1)
            {
                res = res + "/";
                res = res + ((denominator / gcd).ToString());
            }
            return res;
        }

    }
}
