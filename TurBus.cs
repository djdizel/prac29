using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac29
{
    class TurBus : Bus 
    {
        /// <summary>
        /// поля
        /// </summary>
        int costofex;
        /// <summary>
        /// интерполяция
        /// </summary>
        public int Costofex { get => costofex; set => costofex = value; }
        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="summary"></param>
        /// <param name="value"></param>
        /// <param name="costofex"></param>
        public TurBus(string brand, int summary, int value,int costofex) : base(brand,summary,value) 
        {
            Costofex = costofex;
        }
        /// <summary>
        /// метод общая стоимость всех мест
        /// </summary>
        /// <returns></returns>
        public override double Total_Cost()
        {
            return Summary * (Value + Costofex);
        }
        /// <summary>
        /// вывод
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"стоимость экскурсии:{Costofex}");
        }
    }
}
