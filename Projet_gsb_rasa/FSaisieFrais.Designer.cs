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
            this.components = new System.ComponentModel.Container();
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.lblNumVisiteur = new System.Windows.Forms.Label();
            this.lblPrenomVisiteur = new System.Windows.Forms.Label();
            this.lblNomVisiteur = new System.Windows.Forms.Label();
            this.lblMois = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFraisForfaitaires = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltxtMontantUnitaire = new System.Windows.Forms.Label();
            this.cbxLib = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblLib = new System.Windows.Forms.Label();
            this.cbxRegion = new System.Windows.Forms.ComboBox();
            this.lblQteForfait = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvFraisForfait = new System.Windows.Forms.DataGridView();
            this.btnAjoutFraisForfait = new System.Windows.Forms.Button();
            this.bscbxLib = new System.Windows.Forms.BindingSource(this.components);
            this.bscbxRegion = new System.Windows.Forms.BindingSource(this.components);
            this.lblMontantFF = new System.Windows.Forms.Label();
            this.txtQteFF = new System.Windows.Forms.TextBox();
            this.lblMontantUFF = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscbxLib)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscbxRegion)).BeginInit();
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
            this.lblPrenomVisiteur.Location = new System.Drawing.Point(184, 9);
            this.lblPrenomVisiteur.Name = "lblPrenomVisiteur";
            this.lblPrenomVisiteur.Size = new System.Drawing.Size(76, 13);
            this.lblPrenomVisiteur.TabIndex = 4;
            this.lblPrenomVisiteur.Text = "prenomVisiteur";
            // 
            // lblNomVisiteur
            // 
            this.lblNomVisiteur.AutoSize = true;
            this.lblNomVisiteur.Location = new System.Drawing.Point(266, 9);
            this.lblNomVisiteur.Name = "lblNomVisiteur";
            this.lblNomVisiteur.Size = new System.Drawing.Size(61, 13);
            this.lblNomVisiteur.TabIndex = 5;
            this.lblNomVisiteur.Text = "nomVisiteur";
            this.lblNomVisiteur.Click += new System.EventHandler(this.lblNomVisiteur_Click);
            // 
            // lblMois
            // 
            this.lblMois.AutoSize = true;
            this.lblMois.Location = new System.Drawing.Point(547, 16);
            this.lblMois.Name = "lblMois";
            this.lblMois.Size = new System.Drawing.Size(35, 13);
            this.lblMois.TabIndex = 6;
            this.lblMois.Text = "Mois :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(588, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // lblFraisForfaitaires
            // 
            this.lblFraisForfaitaires.AutoSize = true;
            this.lblFraisForfaitaires.Location = new System.Drawing.Point(339, 187);
            this.lblFraisForfaitaires.Name = "lblFraisForfaitaires";
            this.lblFraisForfaitaires.Size = new System.Drawing.Size(80, 13);
            this.lblFraisForfaitaires.TabIndex = 8;
            this.lblFraisForfaitaires.Text = "Frais forfaitaires";
            this.lblFraisForfaitaires.Click += new System.EventHandler(this.lblFraisForfaitaires_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Frais kilometrique";
            // 
            // lbltxtMontantUnitaire
            // 
            this.lbltxtMontantUnitaire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltxtMontantUnitaire.AutoSize = true;
            this.lbltxtMontantUnitaire.Location = new System.Drawing.Point(490, 10);
            this.lbltxtMontantUnitaire.Name = "lbltxtMontantUnitaire";
            this.lbltxtMontantUnitaire.Size = new System.Drawing.Size(83, 13);
            this.lbltxtMontantUnitaire.TabIndex = 10;
            this.lbltxtMontantUnitaire.Text = "Montant unitaire";
            // 
            // cbxLib
            // 
            this.cbxLib.FormattingEnabled = true;
            this.cbxLib.Location = new System.Drawing.Point(3, 36);
            this.cbxLib.Name = "cbxLib";
            this.cbxLib.Size = new System.Drawing.Size(121, 21);
            this.cbxLib.TabIndex = 11;
            this.cbxLib.SelectedIndexChanged += new System.EventHandler(this.cbxLib_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.21189F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.78811F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.Controls.Add(this.cbxLib, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRegion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLib, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxRegion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbltxtMontantUnitaire, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQteForfait, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotal, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtQteFF, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMontantFF, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMontantUFF, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 212);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(692, 66);
            this.tableLayoutPanel1.TabIndex = 12;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblRegion
            // 
            this.lblRegion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(203, 10);
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
            this.lblLib.Location = new System.Drawing.Point(48, 10);
            this.lblLib.Name = "lblLib";
            this.lblLib.Size = new System.Drawing.Size(49, 13);
            this.lblLib.TabIndex = 13;
            this.lblLib.Text = "LIBELLE";
            // 
            // cbxRegion
            // 
            this.cbxRegion.FormattingEnabled = true;
            this.cbxRegion.Location = new System.Drawing.Point(149, 36);
            this.cbxRegion.Name = "cbxRegion";
            this.cbxRegion.Size = new System.Drawing.Size(121, 21);
            this.cbxRegion.TabIndex = 14;
            this.cbxRegion.SelectedIndexChanged += new System.EventHandler(this.cbxRegion_SelectedIndexChanged);
            // 
            // lblQteForfait
            // 
            this.lblQteForfait.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQteForfait.AutoSize = true;
            this.lblQteForfait.Location = new System.Drawing.Point(361, 10);
            this.lblQteForfait.Name = "lblQteForfait";
            this.lblQteForfait.Size = new System.Drawing.Size(47, 13);
            this.lblQteForfait.TabIndex = 15;
            this.lblQteForfait.Text = "Quantité";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(632, 10);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total";
            // 
            // dgvFraisForfait
            // 
            this.dgvFraisForfait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFraisForfait.Location = new System.Drawing.Point(15, 63);
            this.dgvFraisForfait.Name = "dgvFraisForfait";
            this.dgvFraisForfait.Size = new System.Drawing.Size(705, 121);
            this.dgvFraisForfait.TabIndex = 13;
            // 
            // btnAjoutFraisForfait
            // 
            this.btnAjoutFraisForfait.Location = new System.Drawing.Point(713, 236);
            this.btnAjoutFraisForfait.Name = "btnAjoutFraisForfait";
            this.btnAjoutFraisForfait.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutFraisForfait.TabIndex = 14;
            this.btnAjoutFraisForfait.Text = "Ajouter";
            this.btnAjoutFraisForfait.UseVisualStyleBackColor = true;
            this.btnAjoutFraisForfait.Click += new System.EventHandler(this.btnAjoutFraisForfait_Click);
            // 
            // bscbxLib
            // 
            this.bscbxLib.CurrentChanged += new System.EventHandler(this.bscbxLib_CurrentChanged);
            // 
            // lblMontantFF
            // 
            this.lblMontantFF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMontantFF.AutoSize = true;
            this.lblMontantFF.Location = new System.Drawing.Point(625, 43);
            this.lblMontantFF.Name = "lblMontantFF";
            this.lblMontantFF.Size = new System.Drawing.Size(46, 13);
            this.lblMontantFF.TabIndex = 17;
            this.lblMontantFF.Text = "Montant";
            // 
            // txtQteFF
            // 
            this.txtQteFF.Location = new System.Drawing.Point(313, 36);
            this.txtQteFF.Name = "txtQteFF";
            this.txtQteFF.Size = new System.Drawing.Size(100, 20);
            this.txtQteFF.TabIndex = 18;
            this.txtQteFF.TextChanged += new System.EventHandler(this.txtQteFF_TextChanged);
            // 
            // lblMontantUFF
            // 
            this.lblMontantUFF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMontantUFF.AutoSize = true;
            this.lblMontantUFF.Location = new System.Drawing.Point(491, 43);
            this.lblMontantUFF.Name = "lblMontantUFF";
            this.lblMontantUFF.Size = new System.Drawing.Size(82, 13);
            this.lblMontantUFF.TabIndex = 19;
            this.lblMontantUFF.Text = "MontantUnitaire";
            // 
            // FSaisieFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.btnAjoutFraisForfait);
            this.Controls.Add(this.dgvFraisForfait);
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
            this.Text = " ";
            this.Load += new System.EventHandler(this.FSaisieFrais_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscbxLib)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscbxRegion)).EndInit();
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
        private System.Windows.Forms.Label lbltxtMontantUnitaire;
        private System.Windows.Forms.ComboBox cbxLib;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblLib;
        private System.Windows.Forms.ComboBox cbxRegion;
        private System.Windows.Forms.Label lblQteForfait;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvFraisForfait;
        private System.Windows.Forms.Button btnAjoutFraisForfait;
        private System.Windows.Forms.BindingSource bscbxLib;
        private System.Windows.Forms.BindingSource bscbxRegion;
        private System.Windows.Forms.Label lblMontantFF;
        private System.Windows.Forms.TextBox txtQteFF;
        private System.Windows.Forms.Label lblMontantUFF;
    }
}