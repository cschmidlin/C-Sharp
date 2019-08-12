using System;
namespace App1 {
    class Program {
        static void Main(string[] args) {
            nameFunction();
        }
        static void nameFunction() {
            char token = 't';
            string str1 = "name";
            while(token != 'q'){
                Console.Write("Enter name: ");
                str1 = Console.ReadLine();
                if (String.IsNullOrEmpty(str1)){
                    token = 'q';
                    Console.WriteLine("See you next time!");
                } else {
                    Console.WriteLine("Hello, " + str1 + "!");
                }
            }
        }
    }
}

