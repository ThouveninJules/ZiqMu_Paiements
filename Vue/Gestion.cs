using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO ;
using System.Runtime.Serialization.Formatters.Binary ;
using Banque.Controleur;
using Banque.Modele;

namespace Banque
{

    [Serializable]
    public partial class Gestion : Form
    {

        Mgr monManager;

        public List<Cours> listCours = new List<Cours>();

       
        private List<Adherents> listAdh = new List<Adherents>();

        private List<Inscription> listInscr = new List<Inscription>();


        public Gestion()
        {
            InitializeComponent();
            monManager = new Mgr();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            listCours = monManager.chargementClBD();

            if (listCours.Count != 0) { rafraichirListBox(0); }

        }


        private void rafraichirListBox(int index)
        {
            try {

                listCours = monManager.chargementClBD();
                lBox.DataSource = null;
                lBox.DataSource = listCours;
                lBox.DisplayMember = "Description";
                lBox.SetSelected(index, true);
            }
            catch(Exception emp)
            {
                MessageBox.Show(emp.Message);
            }

        }

        private void rafraichirListBox1(int index)
        {
            try
            {
                int i = lBox.SelectedIndex;
                Cours selection = listCours[i];
                listInscr = monManager.chargementInscr(selection.Id);
                if (listInscr.Count > 0)
                {
                    lBox1.DataSource = null;
                    lBox1.DataSource = listInscr;
                    lBox1.DisplayMember = "Description";
                    lBox1.SetSelected(index, true);
                }
                else
                {
                    lBox1.DataSource = null;
                    lBox1.DisplayMember = "Description";
                }
            }
            catch (Exception emp)
            {
                MessageBox.Show(emp.Message);
            }

        }

        private void rafraichirListBox1_Comptes_Vides()
        {

            lBox1.DataSource = null;
            lBox1.DisplayMember = "Description";

        }

        private void lBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                int i = lBox.SelectedIndex;

                if (i != -1)
                {
                    Cours selection = listCours[i];

                    listInscr = monManager.chargementInscr(selection.Id);

                    if (listInscr.Count != 0) 
                    { 
                    Inscription inscrChrg = (Inscription)listInscr[0]; 
                    rafraichirListBox1(0); 
                    }
                    else { rafraichirListBox1_Comptes_Vides(); }


                }
        }

        private void btnPayer_Click(object sender, EventArgs e)
        {
            int i = lBox1.SelectedIndex;
            int j = lBox.SelectedIndex;
            if (i != -1)
            {
                Inscription selection = listInscr[i];
                monManager.payerInscription(selection.IdAdherent, selection.IdCours);
                rafraichirListBox(j);
                rafraichirListBox1(i);
            }
        }

        private void btnRembourser_Click(object sender, EventArgs e)
        {
            int i = lBox1.SelectedIndex;
            int j = lBox.SelectedIndex;
            if (i != -1)
            {
                Inscription selection = listInscr[i];
                monManager.rembourserInscription(selection.IdAdherent, selection.IdCours);
                rafraichirListBox(j);
                rafraichirListBox1(i);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            int i = lBox1.SelectedIndex;
            int j = lBox.SelectedIndex;
            if (i != -1)
            {
                Inscription selection = listInscr[i];
                monManager.annulerInscription(selection.IdAdherent, selection.IdCours);
                rafraichirListBox(j);
                rafraichirListBox1(i);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int i = lBox1.SelectedIndex;
            int j = lBox.SelectedIndex;
            if (i != -1)
            {
                Inscription selection = listInscr[i];
                monManager.supprimerInscription(selection.IdAdherent, selection.IdCours);
                rafraichirListBox(j);
                rafraichirListBox1(0);
            }
        }

        private void lBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                int i = lBox1.SelectedIndex;

                if (i != -1)
                {
                    Inscription selection = listInscr[i];
                    btnSupprimer.Enabled = true;
                    btnSupprimer.BackColor = Color.FromArgb(255, 128, 128);
                    if (selection.Annule == 1)
                    {
                        if (selection.Rembourse == 1)
                        {
                            btnRembourser.Enabled = false;
                            btnRembourser.BackColor = Color.Gray;
                        }
                        else
                        {
                            if (selection.Paye == 1)
                            {
                                btnRembourser.Enabled = true;
                                btnRembourser.BackColor = Color.FromArgb(128, 128, 255);
                            }
                            else
                            {
                                btnRembourser.Enabled = false;
                                btnRembourser.BackColor = Color.Gray;
                            }
                        }
                        btnPayer.Enabled = false;
                        btnPayer.BackColor = Color.Gray;
                        btnAnnuler.Enabled = false;
                        btnAnnuler.BackColor = Color.Gray;
                    }
                    else if (selection.Rembourse == 1)
                    {
                        btnPayer.Enabled = false;
                        btnPayer.BackColor = Color.Gray;
                        btnRembourser.Enabled = false;
                        btnRembourser.BackColor = Color.Gray;
                    }
                    else if (selection.Paye == 0)
                    {
                        btnAnnuler.Enabled = true;
                        btnAnnuler.BackColor = Color.FromArgb(255, 255, 128);
                        btnPayer.Enabled = true;
                        btnPayer.BackColor = Color.FromArgb(128, 255, 128);
                        btnRembourser.Enabled = false;
                        btnRembourser.BackColor = Color.Gray;
                    }
                    else
                    {
                        btnPayer.Enabled = false;
                        btnPayer.BackColor = Color.Gray;
                        btnAnnuler.Enabled = true;
                        btnAnnuler.BackColor = Color.FromArgb(255, 255, 128);
                        btnRembourser.Enabled = true;
                        btnRembourser.BackColor = Color.FromArgb(128, 128, 255);
                    }
                }

        }
    }
}
