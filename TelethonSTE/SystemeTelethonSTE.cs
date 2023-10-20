using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using GestionnaireSTE;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TelethonSTE
{
    public partial class SystemeTelethonSTE : Form
    {
        // Don
        string idDon;
        string dateDuDon;
        string idDonateurDon;
        double montantDuDon;
        string idPrixDon;


        // Donateur
        String idDonateur;
        String adresse;
        String telephone;
        char typeDeCarte;
        String numeroCarte;
        String dateExpiration;
        string prenom;
        string surnom;
        //prix 
        string idPrix;
        string description;
        double valeur;
        double donMinimum;
        int qnte_Originale;
        int qnte_Disponible;
        string idCommenditaire;

        //Commanditaire
        string IDCommanditaire;
        

        public Gestionnaire gestionnaire = new Gestionnaire();
        public Personne personne = new Commanditaire("Emilie", "Echevin","EE45");
        public SystemeTelethonSTE()
        {
            string txt="";
            InitializeComponent();
            txt += personne.ToString();

            txt += "ID comm: " + ((Commanditaire)personne).IDComm;

            txtBoxMain.Text = txt;
        }
        // a regarder
        private void btnAffPrix_Click(object sender, EventArgs e)
        {
            try
            {
                txtBoxMain.Clear();
                txtBoxMain.Paste(gestionnaire.AfficherPrix());

                if (string.IsNullOrEmpty(txtBoxMain.Text))
                {
                    MessageBox.Show("Aucun prix n'est disponible");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur lors de l'affichage des prix");
            }
               
                
            
            
        }
       //pas encore fini
        private void btnAjoutDon_Click(object sender, EventArgs e)
        {
            try
            {
                this.idDon = txtIDDon.Text;
                this.dateDuDon = // ???
                this.idDonateurDon = txtIDDonateur.Text;
                this.montantDuDon = double.Parse(txtMntDon.Text);
                this.idPrixDon = txtIDPrix.Text;
            gestionnaire.AjouterDon(idDon, dateDuDon, idDonateur, montantDuDon, idPrix);
            MessageBox.Show("Don ajoute avec succes", "Ajout Don");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, " Erreur lors de l'ajout du don");
            }
           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de l'ajout du don");
            }
        }
       

        private void btnAjoutDonateur_Click(object sender, EventArgs e)
        {
            try
            {
               
                this.prenom = txtPrenomDonateur.Text;
                this.surnom = txtNom.Text;
                this.idDonateur = txtIDDonateur.Text;
                this.adresse = txtAdresse.Text;
                this.telephone = txtTelephone.Text;
                this.typeDeCarte = char.Parse(gbTypeCarte.Text);
                this.numeroCarte = txtNumeroCarte.Text;
                this.dateExpiration = dateTimeExpiration.Text;
                gestionnaire.AjouterDonateur(prenom, surnom, idDonateur, adresse, telephone, typeDeCarte, numeroCarte, dateExpiration);
                MessageBox.Show("Donateur ajouter avec succes.", "Ajout Concervateur");
                txtBoxMain.Text = gestionnaire.GetDonateur(idDonateur).ToString();

            }
           
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message,"Erreur lors de l'ajout du donateur");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de l'ajout du donateur");
            }
        }

        private void BtnQuiter(object sender, FormClosedEventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Desirez_vous réellement quitter cette application ?",
                                                      "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
