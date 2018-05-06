using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public enum sezon { osen, zima, vesna, leto }
    public static class KSK
    {
        private static sezon Sezon { get; set; }

        public static void Platej(int Metraj, List<Humans> humans, sezon Sezon)
        {
            int summaVody = 0, summaGaza = 0, summaOtopleniya = 1, summaRemonta = 1;
            int vTruda = 0, vVoiny = 0;
            foreach (Humans item in humans)
            {
                summaVody += item.tarifNaVodu;
                summaGaza += item.tarifNaGaz;
                summaOtopleniya = item.tarifNaOtoplenie * Metraj;
                summaRemonta = item.tarifNaRemont * Metraj;
            }

            if (Sezon == sezon.osen || Sezon == sezon.zima)
                summaOtopleniya = ((summaOtopleniya / 10) * 12);

            foreach (Humans item in humans)
            {
                if (item.lgota == Lgota.veteranTruda)
                    ++vTruda;
                if (item.lgota == Lgota.veteranVoiny)
                    ++vVoiny;
            }

            Console.Write("Вид платежа: {0} обычных, {1} льготных\n\n", humans.Count() - (vVoiny + vTruda), vTruda + vVoiny);
            Console.Write("Начислено:\n За воду: {0}\n За газ: {1}\n За отопление: {2}\n За ремонт: {3}\n\n",
                summaVody, summaGaza, summaOtopleniya, summaRemonta);
            Console.Write("Льготная скидка: {0} скидок по 30%, {1} скидок по 50%\n\n", vTruda, vVoiny);
            Console.WriteLine("Итого: {0}", summaGaza + summaOtopleniya + summaRemonta + summaVody);
        }

    }
}
