using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Modele
{
   public class Cours
    {
        private int id;
        private string jourheure;
        private int nbPlace;
        private string nom;
        private string prenom;
        private string instrument;
        private int idProfesseur;
        private int idInstrument;
        private int prix;

        public Cours(int id, string jourheure, int nbPlace, string nom, string prenom, string instrument, int idProfesseur, int idInstrument, int prix)
        {
            this.id = id;
            this.jourheure = jourheure;
            this.nbPlace = nbPlace;
            this.nom = nom;
            this.prenom = prenom;
            this.instrument = instrument;
            this.IdProfesseur = idProfesseur;
            this.idInstrument = idInstrument;
            this.prix = prix;
        }

        public Cours()
        {
           
        }




        public int Id { get => id;}
        public string Jourheure { get => jourheure; set => jourheure = value; }
        public int NbPlace { get => nbPlace; set => nbPlace = value; }
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public string Instrument { get => instrument; }
        public int IdProfesseur { get => idProfesseur; set => idProfesseur = value; }
        public int IdInstrument { get => idInstrument; }
        public int Prix { get => prix; }


        public override string ToString()

        {
            if (this.nbPlace == 1)
            {
                return ("Cours n° : " + this.id + ", le : " + this.jourheure + ", pour : " + this.nbPlace + " personne, par : " + this.prenom + " " + this.nom + ", pour : " + this.instrument);
            }
            else
            {
                return ("Cours n° : " + this.id + ", le : " + this.jourheure + ", pour : " + this.nbPlace + " personnes, par : " + this.prenom + " " + this.nom + ", pour : " + this.instrument);
            }
        }



    }
}
