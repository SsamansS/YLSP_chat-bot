using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YLSP_chat_bot
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[][] nums = new int[3][];
            nums[0] = new int[2] { 1, 2 };          // выделяем память для первого подмассива
            nums[1] = new int[3] { 1, 2, 3 };       // выделяем память для второго подмассива
            nums[2] = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(nums[0][0]);*/




            string[][] zakon = new string[4][];

            string[] za = { "Абдыкеримова", "Абжалиева", "Айдаров СА", "Айнакулов МА", "Алимбеков НК" };
            zakon[0] = za;

            string[] protiv = { "Акаев ЖК", "Артыков АА", "Бекешев ДД", "Бешимбаева АК", "Жеенчороев МК" };
            zakon[1] = protiv;

            string[] otsutstvovali = { "Абдылдаев МЮ", "Айдаров НА", "Акматов АЖ" };
            zakon[2] = protiv;

            string[] iniciator = { "Гульшат Асылбаева" };
            zakon[3] = iniciator;

            string[] massiv = { "za", "protiv", "otststvovali", "iniciator" };



            for (int i = 0; i <= zakon.GetUpperBound(0); i++)
            {
                Console.WriteLine($"\n{massiv[i]}");
                for (int j = 0; j < zakon[i].Length; j++)
                {
                    Console.WriteLine(zakon[i][j]);
                }
            }



            Console.WriteLine($"\n{zakon[2][1]}");
            Console.WriteLine(nameof(za));





          

            List<object> Закон_о_манипуляции_информацией_в_интернете = new List<object>();

            List<string> инициатор = new List<string> { "dsd", "SortedDictionary" };
            Закон_о_манипуляции_информацией_в_интернете[0] = инициатор;

            List<string> за = new List<string> { "dsd", "SortedDictionary" };
            Закон_о_манипуляции_информацией_в_интернете[1] = за;

            List<string> против = new List<string> { "dsd", "SortedDictionary" };
            Закон_о_манипуляции_информацией_в_интернете[2] = за;

            List<string> отсутствовал = new List<string> { "dsd", "SortedDictionary" };
            Закон_о_манипуляции_информацией_в_интернете[3] = за;

            foreach (string i in против)
            {
                Console.WriteLine(против[0]);
            }








            Console.ReadLine();
        }
    }
}
