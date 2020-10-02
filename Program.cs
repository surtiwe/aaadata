using System;
using System.Runtime.Intrinsics.X86;
using System.Text;




namespace Norm
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.GetEncoding(1251);

            // 4 Задание.

            Console.Write("Введите любое число: ");
            double num = Convert.ToDouble(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine($"{num} является четным");
            else
                Console.WriteLine($"{num} является нечетным");

            Console.WriteLine(""); 

            // 5 Задание.

            Console.Write("Расстояние до дачи        : ");
            double km = Convert.ToDouble(Console.ReadLine());
            Console.Write("Трата топлива на 100км    : ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.Write("Цена одного литра бензина : ");
            double price = Convert.ToDouble(Console.ReadLine());

            double lkm = km / 100;
            double lkm1 = lkm * l;
            double summa = lkm1 * price;
            double summa2 = summa * 2;
            Math.Round(summa2, 3);

            Console.WriteLine($"Стоимость поездки туда и обратно: {summa2}");

            // 6 Задание.

            Console.WriteLine("");

            Console.Write("Укажите три целых числа: Y(год), M (месяц) и D (день).\n\tY (год) - ");
            try
            {
                int y = int.Parse(Console.ReadLine());

                Console.Write("\tM (месяц 1-12) - ");
                int m = int.Parse(Console.ReadLine());

                //Масив количества дней в месяце
                int[] mD = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                //Уточнение, если год високосный
                if (y % 400 == 0 || (y % 4 == 0 && y % 100 != 0))
                    mD[1] = 29;

                Console.Write("\tD (день 1-{0}) - ", mD[m - 1]);
                int d = int.Parse(Console.ReadLine());
               

                if (d != mD[m - 1])
                    d++;
                else if (m != 12)
                {
                    d = 1;
                    m++;
                }
                else
                {
                    d = m = 1;
                    y++;
                }

                Console.WriteLine($"Следующим днем является {d}.{m}.{y}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            int a, b;
            Random obj = new Random();
            a = obj.Next(10);
            b = obj.Next(10);

            int c;

            c = a * b;

            Console.Write($"Условие {a} * {b}. Какой ответ:");
            double otvet = Convert.ToDouble(Console.ReadLine());

            if (otvet == c)
            {
                Console.WriteLine("Правильно!");
            }
            else
                Console.WriteLine($
                    "Неправильно! Правильный ответ = {c}");


            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
