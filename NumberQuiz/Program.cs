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
            Console.WriteLine("Введите число n и m");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Random rnd = new Random();
            int e = rnd.Next(n,m);
            Console.WriteLine("Отгадай число");
            int x= Convert.ToInt32(Console.ReadLine());
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
