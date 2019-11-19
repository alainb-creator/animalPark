using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace park_animalier
{
    class Predateurs : Animal
    {
        double HuntSuccesChance { get; set; }

        public Predateurs(int energie, string espece, string sexe,bool alive, double huntSuccesChance)
        : base(energie, espece, sexe, alive)
        {
            HuntSuccesChance = 100;
        }

        public override void Feed()
        {
            throw new NotImplementedException();
        }
    }
}
