using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            string type = Console.ReadLine();

            while (type != "Beast!")
            {
                string[] tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    Animal animal = null;

                    switch (type)
                    {
                        case "Cat":
                            animal = new Cat(tokens[0], int.Parse(tokens[1]), tokens[2]);
                            break;
                        case "Dog":
                            animal = new Dog(tokens[0], int.Parse(tokens[1]), tokens[2]);
                            break;
                        case "Frog":
                            animal = new Frog(tokens[0], int.Parse(tokens[1]), tokens[2]);
                            break;
                        case "Kitten":
                            animal = new Kitten(tokens[0], int.Parse(tokens[1]));
                            break;
                        case "Tomcat":
                            animal = new Tomcat(tokens[0], int.Parse(tokens[1]));
                            break;

                        default: throw new ArgumentException("Invalid input!");
                    }
                    Console.WriteLine(animal);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input!");
                }
                type = Console.ReadLine();
            }
        }
    }
}
