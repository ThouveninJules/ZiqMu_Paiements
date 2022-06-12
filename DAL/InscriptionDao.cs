using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Banque.Modele;
namespace Banque.DAL
{
    class InscriptionDao
    {

        private ConnexionSql maConnexionSql;


        private MySqlCommand Ocom;

        private PersonneDao persDao = new PersonneDao();

        private CoursDao coursDao = new CoursDao();

        public List<Inscription> GetInscription(int id)
        {
            List<Inscription> listInscriptions = new List<Inscription>();
            try
            {

                Inscription uneInscription = new Inscription();

                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select i.idAdherent, i.idCours, i.paye, p.nom, p.prenom, p.solde, i.rembourse, i.annule from inscription i, adherents a, personne p where a.id = i.idAdherent and p.id = a.id and idCours = " + id);

                MySqlDataReader reader1 = Ocom.ExecuteReader();


                while (reader1.Read())
                {

                    int idAdherent = (int)reader1.GetValue(0);
                    int idCours = (int)reader1.GetValue(1);
                    int paye = (int)reader1.GetValue(2);
                    string nom = (string)reader1.GetValue(3);
                    string prenom = (string)reader1.GetValue(4);
                    int solde = (int)reader1.GetValue(5);
                    int rembourse = (int)reader1.GetValue(6);
                    int annule = (int)reader1.GetValue(7);

                    uneInscription = new Inscription(idAdherent, idCours, paye, nom, prenom, solde, rembourse, annule);

                    listInscriptions.Add(uneInscription);

                }



                reader1.Close();

                maConnexionSql.closeConnection();


                return(listInscriptions);
            }
            catch (Exception emp)
            {
                MessageBox.Show(emp.Message+"\nL'inscription n'a pas été récupérée\n" + "Select i.idAdherent, i.idCours, i.paye, p.nom, p.prenom, p.solde from inscription i, adherents a, personne p where a.id = i.idAdherent and p.id = a.id and idCours = " + id);
                return (listInscriptions);
            }
        }

        public void payerInscription(int idAdh, int idCours)
        {
            Adherents unAdh = persDao.getunAdh(idAdh);
            Cours unCours = coursDao.getCours(idCours);
            int montant = unAdh.Solde - unCours.Prix;
            if (montant >= 0)
            {
                try
                {
                    maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                    maConnexionSql.openConnection();

                    Ocom = maConnexionSql.reqExec("Update inscription i set i.paye = 1 where idAdherent = " + idAdh + " and idCours = " + idCours + "; Update personne a set a.solde = " + montant + " where a.id = " + idAdh + ";");
                    Ocom.ExecuteNonQuery();


                    maConnexionSql.closeConnection();

                }

                catch (Exception emp)
                {
                    MessageBox.Show(emp.Message);
                    throw (new Exception("Update inscription i set i.paye = 1 where idAdherent = " + idAdh + " and idCours = " + idCours + "; Update personne a set a.solde = " + montant + " where a.id = " + idAdh + ";"));
                }
            }
            else
            {
                MessageBox.Show("Solde insuffisant.");
            }
        }

        public void rembourserInscription(int idAdh, int idCours)
        {
            Adherents unAdh = persDao.getunAdh(idAdh);
            Cours unCours = coursDao.getCours(idCours);
            int montant = unAdh.Solde + unCours.Prix;
            try
            {
                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("Update inscription i set i.rembourse = 1 where idAdherent = " + idAdh + " and idCours = " + idCours + "; Update personne a set a.solde = " + montant + " where a.id = " + idAdh + ";");
                Ocom.ExecuteNonQuery();


                maConnexionSql.closeConnection();

            }

            catch (Exception emp)
            {
                MessageBox.Show(emp.Message);
                throw (new Exception("Update inscription i set i.rembourse= 1 where idAdherent = " + idAdh + " and idCours = " + idCours + "; Update adherent a set a.solde = " + montant + " where a.id = " + idAdh + ";"));
            }
        }

        public void annulerInscription(int idAdh, int idCours)
        {
            Adherents unAdh = persDao.getunAdh(idAdh);
            Cours unCours = coursDao.getCours(idCours);
            try
            {
                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("Update inscription i set i.annule = 1 where idAdherent = " + idAdh + " and idCours = " + idCours + ";");
                Ocom.ExecuteNonQuery();


                maConnexionSql.closeConnection();

            }

            catch (Exception emp)
            {
                MessageBox.Show(emp.Message);
                throw (new Exception("Update inscription i set i.isannule = 1 where idAdherent = " + idAdh + " and idCours = " + idCours + ";"));
            }
        }
        public void supprimerInscription(int idAdh, int idCours)
        {
            Adherents unAdh = persDao.getunAdh(idAdh);
            Cours unCours = coursDao.getCours(idCours);
            try
            {
                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("Delete from inscription where idAdherent = " + idAdh + " and idCours = " + idCours + ";");
                Ocom.ExecuteNonQuery();


                maConnexionSql.closeConnection();

            }

            catch (Exception emp)
            {
                MessageBox.Show(emp.Message);
                throw (new Exception("Delete from inscription i where idAdherent = " + idAdh + " and idCours = " + idCours + ";"));
            }
        }



    }
}
