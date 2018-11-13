namespace Projet_gsb_rasa
{
    partial class FSaisieFrais
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
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.lblNumVisiteur = new System.Windows.Forms.Label();
            this.lblPrenomVisiteur = new System.Windows.Forms.Label();
            this.lblNomVisiteur = new System.Windows.Forms.Label();
            this.lblMois = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFraisForfaitaires = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMontantUnitaire = new System.Windows.Forms.Label();
            this.cbxLib = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblLib = new System.Windows.Forms.Label();
            this.cbxRegion = new System.Windows.Forms.ComboBox();
            this.lblQteForfait = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.Location = new System.Drawing.Point(12, 9);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(47, 13);
            this.lblVisiteur.TabIndex = 2;
            this.lblVisiteur.Text = "Visiteur :";
            // 
            // lblNumVisiteur
            // 
            this.lblNumVisiteur.AutoSize = true;
            this.lblNumVisiteur.Location = new System.Drawing.Point(65, 9);
            this.lblNumVisiteur.Name = "lblNumVisiteur";
            this.lblNumVisiteur.Size = new System.Drawing.Size(61, 13);
            this.lblNumVisiteur.TabIndex = 3;
            this.lblNumVisiteur.Text = "numVisiteur";
            this.lblNumVisiteur.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrenomVisiteur
            // 
            this.lblPrenomVisiteur.AutoSize = true;
            this.lblPrenomVisiteur.Location = new System.Drawing.Point(12, 22);
            this.lblPrenomVisiteur.Name = "lblPrenomVisiteur";
            this.lblPrenomVisiteur.Size = new System.Drawing.Size(76, 13);
            this.lblPrenomVisiteur.TabIndex = 4;
            this.lblPrenomVisiteur.Text = "prenomVisiteur";
            // 
            // lblNomVisiteur
            // 
            this.lblNomVisiteur.AutoSize = true;
            this.lblNomVisiteur.Location = new System.Drawing.Point(12, 35);
            this.lblNomVisiteur.Name = "lblNomVisiteur";
            this.lblNomVisiteur.Size = new System.Drawing.Size(61, 13);
            this.lblNomVisiteur.TabIndex = 5;
            this.lblNomVisiteur.Text = "nomVisiteur";
            // 
            // lblMois
            // 
            this.lblMois.AutoSize = true;
            this.lblMois.Location = new System.Drawing.Point(285, 9);
            this.lblMois.Name = "lblMois";
            this.lblMois.Size = new System.Drawing.Size(35, 13);
            this.lblMois.TabIndex = 6;
            this.lblMois.Text = "Mois :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(326, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // lblFraisForfaitaires
            // 
            this.lblFraisForfaitaires.AutoSize = true;
            this.lblFraisForfaitaires.Location = new System.Drawing.Point(309, 161);
            this.lblFraisForfaitaires.Name = "lblFraisForfaitaires";
            this.lblFraisForfaitaires.Size = new System.Drawing.Size(80, 13);
            this.lblFraisForfaitaires.TabIndex = 8;
            this.lblFraisForfaitaires.Text = "Frais forfaitaires";
            this.lblFraisForfaitaires.Click += new System.EventHandler(this.lblFraisForfaitaires_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Frais kilometrique";
            // 
            // lblMontantUnitaire
            // 
            this.lblMontantUnitaire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMontantUnitaire.AutoSize = true;
            this.lblMontantUnitaire.Location = new System.Drawing.Point(511, 8);
            this.lblMontantUnitaire.Name = "lblMontantUnitaire";
            this.lblMontantUnitaire.Size = new System.Drawing.Size(83, 13);
            this.lblMontantUnitaire.TabIndex = 10;
            this.lblMontantUnitaire.Text = "Montant unitaire";
            // 
            // cbxLib
            // 
            this.cbxLib.FormattingEnabled = true;
            this.cbxLib.Location = new System.Drawing.Point(3, 32);
            this.cbxLib.Name = "cbxLib";
            this.cbxLib.Size = new System.Drawing.Size(121, 21);
            this.cbxLib.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.21189F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.78811F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.Controls.Add(this.cbxLib, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRegion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLib, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxRegion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMontantUnitaire, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQteForfait, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotal, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(68, 177);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(705, 58);
            this.tableLayoutPanel1.TabIndex = 12;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblRegion
            // 
            this.lblRegion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(214, 8);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(49, 13);
            this.lblRegion.TabIndex = 13;
            this.lblRegion.Text = "REGION";
            this.lblRegion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLib
            // 
            this.lblLib.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLib.AutoSize = true;
            this.lblLib.Location = new System.Drawing.Point(52, 8);
            this.lblLib.Name = "lblLib";
            this.lblLib.Size = new System.Drawing.Size(49, 13);
            this.lblLib.TabIndex = 13;
            this.lblLib.Text = "LIBELLE";
            // 
            // cbxRegion
            // 
            this.cbxRegion.FormattingEnabled = true;
            this.cbxRegion.Location = new System.Drawing.Point(156, 32);
            this.cbxRegion.Name = "cbxRegion";
            this.cbxRegion.Size = new System.Drawing.Size(121, 21);
            this.cbxRegion.TabIndex = 14;
            // 
            // lblQteForfait
            // 
            this.lblQteForfait.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQteForfait.AutoSize = true;
            this.lblQteForfait.Location = new System.Drawing.Point(382, 8);
            this.lblQteForfait.Name = "lblQteForfait";
            this.lblQteForfait.Size = new System.Drawing.Size(47, 13);
            this.lblQteForfait.TabIndex = 15;
            this.lblQteForfait.Text = "Quantité";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(646, 8);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total";
            // 
            // FSaisieFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFraisForfaitaires);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblMois);
            this.Controls.Add(this.lblNomVisiteur);
            this.Controls.Add(this.lblPrenomVisiteur);
            this.Controls.Add(this.lblNumVisiteur);
            this.Controls.Add(this.lblVisiteur);
            this.Name = "FSaisieFrais";
            this.Text = "FSaisieFrais";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.Label lblNumVisiteur;
        private System.Windows.Forms.Label lblPrenomVisiteur;
        private System.Windows.Forms.Label lblNomVisiteur;
        private System.Windows.Forms.Label lblMois;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFraisForfaitaires;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMontantUnitaire;
        private System.Windows.Forms.ComboBox cbxLib;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblLib;
        private System.Windows.Forms.ComboBox cbxRegion;
        private System.Windows.Forms.Label lblQteForfait;
        private System.Windows.Forms.Label lblTotal;
    }
}