using System;
namespace App2 {
    class Program {
        static void Main(string[] args) {
            string[] strArray = new string [] {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};

            for (int i = 0; i < strArray.Length; i++){
                Console.WriteLine(strArray[i]);
            }
        }
    }
}
