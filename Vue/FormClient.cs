using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Banque.Modele;

namespace Banque
{
    public partial class FormClient : Form
    {

        private Cours c;
        
        public FormClient(Cours unCours)
        {
            InitializeComponent();

            this.c = unCours;
        }

        public FormClient()
        {
            InitializeComponent();

          
        }



        private void FormClient_Load(object sender, EventArgs e)
        {

            tbNum.Text = c.Id.ToString();
            tbNom.Text = c.IdProfesseur.ToString();
            tbPrenom.Text = c.IdInstrument.ToString();
            tbAdresse.Text = c.Jourheure.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           //c.Id = tbAdresse.Text;
            //c.Nom = tbNom.Text;
            this.Close();
        }

        private void tbAdresse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
