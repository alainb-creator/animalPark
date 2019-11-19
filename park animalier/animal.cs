using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace park_animalier
{
    public abstract class Animal
    {
        public int Energie { get; set; }
        public string Espece { get; set; }
        public string Sexe { get; set; }
        public Boolean Alive { get; set; }

        public Animal(int energie, string espece, string sexe, bool alive)
        {
            Espece = espece;
            Energie = 100;
            Alive = true;
            Sexe = sexe;
        }
        public abstract void Feed();

        public void Reproduction()
        { 

        }

        public void EnergieParJour()
        {
            Energie -= 20;
        }

        private static Dictionary<string, int> RaceAnimal;

        static Animal()
        {
            RaceAnimal = new Dictionary<string, int>();
            RaceAnimal["Lion"] = 0;
            RaceAnimal["Ours"] = 1;
            RaceAnimal["Hyene"] = 2;
            RaceAnimal["Gazelle"] = 3;
            RaceAnimal["Lapin"] = 4;
            RaceAnimal["Giraffe"] = 5;
        }
    }
}
