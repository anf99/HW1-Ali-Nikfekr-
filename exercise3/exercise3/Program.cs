using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    class Program 
    {
      
       
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            int n;
            Console.WriteLine("press 1 to see date");
            Console.WriteLine("press 2 to enter 10 number");
            Console.WriteLine("press 0 to exit");
            n = int.Parse(Console.ReadLine());

            menu.set_n(n);

            Console.Clear();
           
            while (n != 0)
                switch (n)
                {
                    case 1:
                        Console.WriteLine(menu.W_S());
                        Console.WriteLine("press 1 to see date");
                        Console.WriteLine("press 2 to enter 10 number");
                        Console.WriteLine("press 0 to exit");
                        n = int.Parse(Console.ReadLine());

                        menu.set_n(n);

                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("max is : " + menu.W_S());
                        Console.WriteLine("press 1 to see date");
                        Console.WriteLine("press 2 to enter 10 number");
                        Console.WriteLine("press 0 to exit");
                        n = int.Parse(Console.ReadLine());

                        menu.set_n(n);

                        Console.Clear();
                        break;
                }
            Environment.Exit(0);
        }
    }
}
