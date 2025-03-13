using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac29
{
        class Bus
        {
        /// <summary>
        /// поля
        /// </summary>
        string brand;
        int summary;
        int value;
        /// <summary>
        /// инкапсуляция
        /// </summary>
        public string Brand { get => brand; set => brand = value; }
        public int Summary { get => summary; set => summary = value; }
        public int Value { get => value; set => this.value = value; }
        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="summary"></param>
        /// <param name="value"></param>
        public Bus(string brand, int summary, int value)
        {
            Brand = brand;
            Summary = summary;
            Value = value;
        }
        /// <summary>
        /// метод общ стоимость 
        /// </summary>
        public virtual double Total_Cost()
        {
            return Summary * Value;
        }
        /// <summary>
        /// Вывод
        /// </summary>
        public virtual void Print()
        {
            Console.WriteLine($"марка:{Brand}, количество мест:{Summary}, стоимость билета:{Value}");
        }
    }
}
