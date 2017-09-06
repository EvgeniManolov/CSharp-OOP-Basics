using System;

namespace Mankind
{
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                string[] studentTokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Student student = new Student(studentTokens[0], studentTokens[1], studentTokens[2]);
                string[] workerTokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Worker worker = new Worker(workerTokens[0], workerTokens[1], decimal.Parse(workerTokens[2]), decimal.Parse(workerTokens[3]));

                Console.WriteLine(student.ToString());
                Console.WriteLine();
                Console.WriteLine(worker.ToString());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}

