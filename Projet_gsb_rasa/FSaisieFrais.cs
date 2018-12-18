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
        private double coef;
        private double montantU;
        private int qte;
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
        private void FSaisieFrais_Load(object sender, EventArgs e)
        {
            cbxRegion.ValueMember = "idRegion";//permet de stocker l'identifiant
            cbxRegion.DisplayMember = "libRegion";

            bscbxRegion.DataSource = Modele.ListeRegion();
            cbxRegion.DataSource = bscbxRegion;

            cbxLib.ValueMember = "id";//permet de stocker l'identifiant
            cbxLib.DisplayMember = "libelle";

            bscbxLib.DataSource = Modele.getLibFraisForfait();
            cbxLib.DataSource = bscbxLib;

            bsDgvLesFraisForfait.DataSource = Modele.getLesFraisForfait();
            dgvFraisForfait.DataSource = bsDgvLesFraisForfait;

            txtQteFF.Text = "1";
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

        private void lblNomVisiteur_Click(object sender, EventArgs e)
        {

        }

        private void bscbxLib_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cbxLib_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.montantU = Modele.getMontantUnitaire(cbxLib.SelectedValue.ToString());
            rafraichir();
        }

        private void cbxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.coef = Modele.getCoef(int.Parse(cbxRegion.SelectedValue.ToString()));
            rafraichir();
        }
        private void rafraichir()
        {
            double montant = coef * montantU * qte;
            lblMontantUFF.Text = this.montantU.ToString();
            lblMontantFF.Text = montant.ToString();
        }

        private void txtQteFF_TextChanged(object sender, EventArgs e)
        {
            this.qte = int.Parse(txtQteFF.Text);
            rafraichir();
        }

        private void btnAjoutFraisForfait_Click(object sender, EventArgs e)
        {
            bool x = Modele.AjoutLigneFraisForfait(dateTimePicker1.Value.Month.ToString(), int.Parse(dateTimePicker1.Value.Year.ToString()), cbxLib.SelectedValue.ToString(), int.Parse(txtQteFF.Text), double.Parse(lblMontantFF.Text));
            if (x == false)
            {
                MessageBox.Show("erreur");
            }
        }
    }
}
