using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace laba_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ввидите чесло от 1 до 7");
            int day = Convert.ToInt32(Console.ReadLine());
            if(day ==1)
            {
                Console.WriteLine("Понедельник");
            }
            else if (day==2) 
            {
                Console.WriteLine("Вторник");
            }
            else if (day == 3)
            {
                Console.WriteLine("Среда");
            }
            else if (day == 4)
            {
                Console.WriteLine("Четверг");

            }
            else if (day == 5)
            {
                Console.WriteLine("Пятница");
            }
            else if (day == 6)
            {
                Console.WriteLine("Суббота");
            }
            else if  (day == 7)
            {
                Console.WriteLine("Воскресение");
            }
            else 
            {
                Console.WriteLine("не известный день");
            }
            Console.ReadKey();
        }
      
    }
}
    
   



    
