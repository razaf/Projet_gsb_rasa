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
        public lblSecteur()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            bsVisiteur.DataSource = Modele.RegionParSecteur(int.Parse(cboSecteur.SelectedValue.ToString()));
            dgvVisiteur.DataSource = bsVisiteur;
            dgvVisiteur.Columns[0].HeaderText = "REGION";
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
             /*   bsSource.DataSource = ((Region)bsSource.Current).libRegion.ToList();
                dgvResponsable.DataSource = bsResponsable;
                for (int i = 0; i < dgvResponsable.ColumnCount; i++)
                {
                    dgvResponsable.Columns[i].Visible = false;
                }
                dgvResponsable.Columns["titreOeuvre"].Visible = true;
                dgvResponsable.Columns["anComposition"].Visible = true;
                dgvResponsable.Columns["titreOeuvre"].HeaderText = "Oeuvre";
                dgvResponsable.Columns["titreOeuvre"].DisplayIndex = 0;
                dgvResponsable.Columns["anComposition"].HeaderText = "Composition";
                dgvOeuvre.Columns["anComposition"].DisplayIndex = 1;
                */
               
            }
        }
    }
}
