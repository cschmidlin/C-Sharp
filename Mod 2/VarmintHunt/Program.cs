using System;
namespace VarmintHunt {
    class Program {
        static void Main(string[] args) {
            Varmint fred = new Varmint(7);
            VarmintHunter jim = new VarmintHunter();

            jim.takePhoto();
            Console.WriteLine(jim.getPhotos());


            try{
                int [] trouble = new int[3];
                trouble[3] = 5;
            } catch(IndexOutOfRangeException ex){
                Console.WriteLine(ex.Message);
            } catch(Exception ex) {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            

            
        }
    }
}
