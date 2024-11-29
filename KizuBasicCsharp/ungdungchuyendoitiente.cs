using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KizuBasicCsharp
{
    public static class ungdungchuyendoitiente
    {
        public static void run()
        {
            int rate = 23000;
            float USD;
            float VND;
            Console.WriteLine("Enter USD :");
            USD = float.Parse(Console.ReadLine());
            VND = USD * rate;
            Console.WriteLine("Change to VND : " + VND);
            Console.ReadLine();
        }
    }
}
