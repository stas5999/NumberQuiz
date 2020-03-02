using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int e = rnd.Next(1,10);
            Console.WriteLine("Отгадай число");
            int x;
            x= Convert.ToInt32(Console.ReadLine());
            if (x!=e)
            {
                Console.WriteLine("Вы не угадали число");
            }
            else
            {
                Console.WriteLine("Поздравляем, вы угадали!");
            }
            Console.ReadKey();
        }
    }
}
