namespace TelethonSTE
{
    partial class SystemeTelethonSTE
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
            this.lblInformation = new System.Windows.Forms.Label();
            this.tbDonateur = new System.Windows.Forms.TabControl();
            this.tabDonateur = new System.Windows.Forms.TabPage();
            this.btnAffichDonateur = new System.Windows.Forms.Button();
            this.btnAjoutDonateur = new System.Windows.Forms.Button();
            this.btnAfficherDon = new System.Windows.Forms.Button();
            this.btnAjoutDon = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtQtePrix = new System.Windows.Forms.TextBox();
            this.txtIDPrix = new System.Windows.Forms.TextBox();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.lblIDPrix = new System.Windows.Forms.Label();
            this.btnAffPrix = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeExpiration = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroCarte = new System.Windows.Forms.TextBox();
            this.lblDateExpiration = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.gbTypeCarte = new System.Windows.Forms.GroupBox();
            this.rbtnAMEX = new System.Windows.Forms.RadioButton();
            this.rbtnMC = new System.Windows.Forms.RadioButton();
            this.rbtnVisa = new System.Windows.Forms.RadioButton();
            this.txtMntDon = new System.Windows.Forms.TextBox();
            this.txtIDDon = new System.Windows.Forms.TextBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblIDdon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenomDonateur = new System.Windows.Forms.TextBox();
            this.txtIDDonateur = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tabCommanditaire = new System.Windows.Forms.TabPage();
            this.txtDescriptionPrix = new System.Windows.Forms.TextBox();
            this.txtValPrix = new System.Windows.Forms.TextBox();
            this.txtQteInfoPrix = new System.Windows.Forms.TextBox();
            this.txtMinDonPrix = new System.Windows.Forms.TextBox();
            this.txtIDInfoPrix = new System.Windows.Forms.TextBox();
            this.lblInfoPrix = new System.Windows.Forms.Label();
            this.txtNomCommanditaire = new System.Windows.Forms.TextBox();
            this.txtPrenomCommanditaire = new System.Windows.Forms.TextBox();
            this.txtIDCommanditaire = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblValeurPrix = new System.Windows.Forms.Label();
            this.llbQuantite = new System.Windows.Forms.Label();
            this.lblDonMinimum = new System.Windows.Forms.Label();
            this.blbIDInfoPrix = new System.Windows.Forms.Label();
            this.btnAfficherCommanditaire = new System.Windows.Forms.Button();
            this.btnAjoutPrix = new System.Windows.Forms.Button();
            this.btnAfficherPrix = new System.Windows.Forms.Button();
            this.btnAjoutCommanditaire = new System.Windows.Forms.Button();
            this.lblNomCommanditaire = new System.Windows.Forms.Label();
            this.lblPrenomCommanditaire = new System.Windows.Forms.Label();
            this.lblIDCommanditaire = new System.Windows.Forms.Label();
            this.lblInfoCommanditaire = new System.Windows.Forms.Label();
            this.btnQuiter = new System.Windows.Forms.Button();
            this.txtBoxMain = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauDonateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauCommanditaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauPrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbDonateur.SuspendLayout();
            this.tabDonateur.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbTypeCarte.SuspendLayout();
            this.tabCommanditaire.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(33, 38);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(213, 24);
            this.lblInformation.TabIndex = 0;
            this.lblInformation.Text = "Informations Donateur";
            // 
            // tbDonateur
            // 
            this.tbDonateur.Controls.Add(this.tabDonateur);
            this.tbDonateur.Controls.Add(this.tabCommanditaire);
            this.tbDonateur.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDonateur.Location = new System.Drawing.Point(14, 65);
            this.tbDonateur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDonateur.Name = "tbDonateur";
            this.tbDonateur.SelectedIndex = 0;
            this.tbDonateur.Size = new System.Drawing.Size(824, 561);
            this.tbDonateur.TabIndex = 19;
            // 
            // tabDonateur
            // 
            this.tabDonateur.Controls.Add(this.btnAffichDonateur);
            this.tabDonateur.Controls.Add(this.btnAjoutDonateur);
            this.tabDonateur.Controls.Add(this.btnAfficherDon);
            this.tabDonateur.Controls.Add(this.btnAjoutDon);
            this.tabDonateur.Controls.Add(this.groupBox3);
            this.tabDonateur.Controls.Add(this.groupBox1);
            this.tabDonateur.Controls.Add(this.txtMntDon);
            this.tabDonateur.Controls.Add(this.txtIDDon);
            this.tabDonateur.Controls.Add(this.lblMontant);
            this.tabDonateur.Controls.Add(this.lblIDdon);
            this.tabDonateur.Controls.Add(this.label1);
            this.tabDonateur.Controls.Add(this.txtTelephone);
            this.tabDonateur.Controls.Add(this.txtAdresse);
            this.tabDonateur.Controls.Add(this.txtNom);
            this.tabDonateur.Controls.Add(this.txtPrenomDonateur);
            this.tabDonateur.Controls.Add(this.txtIDDonateur);
            this.tabDonateur.Controls.Add(this.lblTelephone);
            this.tabDonateur.Controls.Add(this.lblAdresse);
            this.tabDonateur.Controls.Add(this.lblNom);
            this.tabDonateur.Controls.Add(this.lblPrenom);
            this.tabDonateur.Controls.Add(this.lblID);
            this.tabDonateur.Controls.Add(this.lblInformation);
            this.tabDonateur.Location = new System.Drawing.Point(4, 31);
            this.tabDonateur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabDonateur.Name = "tabDonateur";
            this.tabDonateur.Size = new System.Drawing.Size(816, 526);
            this.tabDonateur.TabIndex = 0;
            this.tabDonateur.Text = "Donateur";
            this.tabDonateur.UseVisualStyleBackColor = true;
            // 
            // btnAffichDonateur
            // 
            this.btnAffichDonateur.Location = new System.Drawing.Point(610, 455);
            this.btnAffichDonateur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAffichDonateur.Name = "btnAffichDonateur";
            this.btnAffichDonateur.Size = new System.Drawing.Size(181, 34);
            this.btnAffichDonateur.TabIndex = 21;
            this.btnAffichDonateur.Text = "Afficher Donateur";
            this.btnAffichDonateur.UseVisualStyleBackColor = true;
            // 
            // btnAjoutDonateur
            // 
            this.btnAjoutDonateur.Location = new System.Drawing.Point(610, 414);
            this.btnAjoutDonateur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAjoutDonateur.Name = "btnAjoutDonateur";
            this.btnAjoutDonateur.Size = new System.Drawing.Size(181, 34);
            this.btnAjoutDonateur.TabIndex = 20;
            this.btnAjoutDonateur.Text = "Ajouter Donateur";
            this.btnAjoutDonateur.UseVisualStyleBackColor = true;
            this.btnAjoutDonateur.Click += new System.EventHandler(this.btnAjoutDonateur_Click);
            // 
            // btnAfficherDon
            // 
            this.btnAfficherDon.Location = new System.Drawing.Point(610, 370);
            this.btnAfficherDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAfficherDon.Name = "btnAfficherDon";
            this.btnAfficherDon.Size = new System.Drawing.Size(181, 34);
            this.btnAfficherDon.TabIndex = 19;
            this.btnAfficherDon.Text = "Afficher Don";
            this.btnAfficherDon.UseVisualStyleBackColor = true;
            // 
            // btnAjoutDon
            // 
            this.btnAjoutDon.Location = new System.Drawing.Point(610, 329);
            this.btnAjoutDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAjoutDon.Name = "btnAjoutDon";
            this.btnAjoutDon.Size = new System.Drawing.Size(181, 34);
            this.btnAjoutDon.TabIndex = 18;
            this.btnAjoutDon.Text = "Ajouter Don";
            this.btnAjoutDon.UseVisualStyleBackColor = true;
            this.btnAjoutDon.Click += new System.EventHandler(this.btnAjoutDon_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtQtePrix);
            this.groupBox3.Controls.Add(this.txtIDPrix);
            this.groupBox3.Controls.Add(this.lblQuantite);
            this.groupBox3.Controls.Add(this.lblIDPrix);
            this.groupBox3.Controls.Add(this.btnAffPrix);
            this.groupBox3.Location = new System.Drawing.Point(331, 329);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(241, 169);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Attribuer Prix";
            // 
            // txtQtePrix
            // 
            this.txtQtePrix.Location = new System.Drawing.Point(114, 122);
            this.txtQtePrix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQtePrix.Name = "txtQtePrix";
            this.txtQtePrix.Size = new System.Drawing.Size(112, 31);
            this.txtQtePrix.TabIndex = 4;
            // 
            // txtIDPrix
            // 
            this.txtIDPrix.Location = new System.Drawing.Point(114, 81);
            this.txtIDPrix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDPrix.Name = "txtIDPrix";
            this.txtIDPrix.Size = new System.Drawing.Size(112, 31);
            this.txtIDPrix.TabIndex = 3;
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(24, 118);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(88, 23);
            this.lblQuantite.TabIndex = 2;
            this.lblQuantite.Text = "Quantité:";
            // 
            // lblIDPrix
            // 
            this.lblIDPrix.AutoSize = true;
            this.lblIDPrix.Location = new System.Drawing.Point(24, 84);
            this.lblIDPrix.Name = "lblIDPrix";
            this.lblIDPrix.Size = new System.Drawing.Size(77, 23);
            this.lblIDPrix.TabIndex = 1;
            this.lblIDPrix.Text = "ID Prix:";
            // 
            // btnAffPrix
            // 
            this.btnAffPrix.Location = new System.Drawing.Point(24, 34);
            this.btnAffPrix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAffPrix.Name = "btnAffPrix";
            this.btnAffPrix.Size = new System.Drawing.Size(202, 34);
            this.btnAffPrix.TabIndex = 0;
            this.btnAffPrix.Text = "Afficher Prix";
            this.btnAffPrix.UseVisualStyleBackColor = true;
            this.btnAffPrix.Click += new System.EventHandler(this.btnAffPrix_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeExpiration);
            this.groupBox1.Controls.Add(this.txtNumeroCarte);
            this.groupBox1.Controls.Add(this.lblDateExpiration);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Controls.Add(this.gbTypeCarte);
            this.groupBox1.Location = new System.Drawing.Point(294, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(438, 249);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carte de credit";
            // 
            // dateTimeExpiration
            // 
            this.dateTimeExpiration.Location = new System.Drawing.Point(184, 180);
            this.dateTimeExpiration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeExpiration.Name = "dateTimeExpiration";
            this.dateTimeExpiration.Size = new System.Drawing.Size(224, 31);
            this.dateTimeExpiration.TabIndex = 4;
            // 
            // txtNumeroCarte
            // 
            this.txtNumeroCarte.Location = new System.Drawing.Point(184, 122);
            this.txtNumeroCarte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumeroCarte.Name = "txtNumeroCarte";
            this.txtNumeroCarte.Size = new System.Drawing.Size(224, 31);
            this.txtNumeroCarte.TabIndex = 3;
            // 
            // lblDateExpiration
            // 
            this.lblDateExpiration.AutoSize = true;
            this.lblDateExpiration.Location = new System.Drawing.Point(19, 188);
            this.lblDateExpiration.Name = "lblDateExpiration";
            this.lblDateExpiration.Size = new System.Drawing.Size(158, 23);
            this.lblDateExpiration.TabIndex = 2;
            this.lblDateExpiration.Text = "Date d\'éxpiration:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(19, 132);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(85, 23);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Numéro:";
            // 
            // gbTypeCarte
            // 
            this.gbTypeCarte.Controls.Add(this.rbtnAMEX);
            this.gbTypeCarte.Controls.Add(this.rbtnMC);
            this.gbTypeCarte.Controls.Add(this.rbtnVisa);
            this.gbTypeCarte.Location = new System.Drawing.Point(21, 26);
            this.gbTypeCarte.Name = "gbTypeCarte";
            this.gbTypeCarte.Size = new System.Drawing.Size(263, 54);
            this.gbTypeCarte.TabIndex = 0;
            this.gbTypeCarte.TabStop = false;
            this.gbTypeCarte.Text = "Type de carte";
            // 
            // rbtnAMEX
            // 
            this.rbtnAMEX.AutoSize = true;
            this.rbtnAMEX.Location = new System.Drawing.Point(198, 34);
            this.rbtnAMEX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnAMEX.Name = "rbtnAMEX";
            this.rbtnAMEX.Size = new System.Drawing.Size(94, 27);
            this.rbtnAMEX.TabIndex = 2;
            this.rbtnAMEX.TabStop = true;
            this.rbtnAMEX.Text = "AMEX";
            this.rbtnAMEX.UseVisualStyleBackColor = true;
            // 
            // rbtnMC
            // 
            this.rbtnMC.AutoSize = true;
            this.rbtnMC.Location = new System.Drawing.Point(101, 34);
            this.rbtnMC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnMC.Name = "rbtnMC";
            this.rbtnMC.Size = new System.Drawing.Size(67, 27);
            this.rbtnMC.TabIndex = 1;
            this.rbtnMC.TabStop = true;
            this.rbtnMC.Text = "MC";
            this.rbtnMC.UseVisualStyleBackColor = true;
            // 
            // rbtnVisa
            // 
            this.rbtnVisa.AutoSize = true;
            this.rbtnVisa.Location = new System.Drawing.Point(8, 34);
            this.rbtnVisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnVisa.Name = "rbtnVisa";
            this.rbtnVisa.Size = new System.Drawing.Size(72, 27);
            this.rbtnVisa.TabIndex = 0;
            this.rbtnVisa.TabStop = true;
            this.rbtnVisa.Text = "Visa";
            this.rbtnVisa.UseVisualStyleBackColor = true;
            // 
            // txtMntDon
            // 
            this.txtMntDon.Location = new System.Drawing.Point(136, 442);
            this.txtMntDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMntDon.Name = "txtMntDon";
            this.txtMntDon.Size = new System.Drawing.Size(168, 31);
            this.txtMntDon.TabIndex = 15;
            // 
            // txtIDDon
            // 
            this.txtIDDon.Location = new System.Drawing.Point(136, 399);
            this.txtIDDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDDon.Name = "txtIDDon";
            this.txtIDDon.Size = new System.Drawing.Size(168, 31);
            this.txtIDDon.TabIndex = 14;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(42, 442);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(86, 23);
            this.lblMontant.TabIndex = 13;
            this.lblMontant.Text = "Montant:";
            // 
            // lblIDdon
            // 
            this.lblIDdon.AutoSize = true;
            this.lblIDdon.Location = new System.Drawing.Point(42, 399);
            this.lblIDdon.Name = "lblIDdon";
            this.lblIDdon.Size = new System.Drawing.Size(73, 23);
            this.lblIDdon.TabIndex = 12;
            this.lblIDdon.Text = "ID don:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Informations Don";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(136, 254);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(168, 31);
            this.txtTelephone.TabIndex = 10;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(136, 212);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(168, 31);
            this.txtAdresse.TabIndex = 9;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(136, 171);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(168, 31);
            this.txtNom.TabIndex = 8;
            // 
            // txtPrenomDonateur
            // 
            this.txtPrenomDonateur.Location = new System.Drawing.Point(121, 104);
            this.txtPrenomDonateur.Name = "txtPrenomDonateur";
            this.txtPrenomDonateur.Size = new System.Drawing.Size(150, 27);
            this.txtPrenomDonateur.TabIndex = 7;
            // 
            // txtIDDonateur
            // 
            this.txtIDDonateur.Location = new System.Drawing.Point(121, 71);
            this.txtIDDonateur.Name = "txtIDDonateur";
            this.txtIDDonateur.Size = new System.Drawing.Size(150, 27);
            this.txtIDDonateur.TabIndex = 6;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(33, 254);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(102, 23);
            this.lblTelephone.TabIndex = 5;
            this.lblTelephone.Text = "Téléphone:";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(36, 212);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(81, 23);
            this.lblAdresse.TabIndex = 4;
            this.lblAdresse.Text = "Adresse:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(36, 171);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(58, 23);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom:";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(37, 130);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(81, 23);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(43, 89);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 19);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "&ID:";
            // 
            // tabCommanditaire
            // 
            this.tabCommanditaire.Controls.Add(this.txtDescriptionPrix);
            this.tabCommanditaire.Controls.Add(this.txtValPrix);
            this.tabCommanditaire.Controls.Add(this.txtQteInfoPrix);
            this.tabCommanditaire.Controls.Add(this.txtMinDonPrix);
            this.tabCommanditaire.Controls.Add(this.txtIDInfoPrix);
            this.tabCommanditaire.Controls.Add(this.lblInfoPrix);
            this.tabCommanditaire.Controls.Add(this.txtNomCommanditaire);
            this.tabCommanditaire.Controls.Add(this.txtPrenomCommanditaire);
            this.tabCommanditaire.Controls.Add(this.txtIDCommanditaire);
            this.tabCommanditaire.Controls.Add(this.lblDescription);
            this.tabCommanditaire.Controls.Add(this.lblValeurPrix);
            this.tabCommanditaire.Controls.Add(this.llbQuantite);
            this.tabCommanditaire.Controls.Add(this.lblDonMinimum);
            this.tabCommanditaire.Controls.Add(this.blbIDInfoPrix);
            this.tabCommanditaire.Controls.Add(this.btnAfficherCommanditaire);
            this.tabCommanditaire.Controls.Add(this.btnAjoutPrix);
            this.tabCommanditaire.Controls.Add(this.btnAfficherPrix);
            this.tabCommanditaire.Controls.Add(this.btnAjoutCommanditaire);
            this.tabCommanditaire.Controls.Add(this.lblNomCommanditaire);
            this.tabCommanditaire.Controls.Add(this.lblPrenomCommanditaire);
            this.tabCommanditaire.Controls.Add(this.lblIDCommanditaire);
            this.tabCommanditaire.Controls.Add(this.lblInfoCommanditaire);
            this.tabCommanditaire.Location = new System.Drawing.Point(4, 31);
            this.tabCommanditaire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCommanditaire.Name = "tabCommanditaire";
            this.tabCommanditaire.Size = new System.Drawing.Size(816, 526);
            this.tabCommanditaire.TabIndex = 1;
            this.tabCommanditaire.Text = "Commanditaire";
            this.tabCommanditaire.UseVisualStyleBackColor = true;
            // 
            // txtDescriptionPrix
            // 
            this.txtDescriptionPrix.Location = new System.Drawing.Point(600, 141);
            this.txtDescriptionPrix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescriptionPrix.Name = "txtDescriptionPrix";
            this.txtDescriptionPrix.Size = new System.Drawing.Size(163, 31);
            this.txtDescriptionPrix.TabIndex = 21;
            // 
            // txtValPrix
            // 
            this.txtValPrix.Location = new System.Drawing.Point(600, 182);
            this.txtValPrix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValPrix.Name = "txtValPrix";
            this.txtValPrix.Size = new System.Drawing.Size(163, 31);
            this.txtValPrix.TabIndex = 20;
            // 
            // txtQteInfoPrix
            // 
            this.txtQteInfoPrix.Location = new System.Drawing.Point(600, 224);
            this.txtQteInfoPrix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQteInfoPrix.Name = "txtQteInfoPrix";
            this.txtQteInfoPrix.Size = new System.Drawing.Size(163, 31);
            this.txtQteInfoPrix.TabIndex = 19;
            // 
            // txtMinDonPrix
            // 
            this.txtMinDonPrix.Location = new System.Drawing.Point(600, 265);
            this.txtMinDonPrix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMinDonPrix.Name = "txtMinDonPrix";
            this.txtMinDonPrix.Size = new System.Drawing.Size(163, 31);
            this.txtMinDonPrix.TabIndex = 18;
            // 
            // txtIDInfoPrix
            // 
            this.txtIDInfoPrix.Location = new System.Drawing.Point(600, 100);
            this.txtIDInfoPrix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDInfoPrix.Name = "txtIDInfoPrix";
            this.txtIDInfoPrix.Size = new System.Drawing.Size(163, 31);
            this.txtIDInfoPrix.TabIndex = 17;
            // 
            // lblInfoPrix
            // 
            this.lblInfoPrix.AutoSize = true;
            this.lblInfoPrix.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPrix.Location = new System.Drawing.Point(470, 46);
            this.lblInfoPrix.Name = "lblInfoPrix";
            this.lblInfoPrix.Size = new System.Drawing.Size(166, 24);
            this.lblInfoPrix.TabIndex = 16;
            this.lblInfoPrix.Text = "Informations Prix";
            // 
            // txtNomCommanditaire
            // 
            this.txtNomCommanditaire.Location = new System.Drawing.Point(191, 211);
            this.txtNomCommanditaire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomCommanditaire.Name = "txtNomCommanditaire";
            this.txtNomCommanditaire.Size = new System.Drawing.Size(163, 31);
            this.txtNomCommanditaire.TabIndex = 15;
            // 
            // txtPrenomCommanditaire
            // 
            this.txtPrenomCommanditaire.Location = new System.Drawing.Point(191, 161);
            this.txtPrenomCommanditaire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrenomCommanditaire.Name = "txtPrenomCommanditaire";
            this.txtPrenomCommanditaire.Size = new System.Drawing.Size(163, 31);
            this.txtPrenomCommanditaire.TabIndex = 14;
            // 
            // txtIDCommanditaire
            // 
            this.txtIDCommanditaire.Location = new System.Drawing.Point(191, 104);
            this.txtIDCommanditaire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDCommanditaire.Name = "txtIDCommanditaire";
            this.txtIDCommanditaire.Size = new System.Drawing.Size(163, 31);
            this.txtIDCommanditaire.TabIndex = 13;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(470, 145);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(113, 23);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description:";
            // 
            // lblValeurPrix
            // 
            this.lblValeurPrix.AutoSize = true;
            this.lblValeurPrix.Location = new System.Drawing.Point(470, 182);
            this.lblValeurPrix.Name = "lblValeurPrix";
            this.lblValeurPrix.Size = new System.Drawing.Size(106, 23);
            this.lblValeurPrix.TabIndex = 11;
            this.lblValeurPrix.Text = "Valeur/Prix";
            // 
            // llbQuantite
            // 
            this.llbQuantite.AutoSize = true;
            this.llbQuantite.Location = new System.Drawing.Point(470, 221);
            this.llbQuantite.Name = "llbQuantite";
            this.llbQuantite.Size = new System.Drawing.Size(88, 23);
            this.llbQuantite.TabIndex = 10;
            this.llbQuantite.Text = "Quantité:";
            // 
            // lblDonMinimum
            // 
            this.lblDonMinimum.AutoSize = true;
            this.lblDonMinimum.Location = new System.Drawing.Point(470, 265);
            this.lblDonMinimum.Name = "lblDonMinimum";
            this.lblDonMinimum.Size = new System.Drawing.Size(134, 23);
            this.lblDonMinimum.TabIndex = 9;
            this.lblDonMinimum.Text = "Don Minimum";
            // 
            // blbIDInfoPrix
            // 
            this.blbIDInfoPrix.AutoSize = true;
            this.blbIDInfoPrix.Location = new System.Drawing.Point(470, 104);
            this.blbIDInfoPrix.Name = "blbIDInfoPrix";
            this.blbIDInfoPrix.Size = new System.Drawing.Size(37, 23);
            this.blbIDInfoPrix.TabIndex = 8;
            this.blbIDInfoPrix.Text = "ID:";
            // 
            // btnAfficherCommanditaire
            // 
            this.btnAfficherCommanditaire.Location = new System.Drawing.Point(230, 412);
            this.btnAfficherCommanditaire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAfficherCommanditaire.Name = "btnAfficherCommanditaire";
            this.btnAfficherCommanditaire.Size = new System.Drawing.Size(161, 64);
            this.btnAfficherCommanditaire.TabIndex = 7;
            this.btnAfficherCommanditaire.Text = "Afficher Commanditaire";
            this.btnAfficherCommanditaire.UseVisualStyleBackColor = true;
            // 
            // btnAjoutPrix
            // 
            this.btnAjoutPrix.Location = new System.Drawing.Point(410, 412);
            this.btnAjoutPrix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAjoutPrix.Name = "btnAjoutPrix";
            this.btnAjoutPrix.Size = new System.Drawing.Size(161, 64);
            this.btnAjoutPrix.TabIndex = 6;
            this.btnAjoutPrix.Text = "Ajouter Prix";
            this.btnAjoutPrix.UseVisualStyleBackColor = true;
            // 
            // btnAfficherPrix
            // 
            this.btnAfficherPrix.Location = new System.Drawing.Point(587, 412);
            this.btnAfficherPrix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAfficherPrix.Name = "btnAfficherPrix";
            this.btnAfficherPrix.Size = new System.Drawing.Size(161, 64);
            this.btnAfficherPrix.TabIndex = 5;
            this.btnAfficherPrix.Text = "Afficher Prix";
            this.btnAfficherPrix.UseVisualStyleBackColor = true;
            // 
            // btnAjoutCommanditaire
            // 
            this.btnAjoutCommanditaire.Location = new System.Drawing.Point(62, 412);
            this.btnAjoutCommanditaire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAjoutCommanditaire.Name = "btnAjoutCommanditaire";
            this.btnAjoutCommanditaire.Size = new System.Drawing.Size(161, 64);
            this.btnAjoutCommanditaire.TabIndex = 4;
            this.btnAjoutCommanditaire.Text = "Ajouter Commanditaire";
            this.btnAjoutCommanditaire.UseVisualStyleBackColor = true;
            // 
            // lblNomCommanditaire
            // 
            this.lblNomCommanditaire.AutoSize = true;
            this.lblNomCommanditaire.Location = new System.Drawing.Point(81, 221);
            this.lblNomCommanditaire.Name = "lblNomCommanditaire";
            this.lblNomCommanditaire.Size = new System.Drawing.Size(58, 23);
            this.lblNomCommanditaire.TabIndex = 3;
            this.lblNomCommanditaire.Text = "Nom:";
            // 
            // lblPrenomCommanditaire
            // 
            this.lblPrenomCommanditaire.AutoSize = true;
            this.lblPrenomCommanditaire.Location = new System.Drawing.Point(81, 165);
            this.lblPrenomCommanditaire.Name = "lblPrenomCommanditaire";
            this.lblPrenomCommanditaire.Size = new System.Drawing.Size(81, 23);
            this.lblPrenomCommanditaire.TabIndex = 2;
            this.lblPrenomCommanditaire.Text = "Prenom:";
            // 
            // lblIDCommanditaire
            // 
            this.lblIDCommanditaire.AutoSize = true;
            this.lblIDCommanditaire.Location = new System.Drawing.Point(81, 104);
            this.lblIDCommanditaire.Name = "lblIDCommanditaire";
            this.lblIDCommanditaire.Size = new System.Drawing.Size(37, 23);
            this.lblIDCommanditaire.TabIndex = 1;
            this.lblIDCommanditaire.Text = "ID:";
            // 
            // lblInfoCommanditaire
            // 
            this.lblInfoCommanditaire.AutoSize = true;
            this.lblInfoCommanditaire.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoCommanditaire.Location = new System.Drawing.Point(81, 46);
            this.lblInfoCommanditaire.Name = "lblInfoCommanditaire";
            this.lblInfoCommanditaire.Size = new System.Drawing.Size(268, 24);
            this.lblInfoCommanditaire.TabIndex = 0;
            this.lblInfoCommanditaire.Text = "Informations Commanditaire";
            // 
            // btnQuiter
            // 
            this.btnQuiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiter.Location = new System.Drawing.Point(839, 588);
            this.btnQuiter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuiter.Name = "btnQuiter";
            this.btnQuiter.Size = new System.Drawing.Size(107, 34);
            this.btnQuiter.TabIndex = 22;
            this.btnQuiter.Text = "Quitter";
            this.btnQuiter.UseVisualStyleBackColor = true;
            // 
            // txtBoxMain
            // 
            this.txtBoxMain.Location = new System.Drawing.Point(12, 507);
            this.txtBoxMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxMain.Multiline = true;
            this.txtBoxMain.Name = "txtBoxMain";
            this.txtBoxMain.Size = new System.Drawing.Size(829, 149);
            this.txtBoxMain.TabIndex = 23;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(973, 33);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "Fichier";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(74, 29);
            this.toolStripMenuItem1.Text = "Ficher";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauDonateurToolStripMenuItem,
            this.nouveauCommanditaireToolStripMenuItem,
            this.nouveauPrixToolStripMenuItem});
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // nouveauDonateurToolStripMenuItem
            // 
            this.nouveauDonateurToolStripMenuItem.Name = "nouveauDonateurToolStripMenuItem";
            this.nouveauDonateurToolStripMenuItem.Size = new System.Drawing.Size(321, 34);
            this.nouveauDonateurToolStripMenuItem.Text = "Nouveau donateur...";
            // 
            // nouveauCommanditaireToolStripMenuItem
            // 
            this.nouveauCommanditaireToolStripMenuItem.Name = "nouveauCommanditaireToolStripMenuItem";
            this.nouveauCommanditaireToolStripMenuItem.Size = new System.Drawing.Size(321, 34);
            this.nouveauCommanditaireToolStripMenuItem.Text = "Nouveau commanditaire...";
            // 
            // nouveauPrixToolStripMenuItem
            // 
            this.nouveauPrixToolStripMenuItem.Name = "nouveauPrixToolStripMenuItem";
            this.nouveauPrixToolStripMenuItem.Size = new System.Drawing.Size(321, 34);
            this.nouveauPrixToolStripMenuItem.Text = "Nouveau prix...";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // SystemeTelethonSTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(865, 667);
            this.Controls.Add(this.txtBoxMain);
            this.Controls.Add(this.btnQuiter);
            this.Controls.Add(this.tbDonateur);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SystemeTelethonSTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Syteme Telethon STE";
            this.tbDonateur.ResumeLayout(false);
            this.tabDonateur.ResumeLayout(false);
            this.tabDonateur.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTypeCarte.ResumeLayout(false);
            this.gbTypeCarte.PerformLayout();
            this.tabCommanditaire.ResumeLayout(false);
            this.tabCommanditaire.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.TabControl tbDonateur;
        private System.Windows.Forms.TabPage tabDonateur;
        private System.Windows.Forms.Button btnAffichDonateur;
        private System.Windows.Forms.Button btnAjoutDonateur;
        private System.Windows.Forms.Button btnAfficherDon;
        private System.Windows.Forms.Button btnAjoutDon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtQtePrix;
        private System.Windows.Forms.TextBox txtIDPrix;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Label lblIDPrix;
        private System.Windows.Forms.Button btnAffPrix;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimeExpiration;
        private System.Windows.Forms.TextBox txtNumeroCarte;
        private System.Windows.Forms.Label lblDateExpiration;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.GroupBox gbTypeCarte;
        private System.Windows.Forms.RadioButton rbtnAMEX;
        private System.Windows.Forms.RadioButton rbtnMC;
        private System.Windows.Forms.RadioButton rbtnVisa;
        private System.Windows.Forms.TextBox txtMntDon;
        private System.Windows.Forms.TextBox txtIDDon;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblIDdon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenomDonateur;
        private System.Windows.Forms.TextBox txtIDDonateur;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TabPage tabCommanditaire;
        private System.Windows.Forms.TextBox txtDescriptionPrix;
        private System.Windows.Forms.TextBox txtValPrix;
        private System.Windows.Forms.TextBox txtQteInfoPrix;
        private System.Windows.Forms.TextBox txtMinDonPrix;
        private System.Windows.Forms.TextBox txtIDInfoPrix;
        private System.Windows.Forms.Label lblInfoPrix;
        private System.Windows.Forms.TextBox txtNomCommanditaire;
        private System.Windows.Forms.TextBox txtPrenomCommanditaire;
        private System.Windows.Forms.TextBox txtIDCommanditaire;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblValeurPrix;
        private System.Windows.Forms.Label llbQuantite;
        private System.Windows.Forms.Label lblDonMinimum;
        private System.Windows.Forms.Label blbIDInfoPrix;
        private System.Windows.Forms.Button btnAfficherCommanditaire;
        private System.Windows.Forms.Button btnAjoutPrix;
        private System.Windows.Forms.Button btnAfficherPrix;
        private System.Windows.Forms.Button btnAjoutCommanditaire;
        private System.Windows.Forms.Label lblNomCommanditaire;
        private System.Windows.Forms.Label lblPrenomCommanditaire;
        private System.Windows.Forms.Label lblIDCommanditaire;
        private System.Windows.Forms.Label lblInfoCommanditaire;
        private System.Windows.Forms.Button btnQuiter;
        private System.Windows.Forms.TextBox txtBoxMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauDonateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauCommanditaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauPrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}