using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Banque.Modele;

namespace Banque.DAL
{
    class PersonneDao 
    {


        private  ConnexionSql maConnexionSql;


        private  MySqlCommand Ocom;


        public  List<Personne> getComptes(Personne p)
        {

            List<Personne> lc = new List<Personne>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);

                maConnexionSql.openConnection();



                Ocom = maConnexionSql.reqExec("Select p.id,p.nom,p.prenom,p.tel,p.adresse,p.mail,a.niveau,p.solde from personne p, adherents a where p.id = a.id and p.id = " + p.getId);

                MySqlDataReader reader = Ocom.ExecuteReader();

        

                while (reader.Read())
                {

                    int id = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);
                    string prenom = (string)reader.GetValue(2);
                    string tel = (string)reader.GetValue(3);
                    string adresse = (string)reader.GetValue(4);
                    string mail = (string)reader.GetValue(5);
                    int niveau = (int)reader.GetValue(6);
                    int solde = (int)reader.GetValue(7);






                    Personne peAdh = new Adherents(id, nom, prenom, tel, adresse, mail, niveau, solde);

                    lc.Add(peAdh);


                }

                reader.Close();

            

                Ocom = maConnexionSql.reqExec("Select p.id,p.nom,p.prenom,p.tel,p.adresse,p.mail,pr.salaire, p.solde from personne p, professeurs pr where p.id = pr.id and p.id = " + p.getId);

                reader = Ocom.ExecuteReader();




                while (reader.Read())
                {

                    int id = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);
                    string prenom = (string)reader.GetValue(2);
                    string tel = (string)reader.GetValue(3);
                    string adresse = (string)reader.GetValue(4);
                    string mail = (string)reader.GetValue(5);
                    int salaire = (int)reader.GetValue(6);
                    int solde = (int)reader.GetValue(7);



                    Personne peProf = new Professeurs(id, nom, prenom, tel, adresse, mail, salaire);



                    lc.Add(peProf);

                  

                }

                reader.Close();

            }


            catch (Exception emp)
            {

                MessageBox.Show(emp.Message);
                throw (new Exception("Select p.id,p.nom,p.prenom,p.tel,p.adresse,p.mail,pr.salaire, p.solde from personne p, professeurs pr where p.id = pr.id and p.id = " + p.getId));

            }

            return (lc);

        }

        public List<Adherents> getAdh()
        {

            List<Adherents> lc = new List<Adherents>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);

                maConnexionSql.openConnection();



                Ocom = maConnexionSql.reqExec("Select p.id,p.nom,p.prenom,p.tel,p.adresse,p.mail,a.niveau,p.solde from personne p, adherents a where p.id = a.id");

                MySqlDataReader reader = Ocom.ExecuteReader();



                while (reader.Read())
                {

                    int id = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);
                    string prenom = (string)reader.GetValue(2);
                    string tel = (string)reader.GetValue(3);
                    string adresse = (string)reader.GetValue(4);
                    string mail = (string)reader.GetValue(5);
                    int niveau = (int)reader.GetValue(6);
                    int solde = (int)reader.GetValue(7);






                    Adherents peAdh = new Adherents(id, nom, prenom, tel, adresse, mail, niveau, solde);

                    lc.Add(peAdh);


                }

                reader.Close();
            }
            catch(Exception emp)
            {
                throw (emp);
            }
            return (lc);
        }


        public Adherents getunAdh(int unId)
        {

            Adherents unAdh = new Adherents();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);

                maConnexionSql.openConnection();



                Ocom = maConnexionSql.reqExec("Select p.id, p.nom, p.prenom, p.tel, p.adresse, p.mail, p.solde, a.niveau from personne p, adherents a where p.id = a.id and p.id = " + unId);

                MySqlDataReader reader = Ocom.ExecuteReader();



                while (reader.Read())
                {

                    int id = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);
                    string prenom = (string)reader.GetValue(2);
                    string tel = (string)reader.GetValue(3);
                    string adresse = (string)reader.GetValue(4);
                    string mail = (string)reader.GetValue(5);
                    int solde = (int)reader.GetValue(6);
                    int niveau = (int)reader.GetValue(7);


                    unAdh = new Adherents(id, nom, prenom, tel, adresse, mail, niveau, solde);

                }

                reader.Close();
            }
            catch (Exception emp)
            {
                throw (emp);
            }
            return (unAdh);
        }

        public void updateSolde(Personne p)
        {

            try
            {
                

                Ocom = maConnexionSql.reqExec("Update personne p set p.solde ="+ p.Solde +" where p.id = " + p.getId);
                Ocom.ExecuteNonQuery();

            }

            catch (Exception emp)
            {

                MessageBox.Show(emp.Message);
                throw (new Exception("Update personne p set p.solde =" + p.Solde + " where p.id = " + p.getId));
            }
        }




    }
}
