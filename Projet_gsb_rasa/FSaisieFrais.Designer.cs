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
            this.btnAjoutFHF = new System.Windows.Forms.Button();
            this.btnAjoutFF = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjoutFHF
            // 
            this.btnAjoutFHF.Location = new System.Drawing.Point(77, 277);
            this.btnAjoutFHF.Name = "btnAjoutFHF";
            this.btnAjoutFHF.Size = new System.Drawing.Size(186, 23);
            this.btnAjoutFHF.TabIndex = 0;
            this.btnAjoutFHF.Text = "Ajout frais hors forfait";
            this.btnAjoutFHF.UseVisualStyleBackColor = true;
            // 
            // btnAjoutFF
            // 
            this.btnAjoutFF.Location = new System.Drawing.Point(77, 104);
            this.btnAjoutFF.Name = "btnAjoutFF";
            this.btnAjoutFF.Size = new System.Drawing.Size(186, 23);
            this.btnAjoutFF.TabIndex = 1;
            this.btnAjoutFF.Text = "Ajout frais forfait";
            this.btnAjoutFF.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(322, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(322, 218);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // FSaisieFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAjoutFF);
            this.Controls.Add(this.btnAjoutFHF);
            this.Name = "FSaisieFrais";
            this.Text = "FSaisieFrais";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjoutFHF;
        private System.Windows.Forms.Button btnAjoutFF;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}