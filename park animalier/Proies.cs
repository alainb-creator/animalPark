using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace park_animalier
{
    class Proies :Animal
    {
        double EscapeChance { get; set; }
        public Proies(int energie, string espece, string sexe, Boolean alive, double EscapeChance)
       : base(energie, espece, sexe, alive)
        {
            EscapeChance =100;
        }

        public override void Feed()
        {
            if (new Random().Next(0, 100) > 40)
                this.Energie = 100;
        }
    }
}
