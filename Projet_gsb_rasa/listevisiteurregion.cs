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
    public partial class listevisiteurregion : Form
    {
        private bool fermeture = false;
        public listevisiteurregion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboregion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listevisiteurregion_Load(object sender, EventArgs e)
        {
            cboregion.ValueMember = "idRegion";//permet de stocker l'identifiant
            cboregion.DisplayMember = "libRegion";
            bsSource.DataSource = Modele.ListeRegion();
            cboregion.DataSource = bsSource;
        }

        private void bs_source_currentChange(object sender, EventArgs e)
        {
            if (fermeture) return;
            bsVisiteur.DataSource = ((Region)bsSource.Current).Visiteur;
            bsVisiteurS.DataSource = ((Region)bsSource.Current).Visiteur1;
            dgvVisiteur.DataSource = bsVisiteurS;
            
            {

            }
             for (int i = 0; i < dgvVisiteur.ColumnCount; i++)
             {
                 dgvVisiteur.Columns[i].Visible = false;
             }
             dgvVisiteur.Columns["idVisiteur"].Visible = true;
             dgvVisiteur.Columns["nom"].Visible = true;
             dgvVisiteur.Columns["rue"].Visible = true;
             dgvVisiteur.Columns["cp"].Visible = true;
             dgvVisiteur.Columns["ville"].Visible = true;

             dgvVisiteur.Columns["idVisiteur"].HeaderText = "NUM";
             dgvVisiteur.Columns["idVisiteur"].DisplayIndex = 0;

             dgvVisiteur.Columns["nom"].HeaderText = "NOM";
             dgvVisiteur.Columns["nom"].DisplayIndex = 1;
             dgvVisiteur.Columns["rue"].HeaderText = "RUE";
             dgvVisiteur.Columns["rue"].DisplayIndex = 2;
             dgvVisiteur.Columns["cp"].HeaderText = "CODE POSTAL";
             dgvVisiteur.Columns["cp"].DisplayIndex = 3;
             dgvVisiteur.Columns["ville"].HeaderText = "VILLE";
             dgvVisiteur.Columns["ville"].DisplayIndex = 4;

            txt_nom_respon.Text = ((Region)bsSource.Current).Visiteur.nom.ToString();
            txt_prenom_respon.Text = ((Region)bsSource.Current).Visiteur.prenom.ToString();
            txt_rue_resp.Text = ((Region)bsSource.Current).Visiteur.rue.ToString();
            txt_cp_res.Text = ((Region)bsSource.Current).Visiteur.cp.ToString();
            txt_ville_resp.Text = ((Region)bsSource.Current).Visiteur.ville.ToString();





        }

        private void bsVisiteur_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
