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
            /*if (fermeture) return;
            bsVisiteur.DataSource = ((Secteur)bsSource.Current).Region.ToList().OrderBy(x => x.libRegion).ThenBy(x => x.Visiteur.nom);
            dgvVisiteur.DataSource = bsVisiteur;
            for (int i = 0; i < dgvVisiteur.ColumnCount; i++)
            {
                dgvVisiteur.Columns[i].Visible = false;
            }
            dgvVisiteur.Columns["libRegion"].Visible = true;
            dgvVisiteur.Columns["nom"].Visible = true;
            dgvVisiteur.Columns["rue"].Visible = true;
            dgvVisiteur.Columns["cp"].Visible = true;
            dgvVisiteur.Columns["ville"].Visible = true;
            dgvVisiteur.Columns["libRegion"].HeaderText = "REGION";
            dgvVisiteur.Columns["libRegion"].DisplayIndex = 0;

            dgvVisiteur.Columns["nom"].HeaderText = "NOM";
            dgvVisiteur.Columns["nom"].DisplayIndex = 1;
            dgvVisiteur.Columns["rue"].HeaderText = "RUE";
            dgvVisiteur.Columns["rue"].DisplayIndex = 2;
            dgvVisiteur.Columns["cp"].HeaderText = "CODE POSTAL";
            dgvVisiteur.Columns["cp"].DisplayIndex = 3;
            dgvVisiteur.Columns["ville"].HeaderText = "VILLE";
            dgvVisiteur.Columns["ville"].DisplayIndex = 4;
            */
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            bsVisiteur.DataSource = Modele.RegionParSecteur(int.Parse(cboSecteur.SelectedValue.ToString()));
            dgvVisiteur.DataSource = bsVisiteur;
            dgvVisiteur.Columns[0].HeaderText = "REGION";
            dgvVisiteur.Columns[1].HeaderText = "NOM";
            dgvVisiteur.Columns[2].HeaderText = "RUE";
            dgvVisiteur.Columns[3].HeaderText = "CODE POSTAL";
            dgvVisiteur.Columns[4].HeaderText = "VILLE";

        }
        private void chargedgv()
        {
            dgvVisiteur.DataSource = bsVisiteur;
            dgvVisiteur.Columns[0].HeaderText = "NOM";
            dgvVisiteur.Columns[1].HeaderText = "PRENOM";
            dgvVisiteur.Columns[2].HeaderText = "RUE";
            dgvVisiteur.Columns[3].HeaderText = "CODE POSTAL";
            dgvVisiteur.Columns[4].HeaderText = "VILLE";
            dgvVisiteur.Columns[5].HeaderText = "DATE EMBAUCHE";
            dgvVisiteur.Columns[6].HeaderText = "";
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
               bsSource.DataSource = ((Region)bsSource.Current).libRegion.ToList();
                dgvResponsable.DataSource = bsResponsable;
                for (int i = 0; i < dgvResponsable.ColumnCount; i++)
                {
                    dgvResponsable.Columns[i].Visible = false;
                }
                //x.Visiteur.nom, x.Visiteur.prenom, x.Visiteur.rue, x.Visiteur.cp, x.Visiteur.ville
                dgvResponsable.Columns["nom"].Visible = true;
                dgvResponsable.Columns["prenom"].Visible = true;
                dgvResponsable.Columns["rue"].Visible = true;
                dgvResponsable.Columns["titreOeuvre"].HeaderText = "NOM";
                dgvResponsable.Columns["titreOeuvre"].DisplayIndex = 0;
                dgvResponsable.Columns["anComposition"].HeaderText = "Prenom";
                dgvResponsable.Columns["anComposition"].DisplayIndex = 1;
                
               
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
