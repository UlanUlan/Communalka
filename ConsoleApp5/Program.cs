using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            /*1.	Написать программу, рассчитывающую сумму коммунальных платежей: 
             * есть базовые тарифы на отопление (на 1 м2 площади), на воду (на 1 чел), 
             * на газ (на 1 чел), на текущий ремонт (на 1 м2 площади).
             * Задается метраж помещения, количество проживающих людей, 
             * сезон (осенью и зимой отопление дороже), наличие льгот 
             * (ветеран труда– 30 % от его части; ветеран войны- 50% от его части). 
             * Вывести таблицу со столбцами: Вид платежа, Начислено, Льготная скидка,
             * Итого. Посчитать итоговую сумму.*/
            try
            {
                List<Humans> humans = new List<Humans>();
                for (int i = 0; i < rand.Next(1, 30); i++)
                {
                    if(i % 2 == 0)
                        humans.Add(new Humans());
                    else if ((i % 3 == 0))
                        humans.Add(new Humans(Lgota.veteranVoiny));
                    else
                        humans.Add(new Humans(Lgota.veteranTruda));
                }
                Console.WriteLine("Количество людей: {0} \n", humans.Count());
                Console.WriteLine("*Платёж летом*\n");

                KSK.Platej(100, humans, sezon.leto); // Метраж, количество людей, летний платёж
                Console.WriteLine("\n------------------------------------------------------------");
                Console.WriteLine("*Платёж зимой*\n");
                KSK.Platej(200, humans, sezon.zima); // Метраж, количество людей, зимний платёж -- Отопление дороже
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
