using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Modele
{
    class CompteCourant : Compte
    {

        private double decouv = 0;

        public CompteCourant(int n, Client c) : base(n, c)
        {


        }


        public bool setDecouv(double value)
        {
            bool res = false;


            if (this.solde > -value)
            {
                decouv = value;
                res = true;

            }

            else
            {
                throw (new Exception("Le découvert entré n'est pas valide !!"));

            }
            return (res);

        }

        public double Decouv
        {
            get => decouv;

            set
            {
                if (this.solde >= (-value)) { decouv = value; }

                else
                {

                    throw (new Exception("Le découvert entré n'est pas valide !!"));

                }


            }
        }
        public override void debiter(double mont)
        {
            if (solde - mont < -decouv)
            {
                throw (new Exception("Montant impossible à débiter !"));
            }
            else
            {
                solde = solde - mont;
            }
        }

        public override string Description
        {
            get => base.Description + " - decouvert : " + this.decouv;
        }

    }
}
