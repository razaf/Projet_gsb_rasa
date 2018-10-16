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
        public static void ThreadProc()
        {
            /*Application.Run(new FMenu());*/
        }
        private void test()
        {
            bool verif = false;
           
            string message1;
            string message2;
            string message = "Erreur de saisie:\n\t" ;
            if (textBoxID.Text.Trim().Length == 0)
            {

                message += "\u25C9 id vide\n\t ";
                verif = true;
               
            }
            if (textBoxMdp.Text.Trim().Length == 0)
            {
                
                 message += "\u25C9 mdp vide\n\t ";
                verif = true;
               
            }

            if (verif == true)
            {
                MessageBox.Show(message);
            }

            

        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            test();
        }

        private void pictureBoxLogoGSB_Click(object sender, EventArgs e)
        {

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
