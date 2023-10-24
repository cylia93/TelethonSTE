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
            this.txtMotPasse.Location = new System.Drawing.Point(479, 102);
            this.txtMotPasse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMotPasse.Multiline = true;
            this.txtMotPasse.Name = "txtMotPasse";
            this.txtMotPasse.PasswordChar = '*';
            this.txtMotPasse.Size = new System.Drawing.Size(306, 32);
            this.txtMotPasse.TabIndex = 2;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.Navy;
            this.btnAnnuler.Location = new System.Drawing.Point(634, 169);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(118, 39);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // txtUtilisateur
            // 
            this.txtUtilisateur.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilisateur.Location = new System.Drawing.Point(479, 42);
            this.txtUtilisateur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUtilisateur.Multiline = true;
            this.txtUtilisateur.Name = "txtUtilisateur";
            this.txtUtilisateur.Size = new System.Drawing.Size(306, 32);
            this.txtUtilisateur.TabIndex = 1;
            // 
            // bTnOK
            // 
            this.bTnOK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTnOK.ForeColor = System.Drawing.Color.Navy;
            this.bTnOK.Location = new System.Drawing.Point(479, 169);
            this.bTnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bTnOK.Name = "bTnOK";
            this.bTnOK.Size = new System.Drawing.Size(118, 39);
            this.bTnOK.TabIndex = 3;
            this.bTnOK.Text = "OK";
            this.bTnOK.UseVisualStyleBackColor = true;
            this.bTnOK.Click += new System.EventHandler(this.bTnOK_Click);
            // 
            // lblMotdepasse
            // 
            this.lblMotdepasse.AutoSize = true;
            this.lblMotdepasse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotdepasse.ForeColor = System.Drawing.Color.Navy;
            this.lblMotdepasse.Location = new System.Drawing.Point(280, 102);
            this.lblMotdepasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotdepasse.Name = "lblMotdepasse";
            this.lblMotdepasse.Size = new System.Drawing.Size(151, 27);
            this.lblMotdepasse.TabIndex = 0;
            this.lblMotdepasse.Text = "&Mot de passe :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.Navy;
            this.lblNom.Location = new System.Drawing.Point(280, 48);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(188, 27);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "&Nom d\'utilisateur :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TelethonSTE.Properties.Resources.telethon_logo;
            this.pictureBox1.Location = new System.Drawing.Point(1, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 256);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.bTnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(800, 252);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMotPasse);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtUtilisateur);
            this.Controls.Add(this.bTnOK);
            this.Controls.Add(this.lblMotdepasse);
            this.Controls.Add(this.lblNom);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Systeme Telethon STE";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.btnAnnuler_Click);
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

