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
    public partial class modifmdp : Form
    {
        public modifmdp()
        {
            InitializeComponent();
        }

        private void bpOKmdp_Click(object sender, EventArgs e)
        {
            bool x = Modele.ModifMDP(txtconfirmMdp.ToString());
            if (x == false)
            {
                MessageBox.Show("erreur");
            }
        }

        private void txtconfirmMdp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
