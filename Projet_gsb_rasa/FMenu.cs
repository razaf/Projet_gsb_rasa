﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_gsb_rasa
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void responsalbitésToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paramettreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visiteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void saisieDesFraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSaisieFrais FSF = new FSaisieFrais();
            FSF.ShowDialog();
        }

        private void listeVisiteurParSecteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblSecteur fsO;
            fsO = new lblSecteur();
            fsO.Show();
        }

        private void listeVisiteurParRegionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listevisiteurregion fs1;
            fs1 = new listevisiteurregion();
            fs1.Show();
        }

        private void visualiserProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationProfil fsO;
            fsO = new InformationProfil();
            fsO.Show();
        }

        private void modifierProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifProfil fsO;
            fsO = new ModifProfil();
            fsO.Show();
        }
    }
}
