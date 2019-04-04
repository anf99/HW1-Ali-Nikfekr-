using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    class Program
    {
        static string D()
        {
            DateTime ta = DateTime.Today;
            return Convert.ToString(ta.Date);
        }
        string M()
        {
            int[] num = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("number {0} : ", i + 1);
                num[i] = int.Parse(Console.ReadLine());
            }
            int max = num[0];
            for (int i = 1; i < 10; i++)
                if (num[i] > max)
                    max = num[i];
            return Convert.ToString(max);
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("press 1 to see date");
            Console.WriteLine("press 2 to enter 10 number");
            Console.WriteLine("press 0 to exit");
            n = int.Parse(Console.ReadLine());
            Console.Clear();
            while(n!=0)
                switch(n)
                {
                    case 1:
                        Console.WriteLine(Program.D());
                        Console.WriteLine("press 1 to see date");
                        Console.WriteLine("press 2 to enter 10 number");
                        Console.WriteLine("press 0 to exit");
                        n = int.Parse(Console.ReadLine());
                        Console.Clear();
                        break;
                    case 2:
                        Program m1 = new Program();
                        Console.WriteLine("max is : " + m1.M());
                        Console.WriteLine("press 1 to see date");
                        Console.WriteLine("press 2 to enter 10 number");
                        Console.WriteLine("press 0 to exit");
                        n = int.Parse(Console.ReadLine());
                        Console.Clear();
                        break;
                }
            Environment.Exit(0);
        }
    }
}
