namespace Projet_gsb_rasa
{
    partial class lblSecteur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvVisiteur = new System.Windows.Forms.DataGridView();
            this.bsSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboSecteur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.bsResponsable = new System.Windows.Forms.BindingSource(this.components);
            this.txt_nom_respon = new System.Windows.Forms.TextBox();
            this.txt_cp_res = new System.Windows.Forms.TextBox();
            this.txt_rue_resp = new System.Windows.Forms.TextBox();
            this.txt_ville_resp = new System.Windows.Forms.TextBox();
            this.txt_prenom_respon = new System.Windows.Forms.TextBox();
            this.bsVisiteurS = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResponsable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteur.Location = new System.Drawing.Point(78, 143);
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.Size = new System.Drawing.Size(547, 105);
            this.dgvVisiteur.TabIndex = 0;
            this.dgvVisiteur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisiteur_CellContentClick);
            // 
            // bsSource
            // 
            this.bsSource.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // cboSecteur
            // 
            this.cboSecteur.FormattingEnabled = true;
            this.cboSecteur.Location = new System.Drawing.Point(93, 21);
            this.cboSecteur.Name = "cboSecteur";
            this.cboSecteur.Size = new System.Drawing.Size(121, 21);
            this.cboSecteur.TabIndex = 1;
            this.cboSecteur.SelectedIndexChanged += new System.EventHandler(this.cboSecteur_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Secteur :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bsVisiteur
            // 
            this.bsVisiteur.CurrentChanged += new System.EventHandler(this.bs_Visiteur_CurrentChanged);
            // 
            // bsResponsable
            // 
            this.bsResponsable.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged_1);
            // 
            // txt_nom_respon
            // 
            this.txt_nom_respon.Location = new System.Drawing.Point(142, 74);
            this.txt_nom_respon.Name = "txt_nom_respon";
            this.txt_nom_respon.Size = new System.Drawing.Size(86, 20);
            this.txt_nom_respon.TabIndex = 4;
            // 
            // txt_cp_res
            // 
            this.txt_cp_res.Location = new System.Drawing.Point(418, 74);
            this.txt_cp_res.Name = "txt_cp_res";
            this.txt_cp_res.Size = new System.Drawing.Size(86, 20);
            this.txt_cp_res.TabIndex = 5;
            // 
            // txt_rue_resp
            // 
            this.txt_rue_resp.Location = new System.Drawing.Point(326, 74);
            this.txt_rue_resp.Name = "txt_rue_resp";
            this.txt_rue_resp.Size = new System.Drawing.Size(86, 20);
            this.txt_rue_resp.TabIndex = 6;
            // 
            // txt_ville_resp
            // 
            this.txt_ville_resp.Location = new System.Drawing.Point(510, 74);
            this.txt_ville_resp.Name = "txt_ville_resp";
            this.txt_ville_resp.Size = new System.Drawing.Size(86, 20);
            this.txt_ville_resp.TabIndex = 7;
            // 
            // txt_prenom_respon
            // 
            this.txt_prenom_respon.Location = new System.Drawing.Point(234, 74);
            this.txt_prenom_respon.Name = "txt_prenom_respon";
            this.txt_prenom_respon.Size = new System.Drawing.Size(86, 20);
            this.txt_prenom_respon.TabIndex = 8;
            // 
            // lblSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 308);
            this.Controls.Add(this.txt_prenom_respon);
            this.Controls.Add(this.txt_ville_resp);
            this.Controls.Add(this.txt_rue_resp);
            this.Controls.Add(this.txt_cp_res);
            this.Controls.Add(this.txt_nom_respon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSecteur);
            this.Controls.Add(this.dgvVisiteur);
            this.Name = "lblSecteur";
            this.Text = "listVisiteur";
            this.Load += new System.EventHandler(this.lblSecteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResponsable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.BindingSource bsSource;
        private System.Windows.Forms.ComboBox cboSecteur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.BindingSource bsResponsable;
        private System.Windows.Forms.TextBox txt_nom_respon;
        private System.Windows.Forms.TextBox txt_cp_res;
        private System.Windows.Forms.TextBox txt_rue_resp;
        private System.Windows.Forms.TextBox txt_ville_resp;
        private System.Windows.Forms.TextBox txt_prenom_respon;
        private System.Windows.Forms.BindingSource bsVisiteurS;
    }
}