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
    public partial class lblSecteur : Form
    {
        private bool fermeture = false;
        public lblSecteur()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
             if (fermeture) return;
            bsVisiteur.DataSource = ((Secteur)bsSource.Current).Visiteur;
            bsVisiteur.DataSource = ((Secteur)bsSource.Current).Region;
            bsVisiteurS.DataSource = ((Region)bsVisiteur.Current).Visiteur1;
            

            dgvVisiteur.DataSource = bsVisiteurS;
            
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
            txt_nom_respon.Text = ((Secteur)bsSource.Current).Visiteur.nom.ToString();
            txt_prenom_respon.Text = ((Secteur)bsSource.Current).Visiteur.prenom.ToString();
            txt_rue_resp.Text = ((Secteur)bsSource.Current).Visiteur.rue.ToString();
            txt_cp_res.Text = ((Secteur)bsSource.Current).Visiteur.cp.ToString();
            txt_ville_resp.Text = ((Secteur)bsSource.Current).Visiteur.ville.ToString();






        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* bsVisiteur.DataSource = Modele.VisiteurParSecteur(int.Parse(cboSecteur.SelectedValue.ToString()));
            dgvVisiteur.DataSource = bsVisiteur;
            dgvVisiteur.Columns[0].HeaderText = "NUM";
            dgvVisiteur.Columns[1].HeaderText = "NOM";
            dgvVisiteur.Columns[2].HeaderText = "RUE";
            dgvVisiteur.Columns[3].HeaderText = "CODE POSTAL";
            dgvVisiteur.Columns[4].HeaderText = "VILLE";*/
            
        }
        
       
    
    private void lblSecteur_Load(object sender, EventArgs e)
        {
            cboSecteur.ValueMember = "idSecteur";//permet de stocker l'identifiant
            cboSecteur.DisplayMember = "libSecteur";
            bsSource.DataSource = Modele.ListSecteur();
            cboSecteur.DataSource = bsSource;
        }

        private void dgvVisiteur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {
            {
              
                
               
            }
        }

        private void dgvResponsable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bs_Visiteur_CurrentChanged(object sender, EventArgs e)
        {
          // bsVisiteur.DataSource=(())
        }
    }
}
