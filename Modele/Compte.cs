using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Modele
{
  public abstract class Compte
    {
        protected int num;
        protected Client proprio;
        public double solde = 0;


        public int Num { get => num; }



        public Compte(int n, Client c)
        {
            this.num = n;
            this.solde = 0;
            this.proprio = c;
        }



        public virtual string Description
        {
            get => "Compte n° " + num + " " + " Client :  " + proprio + " " + " solde : " + solde + " €";
        }

        public Client Propriétaire
        {
            get { return proprio; }
        }

        public double Solde { get => solde; }

        public void crediter(double mont)
        {
            solde = solde + mont;
        }

        public abstract void debiter(double mont);

    }
}
