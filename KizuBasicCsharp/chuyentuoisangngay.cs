using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KizuBasicCsharp
{
    public static class chuyentuoisangngay
    {
        public static void run()
        {
            Console.Write("Nhập vào số tuổi của bạn: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                if (age > 0 && age <= 120)
                {
                    int daysLived = age * 365; 
                    Console.WriteLine($"Bạn đã sống khoảng {daysLived} ngày.");
                }
                else
                {
                    Console.WriteLine("Số tuổi không hợp lệ!");
                }
            }
            else
            {
                Console.WriteLine("Số tuổi không hợp lệ!");
            }
            Console.ReadLine();
        }
    }
}
