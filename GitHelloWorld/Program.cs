using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            calculator c = new calculator();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("欢迎使用，请输入两个整数");
                c.X = int.Parse(Console.ReadLine());
                c.Y = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入要进行的运算（加：+；减：-；乘：*；除：/；判断两个数是否相等：1）");
                String op = Console.ReadLine();
                switch (op)
                {
                    case "+": Console.WriteLine(c.add()); break;
                    case "-": Console.WriteLine(c.sub()); break;
                    case "*": Console.WriteLine(c.mul()); break;
                    case "/": Console.WriteLine(c.div()); ; break;
                    case "1": c.equals(c.X, c.Y); break;
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
        private int x;
        private int y;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public void equals(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine("两个整数相等");
            }
            else
            {
                Console.WriteLine("两个整数不相等");
            }
        }
        public int add()
        {
            return (x + y);
        }
        public int sub()
        {
            return (x - y);
        }
        public int mul()
        {
            return (x * y);
        }
        public int div()
        {
            int m = 0;
            try
            {
                m = x / y;
            }
            catch (Exception e)
            {
                Console.WriteLine("错误：" + e.Message);
            }
            return m;
        }
    }

}
