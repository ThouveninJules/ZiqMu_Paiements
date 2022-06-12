using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Modele
{
    class Adherents : Personne
    {

        private int niveau;

        public Adherents(int i, string n, string p, string t, string a, string m, int lvl, int sld) : base(i, n, p, t, a, m)
        {
            this.niveau = lvl;
            this.solde = sld;

        }

        public Adherents()
        {

        }


        public int getNiveau()
        {
            return (this.niveau);
        }

        public void setNiveau(int newNiveau)
        {
            this.niveau = newNiveau;
        }

        public override string Description
        {
            get => base.Description + " - niveau : " + this.niveau;
        }

    }
}
