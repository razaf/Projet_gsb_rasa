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
        {/*
            if (fermeture) return;
            bsVisiteur.DataSource = ((Secteur)bsSource.Current).Region.ToList().OrderBy(x => x.libRegion).ThenBy(x =>  x.Visiteur.nom, x.Visiteur.rue, x.Visiteur.cp, x.Visiteur.ville);
        */}
        
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
    }
}
