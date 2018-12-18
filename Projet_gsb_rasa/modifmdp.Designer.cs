namespace Projet_gsb_rasa
{
    partial class modifmdp
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
            this.txtconfirmMdp = new System.Windows.Forms.TextBox();
            this.textmdp = new System.Windows.Forms.TextBox();
            this.lblConfirmationmdp = new System.Windows.Forms.Label();
            this.lblmdp = new System.Windows.Forms.Label();
            this.bpCANCELmdp = new System.Windows.Forms.Button();
            this.bpOKmdp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtconfirmMdp
            // 
            this.txtconfirmMdp.Location = new System.Drawing.Point(247, 121);
            this.txtconfirmMdp.Name = "txtconfirmMdp";
            this.txtconfirmMdp.Size = new System.Drawing.Size(77, 20);
            this.txtconfirmMdp.TabIndex = 45;
            // 
            // textmdp
            // 
            this.textmdp.Location = new System.Drawing.Point(247, 81);
            this.textmdp.Name = "textmdp";
            this.textmdp.Size = new System.Drawing.Size(77, 20);
            this.textmdp.TabIndex = 44;
            // 
            // lblConfirmationmdp
            // 
            this.lblConfirmationmdp.AutoSize = true;
            this.lblConfirmationmdp.Location = new System.Drawing.Point(82, 124);
            this.lblConfirmationmdp.Name = "lblConfirmationmdp";
            this.lblConfirmationmdp.Size = new System.Drawing.Size(152, 13);
            this.lblConfirmationmdp.TabIndex = 43;
            this.lblConfirmationmdp.Text = "Confirmation du mot de passe :";
            // 
            // lblmdp
            // 
            this.lblmdp.AutoSize = true;
            this.lblmdp.Location = new System.Drawing.Point(111, 81);
            this.lblmdp.Name = "lblmdp";
            this.lblmdp.Size = new System.Drawing.Size(123, 13);
            this.lblmdp.TabIndex = 42;
            this.lblmdp.Text = "Nouveau mot de passe :";
            // 
            // bpCANCELmdp
            // 
            this.bpCANCELmdp.Location = new System.Drawing.Point(218, 189);
            this.bpCANCELmdp.Name = "bpCANCELmdp";
            this.bpCANCELmdp.Size = new System.Drawing.Size(75, 23);
            this.bpCANCELmdp.TabIndex = 47;
            this.bpCANCELmdp.Text = "CANCEL";
            this.bpCANCELmdp.UseVisualStyleBackColor = true;
            // 
            // bpOKmdp
            // 
            this.bpOKmdp.Location = new System.Drawing.Point(103, 189);
            this.bpOKmdp.Name = "bpOKmdp";
            this.bpOKmdp.Size = new System.Drawing.Size(75, 23);
            this.bpOKmdp.TabIndex = 46;
            this.bpOKmdp.Text = "OK";
            this.bpOKmdp.UseVisualStyleBackColor = true;
            // 
            // modifmdp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 250);
            this.Controls.Add(this.bpCANCELmdp);
            this.Controls.Add(this.bpOKmdp);
            this.Controls.Add(this.txtconfirmMdp);
            this.Controls.Add(this.textmdp);
            this.Controls.Add(this.lblConfirmationmdp);
            this.Controls.Add(this.lblmdp);
            this.Name = "modifmdp";
            this.Text = "modifmdp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtconfirmMdp;
        private System.Windows.Forms.TextBox textmdp;
        private System.Windows.Forms.Label lblConfirmationmdp;
        private System.Windows.Forms.Label lblmdp;
        private System.Windows.Forms.Button bpCANCELmdp;
        private System.Windows.Forms.Button bpOKmdp;
    }
}