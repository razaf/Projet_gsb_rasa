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
    public partial class InformationProfil : Form
    {
        public InformationProfil()
        {
            
            InitializeComponent();
            string numVisiteur = Modele.GetUtilisateurConnecte().idVisiteur;
            string prenomVisiteur = Modele.GetUtilisateurConnecte().prenom;
            string nomVisiteur = Modele.GetUtilisateurConnecte().nom.ToUpper();
            string rueVisiteur= Modele.GetUtilisateurConnecte().rue.ToUpper();
            string CpVisiteur = Modele.GetUtilisateurConnecte().cp.ToUpper();
            string VilleVisiteur = Modele.GetUtilisateurConnecte().ville.ToUpper();
            string laboVisiteur = Modele.GetUtilisateurConnecte().Laboratoire.nomLabo.ToUpper();
            lblNumVisiteur.Text = numVisiteur;
            lblNomVisiteur.Text = nomVisiteur;
            lblPrenomVisiteur.Text = prenomVisiteur;
            lblRueVisiteur.Text = rueVisiteur;
            lblCpVisiteur.Text = CpVisiteur;
            lblVilleVisiteur.Text = VilleVisiteur;
            lblLaboratoire.Text = laboVisiteur;





        }

        private void InformationProfil_Load(object sender, EventArgs e)
        {

        }

        private void lblVisiteur_Click(object sender, EventArgs e)
        {

        }

        private void lblLaboratoire_Click(object sender, EventArgs e)
        {

        }

        private void bpmodif_Click(object sender, EventArgs e)
        {
            ModifProfil fsO;
            fsO = new ModifProfil();
            fsO.Show();
        }
    }
}
