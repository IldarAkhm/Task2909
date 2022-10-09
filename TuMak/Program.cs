using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuMak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NOD(22,33)); Console.Read();
        }
        static int NOD(int a, int v)
        {
            int min = int.MaxValue;
            int cnt = 1;
            if (a > v)
            {
                if (v < min)
                {
                    min = v;
                }
            }
            else if (a < v)
            {
                if (a < min)
                {
                    min = a;
                }
            }
            else
            {
                min = a;
            }
            for (int i = 1; i < min + 1; i++)
            {
                if (a % i == 0 && v % i == 0)
                {
                    if (cnt > i)
                    {
                        cnt = i;
                    }
                }
            }
            return cnt;   
        }
        static int Greatest(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else if (a < b)
            {
                return b;
            }
            else
            {
                return 0;
            }
            
        }
        static string Swap(int a, int b)
        {
            return $"{b} {a}";
        }
        static string Fact(int a)
        {
            byte cnt = 1;
            try
            {
                checked
                {
                    for (byte i = 1; i != a; i++)
                    {
                        cnt *= i;
                    }
                    return $"true";
                }
                
                
            }
            catch
            {
                return "false";
            }
            
        }
        static int Fact1(int a)
        {
            int cnt = 1;
            for (int i = 1; i != a; i++)
            {
                cnt *= i;
            }
            return cnt * a;
        }
    }
}
