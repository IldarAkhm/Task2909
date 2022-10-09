using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.CodeDom;

namespace DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Задани 1");
            //var a = double.Parse(Console.ReadLine());
            //var b = double.Parse(Console.ReadLine());
            //var c = double.Parse(Console.ReadLine());
            //c = Sqrt(a, b, c);
            //Console.WriteLine(c);
            //Console.Read();

            //Console.WriteLine("Задание 2");
            //Random random = new Random();
            //int elem = int.Parse(Console.ReadLine());
            //int[] inits = new int[elem];

            //for (int i = 0; i < elem; i++)
            //{
            //    int rnd = random.Next(1, 1000);
            //    inits[i] = rnd;
            //    Console.Write($"{i} "); Console.WriteLine(inits[i]);
            //}
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine(Lst(inits, a, b));
            //Console.Read();

            //Console.Write("Задание 3");
            //Console.Write("Сколько элементов будет в массиве?:");
            //int elem = int.Parse(Console.ReadLine());
            //int[] ints = new int[elem];
            //for (int i = 0; i < elem; i++)
            //{
            //    int mass = int.Parse(Console.ReadLine());
            //    ints[i] = mass;
            //}

            //Console.WriteLine(Lits(elem, ints)); Console.Read();
            //Console.WriteLine(Lits(5,12,2,43,64,23)); Console.Read(); // Задание 7

            //Console.Write("Задание 4\n");
            //int b = 1;
            //int c;
            //Console.WriteLine(Summultaverarifm(ref b,out c,5,2,2)); Console.Read();


            //Console.Write("Задание 5\n");

            //try
            //{
            //    int value = int.Parse(Console.ReadLine());
            //    if (value > 9 || value < 0)
            //    {
            //        Console.BackgroundColor = ConsoleColor.Red;
            //        Console.Clear();
            //        Thread.Sleep(3000);
            //        Console.Write("Ошибка");
            //    }
            //    else
            //    {
            //        switch (value)
            //        {
            //            case 0:
            //                Console.Write("###" + "\n" + "# #" + "\n" + "# #" + "\n" + "# #" + "\n" + "###");
            //                break;
            //            case 1:
            //                Console.Write(" # " + "\n" + "## " + "\n" + " # " + "\n" + " # " + "\n" + "###");
            //                break;
            //            case 2:
            //                Console.Write(" # " + "\n" + "# #" + "\n" + "  #" + "\n" + " # " + "\n" + "###");
            //                break;
            //            case 3:
            //                Console.Write("## " + "\n" + "  #" + "\n" + " # " + "\n" + "  #" + "\n" + "## ");
            //                break;
            //            case 4:
            //                Console.Write("# #" + "\n" + "# #" + "\n" + "###" + "\n" + "  #" + "\n" + "###");
            //                break;
            //            case 5:
            //                Console.Write("###" + "\n" + "#  " + "\n" + "###" + "\n" + "  #" + "\n" + "## ");
            //                break;
            //            case 6:
            //                Console.Write(" ##" + "\n" + "#  " + "\n" + "###" + "\n" + "# #" + "\n" + "###");
            //                break;
            //            case 7:
            //                Console.Write("###" + "\n" + "  #" + "\n" + "  #" + "\n" + " # " + "\n" + " # ");
            //                break;
            //            case 8:
            //                Console.Write("###" + "\n" + "# #" + "\n" + " # " + "\n" + "# #" + "\n" + "###");
            //                break;
            //            case 9:
            //                Console.Write("###" + "\n" + "# #" + "\n" + "###" + "\n" + "  #" + "\n" + "###");
            //                break;
            //            default:
            //                break;
            //        }

            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("Это не цифра");
            //}
            //Console.Write("\nЧтобы выйти введите exit или закрыть\n");
            //string text = Console.ReadLine();
            //switch (text)
            //{
            //    case "закрыть":
            //        Environment.Exit(0);
            //        break;
            //    case "exit":
            //        Environment.Exit(0);
            //        break;
            //}

            //Console.Read();

            //Console.Write("Задание 6\n");

            //string[] phrases = new string[] {"гады", "проститутки"};
            //GrandFather Ram = new GrandFather ("Ramis", 2, (En(phrases)),0);
            //Ram.Print();
            //string[] phrases1 = new string[] { "уроды" };
            //GrandFather Aid = new GrandFather("Aidar", 1, (En(phrases1)), 5);
            //Aid.Print();
            //string[] phrases2 = new string[] { "геи" };
            //GrandFather Dim = new GrandFather("Dim", 2, (En(phrases2)), 0);
            //Dim.Print();
            //string[] phrases3 = new string[] { "тупицы", "суки" };
            //GrandFather Ain = new GrandFather("Ainur", 0, (En(phrases3)), 0);
            //Ain.Print();
            //string[] phrases4 = new string[] { "бляди" };
            //GrandFather Ed = new GrandFather("Eduard", 5, (En(phrases4)), 5);
            //Ed.Print();
            //Console.Write(Ded("Aidar", "суки","бляди"));
            //Console.Read();

        }
        static string Ded(string name, params string[] phrases) // Задание 6
        {
            string[] mat = new string[] { "суки", "бляди" };
            int cnt = 0;
            for (int i = 0; i < phrases.Length; i++)
            {
                for (int j = 0; j < mat.Length; j++)
                {
                    if (phrases[i] == mat[j])
                    {  
                        cnt++;
                    }
                }
                
            }
            return $"У {name} {cnt} фингалов.";
        }
        static string En(string[] grouchiness) 
        {
            int cnt = grouchiness.Length;
            string phrases;
            phrases = "";
            for (int i = 0; i < cnt ; i++)
            {
                phrases += grouchiness[i] + " ";
            }
            return phrases;
        }
        struct GrandFather
        {
            public string name;
            public int level;
            public string grouchiness;
            public int fight;

            public GrandFather(string name, int level, string grouchiness, int fight)
            {
                this.name = name;
                this.level = level;
                this.grouchiness = grouchiness;
                this.fight = fight;
            }

            public void Print()
            {
                Console.WriteLine($"Деда зовут {name}\nуровень ворчливости: {level}" +
                    $"\nмассив его фраз: {(grouchiness)}\nколичество синяков: {fight}");
            }
        }
        enum Level // Задание 6
        {
            Неворчливый = 0,
            Чутьворчит = 1,
            Ворчит = 2,
            МоральныйУрод = 3
        }
        static string Summultaverarifm(ref int mult, out int average,params int[] numbers)    // Задание 4
        {
            var result = 0;
            foreach (var i in numbers)
            {
                result += i;
            }
            Console.WriteLine(result);
            average = result / numbers.Length;
            Console.WriteLine(average);
            
            foreach (var i in numbers)
            {
                mult *= i;
            }
            Console.WriteLine(mult);
            return "";
        }
        static string Lst(int[] inits, int a, int b) // Задание 2
        {
            for (int i = 0; i < 20; i++)
            {
                if (inits[i] == a)
                {
                    inits[i] = b;
                }
                else if (inits[i] == b)
                {
                    inits[i] = a;
                }
            }
            for (int i = 0; i < 20; i ++)
            {
                Console.WriteLine($"{i}  {inits[i]}");
            }
            return "";
        }
        static string Lits(int b, params int[] ints) //Задание 3
        {
            int temp;
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < b - 1 - i; j++)
                {
                    if (ints[j] > ints[j + 1])
                    {
                        temp = ints[j];
                        ints[j] = ints[j + 1];
                        ints[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < b; i++)
            {
                Console.WriteLine(ints[i]);
            }
            return "";
            

        }


        static string Sqrt(double a, double b, double c) //Задание 1
        {
            var D = Math.Pow((Math.Pow(b, 2) - 4 * a * c), 0.5);
            if (D == 0)
            {
                var x1 = (-b + D) / (2 * a);
                Console.WriteLine($"Корень 1: {x1}");
            }
            else if (D < 1)
            {
                Console.WriteLine("Корней нет");
            }
            else
            {
                var x1 = (-b + D) / (2 * a);
                var x2 = (-b - D) / (2 * a);
                Console.WriteLine($"Корни уравнения: {x1} {x2}");
            }
            return "";
            
            

        
        }
        
    }
}
