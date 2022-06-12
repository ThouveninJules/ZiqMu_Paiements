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
    class CoursDao 
    {
      

        private  ConnexionSql maConnexionSql;


        private   MySqlCommand Ocom;



        public  Cours getCours(int unId)
        {

            try
            {
                Cours c = new Cours();

                

               maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select c.id, c.jourheure, c.nbPlace, p.nom, p.prenom, i.nom, c.idInstrument, c.idProfesseur, pr.salaire from cours c, personne p, instrument i, professeurs pr where c.idProfesseur = p.id and c.idInstrument = i.id and pr.id = p.id and c.id = "+unId);


                MySqlDataReader reader1 = Ocom.ExecuteReader();


                while (reader1.Read())
                {

                    int id = (int)reader1.GetValue(0);
                    string jourheure = (string)reader1.GetValue(1);
                    int nbPlace = (int)reader1.GetValue(2);
                    string nom = (string)reader1.GetValue(3);
                    string prenom = (string)reader1.GetValue(4);
                    string instrument = (string)reader1.GetValue(5);
                    int idInstrument = (int)reader1.GetValue(6);
                    int idProfesseur = (int)reader1.GetValue(7);
                    int prix = (int)reader1.GetValue(8);

                    c = new Cours(id, jourheure, nbPlace, nom, prenom, instrument, idProfesseur, idInstrument, prix);


                }



                reader1.Close();

                maConnexionSql.closeConnection();


                return (c);

            }

            catch (Exception emp)
            {
                MessageBox.Show(emp.Message);
                throw (new Exception("Select * from cours where id = " + unId));
            }
        }


        public List<Cours> getCours()
        {

            List<Cours> lc = new List<Cours>();

            try
            {
                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);

                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("Select c.id, c.jourheure, c.nbPlace, p.nom, p.prenom, i.nom, c.idInstrument, c.idProfesseur, pr.salaire from cours c, personne p, instrument i, professeurs pr where c.idProfesseur = p.id and c.idInstrument = i.id and pr.id = p.id;");

                

                MySqlDataReader reader = Ocom.ExecuteReader();

                Cours c;



                while (reader.Read())
                {

                    int id = (int)reader.GetValue(0);
                    string jourheure = (string)reader.GetValue(1);
                    int nbPlace = (int)reader.GetValue(2);
                    string nom = (string)reader.GetValue(3);
                    string prenom = (string)reader.GetValue(4);
                    string instrument = (string)reader.GetValue(5);
                    int idInstrument = (int)reader.GetValue(6);
                    int idProfesseur = (int)reader.GetValue(7);
                    int prix = (int)reader.GetValue(8);

                    c = new Cours(id, jourheure, nbPlace, nom, prenom, instrument, idProfesseur, idInstrument, prix);

                    lc.Add(c);

                }



                reader.Close();

                maConnexionSql.closeConnection();

                
            }
           
               
            

            catch (Exception emp)
            {

                MessageBox.Show(emp.Message+"\nLa liste des cours n'est pas récupérée");


            }
            
    return (lc);
        }

    }
}
