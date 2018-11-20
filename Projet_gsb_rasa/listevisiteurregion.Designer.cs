namespace Projet_gsb_rasa
{
    partial class listevisiteurregion
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
            this.txt_prenom_respon = new System.Windows.Forms.TextBox();
            this.txt_ville_resp = new System.Windows.Forms.TextBox();
            this.txt_rue_resp = new System.Windows.Forms.TextBox();
            this.txt_cp_res = new System.Windows.Forms.TextBox();
            this.txt_nom_respon = new System.Windows.Forms.TextBox();
            this.lblregion = new System.Windows.Forms.Label();
            this.cboregion = new System.Windows.Forms.ComboBox();
            this.dgvVisiteur = new System.Windows.Forms.DataGridView();
            this.bsSource = new System.Windows.Forms.BindingSource(this.components);
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.bsResponsable = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResponsable)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_prenom_respon
            // 
            this.txt_prenom_respon.Location = new System.Drawing.Point(209, 161);
            this.txt_prenom_respon.Name = "txt_prenom_respon";
            this.txt_prenom_respon.Size = new System.Drawing.Size(86, 20);
            this.txt_prenom_respon.TabIndex = 16;
            // 
            // txt_ville_resp
            // 
            this.txt_ville_resp.Location = new System.Drawing.Point(485, 161);
            this.txt_ville_resp.Name = "txt_ville_resp";
            this.txt_ville_resp.Size = new System.Drawing.Size(86, 20);
            this.txt_ville_resp.TabIndex = 15;
            // 
            // txt_rue_resp
            // 
            this.txt_rue_resp.Location = new System.Drawing.Point(301, 161);
            this.txt_rue_resp.Name = "txt_rue_resp";
            this.txt_rue_resp.Size = new System.Drawing.Size(86, 20);
            this.txt_rue_resp.TabIndex = 14;
            // 
            // txt_cp_res
            // 
            this.txt_cp_res.Location = new System.Drawing.Point(393, 161);
            this.txt_cp_res.Name = "txt_cp_res";
            this.txt_cp_res.Size = new System.Drawing.Size(86, 20);
            this.txt_cp_res.TabIndex = 13;
            // 
            // txt_nom_respon
            // 
            this.txt_nom_respon.Location = new System.Drawing.Point(117, 161);
            this.txt_nom_respon.Name = "txt_nom_respon";
            this.txt_nom_respon.Size = new System.Drawing.Size(86, 20);
            this.txt_nom_respon.TabIndex = 12;
            // 
            // lblregion
            // 
            this.lblregion.AutoSize = true;
            this.lblregion.Location = new System.Drawing.Point(54, 42);
            this.lblregion.Name = "lblregion";
            this.lblregion.Size = new System.Drawing.Size(44, 13);
            this.lblregion.TabIndex = 11;
            this.lblregion.Text = "Region:";
            this.lblregion.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboregion
            // 
            this.cboregion.FormattingEnabled = true;
            this.cboregion.Location = new System.Drawing.Point(104, 39);
            this.cboregion.Name = "cboregion";
            this.cboregion.Size = new System.Drawing.Size(121, 21);
            this.cboregion.TabIndex = 10;
            this.cboregion.SelectedIndexChanged += new System.EventHandler(this.cboregion_SelectedIndexChanged);
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteur.Location = new System.Drawing.Point(57, 248);
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.Size = new System.Drawing.Size(547, 105);
            this.dgvVisiteur.TabIndex = 9;
            // 
            // bsSource
            // 
            this.bsSource.CurrentChanged += new System.EventHandler(this.bs_source_currentChange);
            // 
            // listevisiteurregion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 429);
            this.Controls.Add(this.txt_prenom_respon);
            this.Controls.Add(this.txt_ville_resp);
            this.Controls.Add(this.txt_rue_resp);
            this.Controls.Add(this.txt_cp_res);
            this.Controls.Add(this.txt_nom_respon);
            this.Controls.Add(this.lblregion);
            this.Controls.Add(this.cboregion);
            this.Controls.Add(this.dgvVisiteur);
            this.Name = "listevisiteurregion";
            this.Text = "listevisiteurregion";
            this.Load += new System.EventHandler(this.listevisiteurregion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResponsable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_prenom_respon;
        private System.Windows.Forms.TextBox txt_ville_resp;
        private System.Windows.Forms.TextBox txt_rue_resp;
        private System.Windows.Forms.TextBox txt_cp_res;
        private System.Windows.Forms.TextBox txt_nom_respon;
        private System.Windows.Forms.Label lblregion;
        private System.Windows.Forms.ComboBox cboregion;
        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.BindingSource bsSource;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.BindingSource bsResponsable;
    }
}