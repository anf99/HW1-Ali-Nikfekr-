using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    class Menu : FF
    {
        FF fF = new FF();
        public int n;
        public void set_n(int n1)
        {
            n = n1;
        }
        public int get_n()
        {
            return n;
        }

        public string W_S()
        {


            switch (n)
            {
                case 1:
                    return fF.D();
                case 2:
                    return fF.M();
            }
            return "wrong number";
        }

    }
}
