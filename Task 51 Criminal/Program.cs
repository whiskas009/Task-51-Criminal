using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_51_Criminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Criminal> criminals = new List<Criminal>() {new Criminal("Александр", "Иванов", 170, 95, "Русский", false),
                                                             new Criminal("Даниил", "Горин", 170, 95, "Русский", false),
                                                             new Criminal("Артём", "Кузнецов", 182, 75, "Американец", true),
                                                             new Criminal("Кирилл", "Кубышкин", 170, 95, "Арменин", true),};

            Console.WriteLine("Введите рост: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите вес: ");
            int weight = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите национальность: ");
            string nationality = Console.ReadLine();

            var foundCriminals = from Criminal criminal in criminals
                                 where criminal.Height == height
                                 where criminal.Weight == weight
                                 where criminal.Nationality == nationality
                                 where criminal.IsSrrested == false
                                 select criminal;

            foreach (var criminal in foundCriminals)
            {
                Console.WriteLine($"Имя: {criminal.FirstName}. Фамилия: {criminal.SecondName}");
            }
        }
    }

    class Criminal
    {
        public string FirstName { get; private set; }
        public string SecondName { get; private set; }
        public int Height { get; private set; }
        public int Weight { get; private set; }
        public string Nationality { get; private set; }
        public bool IsSrrested { get; private set; }

        public Criminal(string firstName, string secondName, int height, int weight, string nationality, bool isSrrested)
        {
            FirstName = firstName;
            SecondName = secondName;
            Height = height;
            Weight = weight;
            Nationality = nationality;
            IsSrrested = isSrrested;
        }
    }
}
