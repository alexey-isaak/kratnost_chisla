using System;
 
namespace kratnost_chisla
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число: ");
            double chisloA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double chisloB = Convert.ToDouble(Console.ReadLine());
            if (chisloA % chisloB == 0)
            {
                Console.WriteLine("Первое число кратно второму");
            }
            else
            {
                double ostatok = chisloA / chisloB;
                Console.WriteLine(ostatok);
                string ostatok_str = Convert.ToString(ostatok);
                int index_dot = ostatok_str.IndexOf(",");
                Console.WriteLine(index_dot);
                int ostatok_l = ostatok_str.Length - 1;
                Console.WriteLine(ostatok_l);
                string ostatok_f = ostatok_str.Substring(index_dot + 1);
                Console.WriteLine("Числа не кратные, остаток от деления: " + ostatok_f);
            }
            
            
        }
    }
}
