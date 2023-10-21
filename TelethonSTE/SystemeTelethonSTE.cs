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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
        Commanditaire commanditaireCourant = null;

        public Gestionnaire gestionnaire = new Gestionnaire();
        public Prix calendrier = new Prix("4","calendrier", 30, 50, 5,5,"45");

        public SystemeTelethonSTE()
        {
            InitializeComponent();
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
                string txt = "";

                this.prenom = txtPrenomDonateur.Text;
                this.surnom = txtNom.Text;
                this.idDonateur = txtIDDonateur.Text;
                this.adresse = txtAdresse.Text;
                this.telephone = txtTelephone.Text;

                foreach (System.Windows.Forms.RadioButton item in gbTypeCarte.Controls.OfType<System.Windows.Forms.RadioButton>())
                {
                    // Pour selectionner uniquement le type de carte actif :
                    if ((item).Checked == true)
                    {
                        // Pour selectionner uniquement la premiere lettre du type de carte :
                        this.typeDeCarte = item.Text.ToCharArray()[0];
                    }
                }
                this.numeroCarte = txtNumeroCarte.Text;
                this.dateExpiration = dateTimeExpiration.Value.ToShortDateString();

                gestionnaire.AjouterDonateur(prenom, surnom, idDonateur, adresse, telephone, typeDeCarte, numeroCarte, dateExpiration);

                txtBoxMain.Text = gestionnaire.ListDonateurs.Last().ToString();

                MessageBox.Show("Donateur ajouter avec succes.", "Ajout Donateur");
            }
           
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "FormatException lors de l'ajout du donateur");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception lors de l'ajout du donateur");
            }
        }

        private void BtnQuiter(object sender, FormClosedEventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Desirez_vous réellement quitter cette application ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void rbtnVisa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAjoutCommanditaire_Click(object sender, EventArgs e)
        {
            try
            {         
                this.prenom = txtPrenomCommanditaire.Text;
                this.surnom = txtNomCommanditaire.Text;
                this.IDCommanditaire = txtIDCommanditaire.Text;              

                gestionnaire.AjouterCommanditaire(prenom, surnom, IDCommanditaire);

                txtBoxMain.Text = gestionnaire.ListCommanditaires.Last().ToString();

                MessageBox.Show("Commanditaire ajouter avec succes.", "Ajout commanditaire");
                resetFieldsCommanditaire();
            }

            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de l'ajout du commanditaire");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de l'ajout du commanditaire");
            }
        }

        private void btnAfficherCommanditaire_Click(object sender, EventArgs e)
        {
            String idCommanditaire = txtIDCommanditaire.Text.Trim().ToLower();
            String nom = txtNomCommanditaire.Text.Trim().ToLower();
            String prenom = txtPrenomCommanditaire.Text.Trim().ToLower();

            try
            {
                if (!String.IsNullOrEmpty(idCommanditaire))
                {
                    // Trouver le commanditaire par son ID :
                    Func<Commanditaire, string> getIDCommanditaire = commanditaire => commanditaire.IDComm;

                    commanditaireCourant = gestionnaire.trouverID(getIDCommanditaire, idCommanditaire, gestionnaire.ListCommanditaires);
                }
                else if (!String.IsNullOrEmpty(nom) && !String.IsNullOrEmpty(prenom))
                {
                    // Trouver le commanditaire par son nom et prenom :
                    Func<Commanditaire, string> getNomCommanditaire = commanditaire => commanditaire.Surnom;
                    Func<Commanditaire, string> getPrenomCommanditaire = commanditaire => commanditaire.Prenom;

                    commanditaireCourant = gestionnaire.trouverPersonne(getNomCommanditaire, getPrenomCommanditaire, nom, prenom, gestionnaire.ListCommanditaires);
                }

                if (commanditaireCourant == null)
                {
                    MessageBox.Show("Ce commanditaire n'a pas ete trouve.");
                    resetFieldsCommanditaire();
                    return;
                }

                txtIDCommanditaire.Text = commanditaireCourant.IDComm;
                txtNomCommanditaire.Text = commanditaireCourant.Surnom;
                txtPrenomCommanditaire.Text = commanditaireCourant.Prenom;

                txtBoxMain.Text = "Commanditaire trouve: " + commanditaireCourant.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Commanditaire non trouve");
            }
        }

        private void btnAjoutPrix_Click(object sender, EventArgs e)
        {
            try
            {
                if (commanditaireCourant == null)
                {
                    MessageBox.Show("Ajout impossible: commanditaire non trouve.", "Ajout prix");
                    return;
                }

                // On recupere les informations des champs "Informations Prix" :
                idPrix = txtIDInfoPrix.Text.Trim().ToLower();
                description = txtDescriptionPrix.Text.Trim().ToLower();
                valeur = Double.Parse(txtValPrix.Text.Trim().ToLower());
                donMinimum = Double.Parse(txtMinDonPrix.Text.Trim().ToLower());
                qnte_Originale = Int32.Parse(txtQteInfoPrix.Text.Trim().ToLower());
                qnte_Disponible = qnte_Originale;
                idCommenditaire = commanditaireCourant.IDComm;

                // On creer le prix et on l'ajoute a la liste des prix courants :
                Prix nouveauPrix = new Prix(idPrix, description, valeur, donMinimum, qnte_Originale, qnte_Disponible, idCommenditaire);
                gestionnaire.ListPrix.Add(nouveauPrix);
                txtBoxMain.Text = "Prix ajoute avec succes.";
                resetFieldsPrix();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Commanditaire non trouve");
                resetFieldsCommanditaire();
            }
        }

        private void btnAfficherPrix_Click(object sender, EventArgs e)
        {

        }

        private void resetFieldsCommanditaire()
        {
            txtIDCommanditaire.Text = txtNomCommanditaire.Text = txtPrenomCommanditaire.Text = "";
        }

        private void resetFieldsPrix()
        {
            txtIDInfoPrix.Text = txtDescriptionPrix.Text = txtValPrix.Text = txtQteInfoPrix.Text = txtMinDonPrix.Text = "";
        }
    }
}
