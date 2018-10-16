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
            this.dgvResponsable = new System.Windows.Forms.DataGridView();
            this.bsResponsable = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResponsable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteur.Location = new System.Drawing.Point(93, 62);
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.Size = new System.Drawing.Size(147, 75);
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
            this.bsVisiteur.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // dgvResponsable
            // 
            this.dgvResponsable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponsable.Location = new System.Drawing.Point(50, 159);
            this.dgvResponsable.Name = "dgvResponsable";
            this.dgvResponsable.Size = new System.Drawing.Size(581, 54);
            this.dgvResponsable.TabIndex = 3;
            // 
            // bsResponsable
            // 
            this.bsResponsable.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged_1);
            // 
            // lblSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 375);
            this.Controls.Add(this.dgvResponsable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSecteur);
            this.Controls.Add(this.dgvVisiteur);
            this.Name = "lblSecteur";
            this.Text = "listVisiteur";
            this.Load += new System.EventHandler(this.lblSecteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResponsable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.BindingSource bsSource;
        private System.Windows.Forms.ComboBox cboSecteur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.DataGridView dgvResponsable;
        private System.Windows.Forms.BindingSource bsResponsable;
    }
}