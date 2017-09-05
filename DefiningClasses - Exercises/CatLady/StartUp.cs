using System;
using System.Linq;
using System.Collections.Generic;

namespace CatLady
{
    public class StartUp
    {
        public static void Main()
        {
            string infoLine;
            List<Cat> cats = new List<Cat>();

            while ((infoLine = Console.ReadLine()) != "End")
            {
                string[] tokens = infoLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string breed = tokens[0];
                string name = tokens[1];
                double size = double.Parse(tokens[2]);

                cats.Add(new Cat(breed, name, size));
            }

            string searchCat = Console.ReadLine();

            foreach (Cat cat in cats)
            {
                if (cat.Name == searchCat && cat.Breed == "Cymric")
                {
                    Console.WriteLine($"{cat.Breed} {cat.Name} {cat.Size:F2}");
                }
                else if (cat.Name == searchCat)
                {
                    Console.WriteLine($"{cat.Breed} {cat.Name} {cat.Size}");
                }
                else
                {

                }
            }
        }
    }
}
