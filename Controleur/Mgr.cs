using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banque.DAL;
using Banque.Modele;

namespace Banque.Controleur
{
    class Mgr
    {

        PersonneDao cd = new PersonneDao();
        CoursDao cld = new CoursDao();
        InscriptionDao insc = new InscriptionDao();
    
      

        public List<Cours> chargementClBD()
        {

            return(cld.getCours());

        }

        public List<Adherents> chargementCBD( /*Adherents cl*/)
        {

            return cd.getAdh();

        }

        public List<Inscription> chargementInscr(int id)
        {
            return insc.GetInscription(id);
        }
        public void payerInscription(int idAdh, int idCours)
        {
            insc.payerInscription(idAdh, idCours);
        }
        public void rembourserInscription(int idAdh, int idCours)
        {
            insc.rembourserInscription(idAdh, idCours);
        }
        public void annulerInscription(int idAdh, int idCours)
        {
            insc.annulerInscription(idAdh, idCours);
        }
        public void supprimerInscription(int idAdh, int idCours)
        {
            insc.supprimerInscription(idAdh, idCours);
        }

    }
}
