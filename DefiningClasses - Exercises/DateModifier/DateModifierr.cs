using System;
using System.Linq;

namespace DateModifier
{
    public class DateModifierr
    {
        public static void DifferenceBetweenTwoDates(string firstDate, string secondDate)
        {
            int[] date1 = firstDate.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] date2 = secondDate.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            DateTime dateOne = new DateTime(date1[0], date1[1], date1[2]);
            DateTime dateTwo = new DateTime(date2[0], date2[1], date2[2]);

            Console.WriteLine(Math.Abs((dateOne - dateTwo).TotalDays));
        }
    }
}
