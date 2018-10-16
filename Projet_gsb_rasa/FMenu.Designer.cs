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
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramettreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budjetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsalbitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteurParRégionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visiteurToolStripMenuItem,
            this.paramettreToolStripMenuItem,
            this.consultationToolStripMenuItem,
            this.budjetToolStripMenuItem,
            this.responsalbitésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visiteurToolStripMenuItem
            // 
            this.visiteurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem,
            this.visiteurParRégionToolStripMenuItem});
            this.visiteurToolStripMenuItem.Name = "visiteurToolStripMenuItem";
            this.visiteurToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.visiteurToolStripMenuItem.Text = "Visiteur";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sToolStripMenuItem.Text = "visiteur par secteur";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // paramettreToolStripMenuItem
            // 
            this.paramettreToolStripMenuItem.Name = "paramettreToolStripMenuItem";
            this.paramettreToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.paramettreToolStripMenuItem.Text = "paramètre";
            this.paramettreToolStripMenuItem.Click += new System.EventHandler(this.paramettreToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.consultationToolStripMenuItem.Text = "consultation";
            // 
            // budjetToolStripMenuItem
            // 
            this.budjetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historiqueToolStripMenuItem});
            this.budjetToolStripMenuItem.Name = "budjetToolStripMenuItem";
            this.budjetToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.budjetToolStripMenuItem.Text = "budget";
            // 
            // historiqueToolStripMenuItem
            // 
            this.historiqueToolStripMenuItem.Name = "historiqueToolStripMenuItem";
            this.historiqueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.historiqueToolStripMenuItem.Text = "historique";
            // 
            // responsalbitésToolStripMenuItem
            // 
            this.responsalbitésToolStripMenuItem.Name = "responsalbitésToolStripMenuItem";
            this.responsalbitésToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.responsalbitésToolStripMenuItem.Text = "responsabilités";
            this.responsalbitésToolStripMenuItem.Click += new System.EventHandler(this.responsalbitésToolStripMenuItem_Click);
            // 
            // visiteurParRégionToolStripMenuItem
            // 
            this.visiteurParRégionToolStripMenuItem.Name = "visiteurParRégionToolStripMenuItem";
            this.visiteurParRégionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visiteurParRégionToolStripMenuItem.Text = "visiteur par région ";
            // 
            // salarie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "salarie";
            this.Text = "salarie";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visiteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramettreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem budjetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsalbitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visiteurParRégionToolStripMenuItem;
    }
}