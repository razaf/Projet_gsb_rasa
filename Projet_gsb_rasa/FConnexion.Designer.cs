namespace Projet_gsb_rasa
{
    partial class FConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxLogoGSB = new System.Windows.Forms.PictureBox();
            this.labelIdentifiez = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoGSB)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogoGSB
            // 
            this.pictureBoxLogoGSB.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogoGSB.Image = global::Projet_gsb_rasa.Properties.Resources.logo;
            this.pictureBoxLogoGSB.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxLogoGSB.Name = "pictureBoxLogoGSB";
            this.pictureBoxLogoGSB.Size = new System.Drawing.Size(797, 447);
            this.pictureBoxLogoGSB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoGSB.TabIndex = 0;
            this.pictureBoxLogoGSB.TabStop = false;
            this.pictureBoxLogoGSB.Click += new System.EventHandler(this.pictureBoxLogoGSB_Click);
            // 
            // labelIdentifiez
            // 
            this.labelIdentifiez.AutoSize = true;
            this.labelIdentifiez.BackColor = System.Drawing.Color.Transparent;
            this.labelIdentifiez.Font = new System.Drawing.Font("Albertus Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentifiez.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelIdentifiez.Location = new System.Drawing.Point(292, 42);
            this.labelIdentifiez.Name = "labelIdentifiez";
            this.labelIdentifiez.Size = new System.Drawing.Size(144, 24);
            this.labelIdentifiez.TabIndex = 1;
            this.labelIdentifiez.Text = "Identifiez vous";
            this.labelIdentifiez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelIdentifiez.Click += new System.EventHandler(this.labelIdentifiez_Click);
            // 
            // txtID
            // 
            this.txtID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtID.Location = new System.Drawing.Point(310, 78);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtMDP
            // 
            this.txtMDP.Location = new System.Drawing.Point(310, 104);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.PasswordChar = '*';
            this.txtMDP.Size = new System.Drawing.Size(100, 20);
            this.txtMDP.TabIndex = 3;
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Albertus Extra Bold", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonOk.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonOk.Location = new System.Drawing.Point(425, 104);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(36, 24);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Font = new System.Drawing.Font("Albertus Extra Bold", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonQuitter.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonQuitter.Location = new System.Drawing.Point(693, 394);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(70, 24);
            this.buttonQuitter.TabIndex = 5;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelIdentifiez);
            this.Controls.Add(this.pictureBoxLogoGSB);
            this.Name = "FConnexion";
            this.Text = "RAPPORT_VISITE";
            this.Load += new System.EventHandler(this.FConnexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoGSB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogoGSB;
        private System.Windows.Forms.Label labelIdentifiez;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

