using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Modele
{
    class CompteEpargne : Compte
    {

        private double taux = 0;

        public CompteEpargne(int n, Client c) : base(n, c)
        {

        }


        public override void debiter(double mont)
        {
            if (solde - mont < 0)
            {
                throw (new Exception("Montant impossible à débiter !"));
            }
            else
            {
                solde = solde - mont;
            }
        }

        public void setTaux(double value)
        {
            if (value > 0)
            {
                taux = value;

            }

            else
            {
                throw (new Exception("Le taux entré n'est pas valide !!"));

            }

        }

        public double Taux
        {
            get => taux;

            set
            {
                if (value >= 0) { taux = value; }

                else
                {

                    throw (new Exception("Le taux entré n'est pas valide !!"));

                }


            }
        }

        public override string Description
        {
            get => base.Description + " taux : " + taux;
        }
    }
}
