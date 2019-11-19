using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace park_animalier
{
    class Giraffe : Proies
    {
        public Giraffe(int energie, string espece, string sexe, bool alive, double EscapeChance)
          : base(energie, espece, sexe, alive, EscapeChance)
        {

        }
        public override void Feed()
        {
            throw new NotImplementedException();
        }
    }
}
