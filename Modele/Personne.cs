using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Modele
{
  public abstract class Personne
    {
        protected int id;
        protected string nom;
        protected string prenom;
        protected string tel;
        protected string adresse;
        protected string mail;
        public int solde = 0;


        public int getId { get => id; }



        public Personne(int i, string n, string p, string t, string a, string m)
        {
            this.id = i;
            this.nom = n;
            this.prenom = p;
            this.tel = t;
            this.adresse = a;
            this.mail = m;
        }

        public Personne()
        {

        }



        public virtual string Description
        {
            get => "Compte n° " + id + " " + " Nom :  " + nom + " Prenom :  " + prenom + " Tel :  " + tel + " Adresse :  " + adresse + " Mail :  " + mail + " " + " solde : " + solde + " €";
        }

        public int Solde { get => solde; set => solde = value; }

    }
}
