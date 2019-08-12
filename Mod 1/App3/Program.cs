using System;
namespace App3 {
    class Program {
        static void Main(string[] args) {
            foreach (string str in Enum.GetNames(typeof(WeekDays)))
                Console.WriteLine(str);
        }
        enum WeekDays{
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
