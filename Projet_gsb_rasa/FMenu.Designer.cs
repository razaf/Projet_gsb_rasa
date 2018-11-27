namespace Projet_gsb_rasa
{
    partial class FMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visiteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeVisiteurParSecteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeVisiteurParRegionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisieDesFraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.profiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visiteurToolStripMenuItem,
            this.saisieDesFraisToolStripMenuItem,
            this.profiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visiteurToolStripMenuItem
            // 
            this.visiteurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeVisiteurParSecteurToolStripMenuItem,
            this.listeVisiteurParRegionToolStripMenuItem});
            this.visiteurToolStripMenuItem.Name = "visiteurToolStripMenuItem";
            this.visiteurToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.visiteurToolStripMenuItem.Text = "listes des visiteurs";
            this.visiteurToolStripMenuItem.Click += new System.EventHandler(this.visiteurToolStripMenuItem_Click);
            // 
            // listeVisiteurParSecteurToolStripMenuItem
            // 
            this.listeVisiteurParSecteurToolStripMenuItem.Name = "listeVisiteurParSecteurToolStripMenuItem";
            this.listeVisiteurParSecteurToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.listeVisiteurParSecteurToolStripMenuItem.Text = "liste visiteur par secteur";
            this.listeVisiteurParSecteurToolStripMenuItem.Click += new System.EventHandler(this.listeVisiteurParSecteurToolStripMenuItem_Click);
            // 
            // listeVisiteurParRegionToolStripMenuItem
            // 
            this.listeVisiteurParRegionToolStripMenuItem.Name = "listeVisiteurParRegionToolStripMenuItem";
            this.listeVisiteurParRegionToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.listeVisiteurParRegionToolStripMenuItem.Text = "liste visiteur par region";
            this.listeVisiteurParRegionToolStripMenuItem.Click += new System.EventHandler(this.listeVisiteurParRegionToolStripMenuItem_Click);
            // 
            // saisieDesFraisToolStripMenuItem
            // 
            this.saisieDesFraisToolStripMenuItem.Name = "saisieDesFraisToolStripMenuItem";
            this.saisieDesFraisToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.saisieDesFraisToolStripMenuItem.Text = "Saisie des frais";
            this.saisieDesFraisToolStripMenuItem.Click += new System.EventHandler(this.saisieDesFraisToolStripMenuItem_Click);
            // 
            // profiToolStripMenuItem
            // 
            this.profiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualiserProfilToolStripMenuItem,
            this.modifierProfilToolStripMenuItem});
            this.profiToolStripMenuItem.Name = "profiToolStripMenuItem";
            this.profiToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.profiToolStripMenuItem.Text = "profil";
            // 
            // visualiserProfilToolStripMenuItem
            // 
            this.visualiserProfilToolStripMenuItem.Name = "visualiserProfilToolStripMenuItem";
            this.visualiserProfilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visualiserProfilToolStripMenuItem.Text = "Visualiser profil";
            this.visualiserProfilToolStripMenuItem.Click += new System.EventHandler(this.visualiserProfilToolStripMenuItem_Click);
            // 
            // modifierProfilToolStripMenuItem
            // 
            this.modifierProfilToolStripMenuItem.Name = "modifierProfilToolStripMenuItem";
            this.modifierProfilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifierProfilToolStripMenuItem.Text = "modifier profil";
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMenu";
            this.Text = "salarie";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visiteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisieDesFraisToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem listeVisiteurParSecteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeVisiteurParRegionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserProfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierProfilToolStripMenuItem;
    }
}