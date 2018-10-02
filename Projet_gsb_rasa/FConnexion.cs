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

        private void buttonOk_Click(object sender, EventArgs e)
        {

        }
    }
}
