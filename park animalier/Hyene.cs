using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace park_animalier
{
    class Hyene :Predateurs
    {
        public Hyene(int energie, string espece, string sexe, bool alive, double huntSuccesChance)
            : base(energie, espece, sexe, alive, huntSuccesChance)
        { }
        public override void Feed()
        {
            throw new NotImplementedException();
        }
    }
}
