using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    class FF
    {
        public string D()
        {
            DateTime ta = DateTime.Today;
            return Convert.ToString(ta.Date);
        }
        public string M()
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
    }
}
