namespace Projet_gsb_rasa
{
    partial class ModifProfil
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
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblnom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.txtrue = new System.Windows.Forms.TextBox();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bpmodifmdp = new System.Windows.Forms.Button();
            this.bpOK = new System.Windows.Forms.Button();
            this.bpCANCEL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(81, 174);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(96, 13);
            this.lblAdresse.TabIndex = 20;
            this.lblAdresse.Text = "Nouvelle Adresse :";
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.Location = new System.Drawing.Point(81, 107);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(47, 13);
            this.lblVisiteur.TabIndex = 16;
            this.lblVisiteur.Text = "Visiteur :";
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(489, 104);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(77, 20);
            this.txtprenom.TabIndex = 23;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(250, 107);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(77, 20);
            this.txtNom.TabIndex = 24;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(164, 110);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(80, 13);
            this.lblnom.TabIndex = 25;
            this.lblnom.Text = "Nouveau nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nouveau prenom :";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(214, 174);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(30, 13);
            this.lblRue.TabIndex = 27;
            this.lblRue.Text = "Rue:";
            // 
            // txtrue
            // 
            this.txtrue.Location = new System.Drawing.Point(250, 170);
            this.txtrue.Name = "txtrue";
            this.txtrue.Size = new System.Drawing.Size(77, 20);
            this.txtrue.TabIndex = 28;
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(605, 171);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(77, 20);
            this.txtCp.TabIndex = 29;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(415, 171);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(77, 20);
            this.txtVille.TabIndex = 30;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(536, 174);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(63, 13);
            this.lblCP.TabIndex = 31;
            this.lblCP.Text = "Code postal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Ville :";
            // 
            // bpmodifmdp
            // 
            this.bpmodifmdp.Location = new System.Drawing.Point(264, 237);
            this.bpmodifmdp.Name = "bpmodifmdp";
            this.bpmodifmdp.Size = new System.Drawing.Size(219, 27);
            this.bpmodifmdp.TabIndex = 37;
            this.bpmodifmdp.Text = "MODIFIER MOT DE PASSE";
            this.bpmodifmdp.UseVisualStyleBackColor = true;
            this.bpmodifmdp.Click += new System.EventHandler(this.bpmodifmdp_Click);
            // 
            // bpOK
            // 
            this.bpOK.Location = new System.Drawing.Point(276, 392);
            this.bpOK.Name = "bpOK";
            this.bpOK.Size = new System.Drawing.Size(75, 23);
            this.bpOK.TabIndex = 35;
            this.bpOK.Text = "OK";
            this.bpOK.UseVisualStyleBackColor = true;
            this.bpOK.Click += new System.EventHandler(this.bpOK_Click);
            // 
            // bpCANCEL
            // 
            this.bpCANCEL.Location = new System.Drawing.Point(391, 392);
            this.bpCANCEL.Name = "bpCANCEL";
            this.bpCANCEL.Size = new System.Drawing.Size(75, 23);
            this.bpCANCEL.TabIndex = 36;
            this.bpCANCEL.Text = "CANCEL";
            this.bpCANCEL.UseVisualStyleBackColor = true;
            // 
            // ModifProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bpmodifmdp);
            this.Controls.Add(this.bpCANCEL);
            this.Controls.Add(this.bpOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtCp);
            this.Controls.Add(this.txtrue);
            this.Controls.Add(this.lblRue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblnom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblVisiteur);
            this.Name = "ModifProfil";
            this.Text = "ModifProfil";
            this.Load += new System.EventHandler(this.ModifProfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.TextBox txtrue;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bpmodifmdp;
        private System.Windows.Forms.Button bpOK;
        private System.Windows.Forms.Button bpCANCEL;
    }
}