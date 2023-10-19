namespace TelethonSTE
{
    partial class Login
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
            this.txtMotPasse = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtUtilisateur = new System.Windows.Forms.TextBox();
            this.bTnOK = new System.Windows.Forms.Button();
            this.lblMotdepasse = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMotPasse
            // 
            this.txtMotPasse.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotPasse.Location = new System.Drawing.Point(426, 82);
            this.txtMotPasse.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotPasse.Multiline = true;
            this.txtMotPasse.Name = "txtMotPasse";
            this.txtMotPasse.PasswordChar = '*';
            this.txtMotPasse.Size = new System.Drawing.Size(272, 26);
            this.txtMotPasse.TabIndex = 20;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.Navy;
            this.btnAnnuler.Location = new System.Drawing.Point(564, 135);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(105, 31);
            this.btnAnnuler.TabIndex = 19;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // txtUtilisateur
            // 
            this.txtUtilisateur.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilisateur.Location = new System.Drawing.Point(426, 34);
            this.txtUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.txtUtilisateur.Multiline = true;
            this.txtUtilisateur.Name = "txtUtilisateur";
            this.txtUtilisateur.Size = new System.Drawing.Size(272, 26);
            this.txtUtilisateur.TabIndex = 16;
            // 
            // bTnOK
            // 
            this.bTnOK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTnOK.ForeColor = System.Drawing.Color.Navy;
            this.bTnOK.Location = new System.Drawing.Point(426, 135);
            this.bTnOK.Margin = new System.Windows.Forms.Padding(4);
            this.bTnOK.Name = "bTnOK";
            this.bTnOK.Size = new System.Drawing.Size(105, 31);
            this.bTnOK.TabIndex = 17;
            this.bTnOK.Text = "OK";
            this.bTnOK.UseVisualStyleBackColor = true;
            this.bTnOK.Click += new System.EventHandler(this.bTnOK_Click);
            // 
            // lblMotdepasse
            // 
            this.lblMotdepasse.AutoSize = true;
            this.lblMotdepasse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotdepasse.ForeColor = System.Drawing.Color.Navy;
            this.lblMotdepasse.Location = new System.Drawing.Point(249, 82);
            this.lblMotdepasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotdepasse.Name = "lblMotdepasse";
            this.lblMotdepasse.Size = new System.Drawing.Size(126, 22);
            this.lblMotdepasse.TabIndex = 18;
            this.lblMotdepasse.Text = "&Mot de passe :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.Navy;
            this.lblNom.Location = new System.Drawing.Point(249, 38);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(157, 22);
            this.lblNom.TabIndex = 15;
            this.lblNom.Text = "&Nom d\'utilisateur :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TelethonSTE.Properties.Resources.telethon_logo;
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 205);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 202);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMotPasse);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtUtilisateur);
            this.Controls.Add(this.bTnOK);
            this.Controls.Add(this.lblMotdepasse);
            this.Controls.Add(this.lblNom);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Systeme Telethon STE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMotPasse;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox txtUtilisateur;
        private System.Windows.Forms.Button bTnOK;
        private System.Windows.Forms.Label lblMotdepasse;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

