using System;
namespace VarmintHunt {
    class VarmintHunter {
        private int photos;
        public VarmintHunter(){
            Console.WriteLine("Be vewy, vewy quiet -- I'm hunting Varmints!");
        }
        private int Photos {
            get { return photos; }
            set { photos = value; }
        }
        public void takePhoto(){
            
        }
    }
}