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
    public partial class FConnexion : Form
    {
        public FConnexion()
        {
            InitializeComponent();
        }

        private void labelIdentifiez_Click(object sender, EventArgs e)
        {
            

        }

        private void FConnexion_Load(object sender, EventArgs e)
        {
            labelIdentifiez.Parent = pictureBoxLogoGSB;
            labelIdentifiez.BackColor = Color.Transparent;
          /*  System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
            this.Close();*/

        }
        

        private void VerificationContenu()
        {
            bool erreur = false;
            
            
            string message = "Erreur de saisie:\n\t" ;
            if (txtID.Text.Trim().Length == 0)
            {

                message += "\u25C9 id vide\n\t ";
                erreur = true;
               
            }
            if (txtMDP.Text.Trim().Length == 0)
            {
                
                 message += "\u25C9 mdp vide\n\t ";
                erreur = true;
               
            }
            
            if (erreur == true)
            {
                MessageBox.Show(message);
            }

            

        }
        
        
        private void buttonOk_Click(object sender, EventArgs e)
        {
            //VerificationContenu();
            string id = txtID.Text.ToString();
            string mdp = Modele.GetMd5Hash(txtMDP.Text.ToString()).ToUpper();
            if (Modele.VerificationID(id)==true)
            {
                if(Modele.VerificationMDP(id, mdp)==true)
                {
                    MessageBox.Show("Vous etes identifiez");
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                    t.Start();
                    this.Close();
                    


                }
                else
                {
                    MessageBox.Show("mdp mauvais");
                }
            }
            else
            {
                MessageBox.Show("id mauvais");
            }
            

        }

        private void pictureBoxLogoGSB_Click(object sender, EventArgs e)
        {

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
           /* lblSecteur fsO;
            fsO = new lblSecteur();
            fsO.Show();*/
            this.Close();
        }


        public static void ThreadProc()
        {
            Application.Run(new salarie());
        }


    }
}
