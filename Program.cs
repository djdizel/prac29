using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace prac29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bus> bus = new List<Bus>();
            for (int i = 0; i < 1; i++)
            {
                Console.Write($"Введите марку:");
                string brand = Console.ReadLine();
                Console.Write($"Введите места:");
                int summary = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Введите стоимость билета:");
                int value = Convert.ToInt32(Console.ReadLine());
                bus.Add(new Bus(brand, summary, value));
                bus[i].Print();
                Console.WriteLine($"Общая стоимость:{bus[i].Total_Cost()}");
            }
            Console.WriteLine();

            List<TurBus> bus2 = new List<TurBus>();
            for (int i = 0; i < 1; i++)
            {
                Console.Write($"Введите марку:");
                string brand = Console.ReadLine();
                Console.Write($"Введите места:");
                int summary = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Введите стоимость билета:");
                int value = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Введите стоимость экскурсии:");
                int costofex = Convert.ToInt32(Console.ReadLine());
                bus2.Add(new TurBus(brand, summary, value, costofex));
                bus2[i].Print();
                Console.WriteLine($"Общая стоимость:{bus2[i].Total_Cost()}");
            }
        }
    }
}
