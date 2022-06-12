using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Modele
{
    class Inscription
    {
        private int idAdherent;
        private int idCours;
        private int paye;
        private string nom;
        private string prenom;
        private int solde;
        private int rembourse;
        private int annule;

        public Inscription(int idAdherent, int idCours, int paye, string nom, string prenom, int solde, int rembourse, int annule)
        {
            this.idAdherent = idAdherent;
            this.idCours = idCours;
            this.paye = paye;
            this.nom = nom;
            this.prenom = prenom;
            this.solde = solde;
            this.rembourse = rembourse;
            this.annule = annule;
        }

        public Inscription()
        {

        }


        public int IdAdherent { get => idAdherent; }
        public int IdCours { get => idCours; set => idCours = value; }
        public int Paye { get => paye; set => paye = value; }
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public int Solde { get => solde; }
        public int Rembourse { get => rembourse; set => rembourse = value; }
        public int Annule { get => annule; set => annule = value; }

        public override string ToString()

        {

            if (this.annule == 1)
            {
                if (this.paye == 1)
                {
                    if (this.rembourse == 1)
                    {
                        return ("Adherent n° : " + this.idAdherent + " Nom : " + this.nom + " Prenom : " + this.prenom + " Solde : " + this.solde + " | Statut payement : Payé | Statut remboursement : Remboursé | Statut annulation : Annulé");
                    }
                    else
                    {
                        return ("Adherent n° : " + this.idAdherent + " Nom : " + this.nom + " Prenom : " + this.prenom + " Solde : " + this.solde + " | Statut payement : Payé | Statut remboursement : Non remboursé | Statut annulation : Annulé");
                    }
                }
                else
                {
                    return ("Adherent n° : " + this.idAdherent + " Nom : " + this.nom + " Prenom : " + this.prenom + " Solde : " + this.solde + " | Statut payement : Non payé | Statut remboursement : Non remboursé | Statut annulation : Annulé");
                }
            }
            else if (this.rembourse == 1)
            {
                return ("Adherent n° : " + this.idAdherent + " Nom : " + this.nom + " Prenom : " + this.prenom + " Solde : " + this.solde + " | Statut payement : Payé | Statut remboursement : Remboursé | Statut annulation : Non annulé");
            }
            else if (this.paye == 0)
            {
                return ("Adherent n° : " + this.idAdherent + " Nom : " + this.nom + " Prenom : " + this.prenom + " Solde : " + this.solde + " | Statut payement : Non payé | Statut remboursement : Non remboursé | Statut annulation : Non annulé");
            }
            else
            {
                return ("Adherent n° : " + this.idAdherent + " Nom : " + this.nom + " Prenom : " + this.prenom + " Solde : " + this.solde + " | Statut payement : Payé | Statut remboursement : Non remboursé | Statut annulation : Non annulé");
            }
        }
    }
}
