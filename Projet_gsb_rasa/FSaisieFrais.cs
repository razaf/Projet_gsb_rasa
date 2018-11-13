using System;
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
    public partial class FSaisieFrais : Form
    {
        public FSaisieFrais()
        {
            InitializeComponent();
            string numVisiteur = Modele.GetUtilisateurConnecte().idVisiteur;
            string prenomVisiteur = Modele.GetUtilisateurConnecte().prenom;
            string nomVisiteur = Modele.GetUtilisateurConnecte().nom.ToUpper();
            lblNumVisiteur.Text =numVisiteur;
            lblNomVisiteur.Text = nomVisiteur;
            lblPrenomVisiteur.Text = prenomVisiteur;
        }

        private void btnAjoutFF_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblFraisForfaitaires_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
