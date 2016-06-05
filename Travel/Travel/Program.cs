using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> tours = new Dictionary<string, string>();
            tours.Add("Москва", "Париж");
            tours.Add("Кёльн", "Москва");
            tours.Add("Мельбурн", "Кёльн");
            TourList tourList = new TourList(tours);
            Console.WriteLine("До сортировки: ");
            foreach (var tour in tourList.Tours)
            {
                Console.WriteLine("{0} - {1}", tour.Key, tour.Value);
            }

            tourList.Sort();

            Console.WriteLine("\nПосле сортировки: ");
            foreach (var tour in tourList.Tours)
            {
                Console.WriteLine("{0} - {1}", tour.Key, tour.Value);
            }
            Console.ReadLine();
        }
    }
}
