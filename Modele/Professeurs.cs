using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Modele
{
    class Professeurs : Personne
    {
        private int salaire;

        public Professeurs(int i, string n, string p, string t, string a, string m, int s) : base(i, n, p, t, a, m)
        {
            this.salaire = s;
        }

        public Professeurs()
        {

        }

        public override string Description
        {
            get => base.Description + " salaire : " + salaire;
        }
    }
}
