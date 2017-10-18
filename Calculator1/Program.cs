using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            calculator c = new calculator();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("欢迎使用，请输入您想计算的字符");
                c.X = Console.ReadLine();
                c.Y = Console.ReadLine();
                Console.WriteLine("请输入要进行的运算（加：+；减：-；乘：*；除：/）");
                String op = Console.ReadLine();
                switch (op)
                {
                    case "+": c.add(); break;
                    case "-": c.sub(); break;
                    case "*": c.mul(); break;
                    case "/": c.div() ; break;
                    default:
                        Console.WriteLine("请按规定输入"); break;
                }

                Console.WriteLine("您是否想要继续，如果继续，请输入‘Y’，否则，输入‘N’");
                String ar = Console.ReadLine();
                if (ar.Equals("Y"))
                {
                    flag = true;
                }
                else if (ar.Equals("N"))
                {
                    flag = false;
                    Console.WriteLine("谢谢使用！");
                }
                else
                {
                    flag = false;
                    Console.WriteLine("请按要求输入！");
                }
            }
        }
    }
    class calculator
    {
        private string x;
        private string y;

        public string Y
        {
            get { return y; }
            set { y = value; }
        }
        public string X
        {
            get { return x; }
            set { x = value; }
        }
        //判断输入的数据是字符串还是数字
        public bool IsInteger(string strIn)
        {
            bool bolResult = true;
            if (strIn == "")
            {
                bolResult = false;
            }
            else
            {
                foreach (char Char in strIn)
                {
                    if (char.IsNumber(Char))
                        continue;
                    else
                    {
                        bolResult = false;
                        break;
                    }
                }
            }
            return bolResult;
        }
        public void add()
        {
            if (IsInteger(x))
            {
                int a = Convert.ToInt32(x);
                if (IsInteger(y))
                {
                    int b = Convert.ToInt32(y);
                    Console.WriteLine(a + b);
                }
            }
            else
            {
                Console.WriteLine(x + y);
            }

        }
        //字符串减法
        public string Transfer(string a, string b)
        {
            string r = null;
            char[] ss = a.ToCharArray();
            char[] bb = b.ToCharArray();
            List<char> L = new List<char>();
            for (int k = 0; k < ss.Length; k++)
            {
                L.Add(ss[k]);
            }
            for (int i = 0; i < bb.Length; i++)
            {
                for (int j = 0; j < ss.Length; j++)
                {
                    if (bb[i] == ss[j])
                    {
                        L.Remove(ss[j]);
                    }
                }
            }
            foreach (char c in L)
            {
                r = r + c;
            }
            return r;
        }
        public void sub()
        {
            if (IsInteger(x))
            {
                int a = Convert.ToInt32(x);
                if (IsInteger(y))
                {
                    int b = Convert.ToInt32(y);
                    Console.WriteLine(a - b);
                }
            }
            else
            {
                Console.WriteLine(Transfer(x, y));
            }
        }
        public void mul()
        {
            if (IsInteger(x))
            {
                int a = Convert.ToInt32(x);
                if (IsInteger(y))
                {
                    int b = Convert.ToInt32(y);
                    Console.WriteLine(a * b);
                }
            }
            else
            {
                Console.WriteLine("字符串不能相乘，请重新输入");
            }
        }
        public void div()
        {
            try
            {
                if (IsInteger(x))
                {
                    int a = Convert.ToInt32(x);
                    if (IsInteger(y))
                    {
                        int b = Convert.ToInt32(y);
                        Console.WriteLine(a / b);
                    }
                }
                else
                {
                    Console.WriteLine("字符串不能相除，请重新输入");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("错误：" + e.Message);
            }
        }
    }
}
