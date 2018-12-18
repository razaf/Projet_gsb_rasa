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
    public partial class ModifProfil : Form
    {
        public ModifProfil()
        {
         
            InitializeComponent();
            string numVisiteur = Modele.GetUtilisateurConnecte().idVisiteur;
            string prenomVisiteur = Modele.GetUtilisateurConnecte().prenom;
            string nomVisiteur = Modele.GetUtilisateurConnecte().nom.ToUpper();
            string rueVisiteur = Modele.GetUtilisateurConnecte().rue.ToUpper();
            string CpVisiteur = Modele.GetUtilisateurConnecte().cp.ToUpper();
            string VilleVisiteur = Modele.GetUtilisateurConnecte().ville.ToUpper();
            string laboVisiteur = Modele.GetUtilisateurConnecte().Laboratoire.nomLabo.ToUpper();
            txtNom.Text = nomVisiteur;
            txtprenom.Text = prenomVisiteur;
            txtrue.Text = rueVisiteur;
            txtVille.Text = VilleVisiteur;
            txtCp.Text = CpVisiteur;





        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModifProfil_Load(object sender, EventArgs e)
        {

        }

        private void bpmodifmdp_Click(object sender, EventArgs e)
        {
            modifmdp fsO;
            fsO = new modifmdp();
            fsO.Show();
        }
    }
}
