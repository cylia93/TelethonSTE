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
using static System.Net.Mime.MediaTypeNames;

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
        Donateur donateurCourant = null;


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
        string valeur_str;
        string donMinimum_str;
        string qnte_Originale_str;
        string qnte_Disponible_str;
        string idCommenditaire;

        //Commanditaire
        string IDCommanditaire;
        Commanditaire commanditaireCourant = null;

        public Gestionnaire gestionnaire = new Gestionnaire();
        public Prix calendrier = new Prix("4", "calendrier", 30, 50, 5, 5, "45");

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
            catch (Exception ex)
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
                donateurCourant = null;

                this.prenom = txtPrenomDonateur.Text.Trim().ToLower();
                this.surnom = txtNom.Text.Trim().ToLower();
                this.idDonateur = txtIDDonateur.Text.Trim().ToLower();
                this.adresse = txtAdresse.Text.Trim().ToLower(); ;
                this.telephone = txtTelephone.Text.Trim().ToLower();

                foreach (System.Windows.Forms.RadioButton item in gbTypeCarte.Controls.OfType<System.Windows.Forms.RadioButton>())
                {
                    // Pour selectionner uniquement le type de carte actif :
                    if ((item).Checked == true)
                    {
                        // Pour selectionner uniquement la premiere lettre du type de carte :
                        this.typeDeCarte = item.Text.ToCharArray()[0];
                    }
                }
                this.numeroCarte = txtNumeroCarte.Text.Trim().ToLower();

                // On valide que la carte de credit proposee est valide :
                int monthsDifference = (dateTimeExpiration.Value.Year - DateTime.Now.Year) * 12 + dateTimeExpiration.Value.Month - DateTime.Now.Month;

                if (monthsDifference < 7)
                {
                    MessageBox.Show("La date d'expiration de votre carte de credit doit etre d'au moins 6 mois apres la date d'aujourd'hui.", "Erreur Ajout Donateur");
                    return;
                }

                this.dateExpiration = dateTimeExpiration.Value.ToShortDateString();

                gestionnaire.AjouterDonateur(prenom, surnom, idDonateur, adresse, telephone, typeDeCarte, numeroCarte, dateExpiration);
                donateurCourant = gestionnaire.ListDonateurs.Last();

                txtBoxMain.Text = gestionnaire.ListDonateurs.Last().ToString();

                MessageBox.Show("Donateur ajouter avec succes.", "Ajout Info Donateur");
                resetInfoDonateur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur Ajout Donateur");
            }
        }

        private void rbtnVisa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAjoutCommanditaire_Click(object sender, EventArgs e)
        {
            try
            {
                commanditaireCourant = null;

                this.prenom = txtPrenomCommanditaire.Text;
                this.surnom = txtNomCommanditaire.Text;
                this.IDCommanditaire = txtIDCommanditaire.Text;

                Func<Commanditaire, string> getIDCommanditaire = commanditaire => commanditaire.IDComm;
                commanditaireCourant = gestionnaire.trouverID(getIDCommanditaire, IDCommanditaire, gestionnaire.ListCommanditaires);

                if (commanditaireCourant != null)
                {
                    MessageBox.Show("Ajout impossible: ce commanditaire existe deja.", "Ajout commanditaire");
                    return;
                }

                gestionnaire.AjouterCommanditaire(prenom, surnom, IDCommanditaire);
                commanditaireCourant = gestionnaire.ListCommanditaires.Last();

                txtBoxMain.Text = gestionnaire.ListCommanditaires.Last().ToString();

                MessageBox.Show("Commanditaire ajouter avec succes.", "Ajout commanditaire");
                resetFieldsPrix();
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
            finally
            { 
                resetFieldsCommanditaire(); 
            }
        }

        private void btnAfficherCommanditaire_Click(object sender, EventArgs e)
        {
            commanditaireCourant = null;

            txtBoxMain.Text = "";
            txtBoxMain.Text += gestionnaire.AfficherCommenditaires() + "\n----------------------------\r\n";

            String idCommanditaire = txtIDCommanditaire.Text.Trim().ToLower();
            String nom = txtNomCommanditaire.Text.Trim().ToLower();
            String prenom = txtPrenomCommanditaire.Text.Trim().ToLower();

            try
            {
                if (!String.IsNullOrEmpty(idCommanditaire) && String.IsNullOrEmpty(nom) && String.IsNullOrEmpty(prenom))
                {
                    // Trouver le commanditaire par son ID :
                    Func<Commanditaire, string> getIDCommanditaire = commanditaire => commanditaire.IDComm;

                    commanditaireCourant = gestionnaire.trouverID(getIDCommanditaire, idCommanditaire, gestionnaire.ListCommanditaires);
                }
                if (String.IsNullOrEmpty(idCommanditaire) && !String.IsNullOrEmpty(nom) && !String.IsNullOrEmpty(prenom))
                {
                    // Trouver le commanditaire par son nom et prenom :
                    Func<Commanditaire, string> getNomCommanditaire = commanditaire => commanditaire.Surnom;
                    Func<Commanditaire, string> getPrenomCommanditaire = commanditaire => commanditaire.Prenom;

                    commanditaireCourant = gestionnaire.trouverPersonne(getNomCommanditaire, getPrenomCommanditaire, nom, prenom, gestionnaire.ListCommanditaires);
                }

                if (commanditaireCourant == null)
                {
                    txtBoxMain.Text += "Aucun commanditaire selectionne actuellement.";
                    resetFieldsCommanditaire();
                    return;
                }

                txtIDCommanditaire.Text = commanditaireCourant.IDComm;
                txtNomCommanditaire.Text = commanditaireCourant.Surnom;
                txtPrenomCommanditaire.Text = commanditaireCourant.Prenom;

                txtBoxMain.Text += "Commanditaire trouve: " + commanditaireCourant.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Commanditaire non trouve");
                resetFieldsCommanditaire();
            }
        }

        private void btnAjoutPrix_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.commanditaireCourant == null)
                {
                    MessageBox.Show("Ajout impossible: commanditaire non trouve.", "Ajout prix");
                    return;
                }

                // On indique les informations du commanditaire courant :
                txtIDCommanditaire.Text = commanditaireCourant.IDComm;
                txtNomCommanditaire.Text = commanditaireCourant.Surnom;
                txtPrenomCommanditaire.Text = commanditaireCourant.Prenom;

                // On recupere les informations des champs "Informations Prix" :
                idPrix = txtIDInfoPrix.Text.Trim().ToLower();
                description = txtDescriptionPrix.Text.Trim().ToLower();
                idCommenditaire = commanditaireCourant.IDComm;
                valeur_str = txtValPrix.Text.Trim().ToLower();
                donMinimum_str = txtMinDonPrix.Text.Trim().ToLower();
                qnte_Originale_str = txtQteInfoPrix.Text.Trim().ToLower();
                qnte_Disponible_str = qnte_Originale_str;


                // On creer le prix et on l'ajoute a la liste des prix courants :
                gestionnaire.AjouterPrix(idPrix, description,
                    Double.TryParse(valeur_str, out double valeur) ? valeur : 0,
                    Double.TryParse(donMinimum_str, out double donMinimum) ? donMinimum : 0, Int32.TryParse(qnte_Originale_str, out int qnte_Originale) ? qnte_Originale : 0,
                    Int32.TryParse(qnte_Disponible_str, out int qnte_Disponible) ? qnte_Disponible : 0,
                     idCommenditaire);

                txtBoxMain.Text = "Prix ajoute avec succes.";
                resetFieldsPrix();
                resetFieldsCommanditaire();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur Ajout Prix");
            }
        }

        private void btnAfficherPrix_Click(object sender, EventArgs e)
        {
            txtBoxMain.Text = gestionnaire.AfficherPrix();
        }

        private void resetFieldsCommanditaire()
        {
            txtIDCommanditaire.Text = txtNomCommanditaire.Text = txtPrenomCommanditaire.Text = "";
        }

        private void resetFieldsPrix()
        {
            txtIDInfoPrix.Text = txtDescriptionPrix.Text = txtValPrix.Text = txtQteInfoPrix.Text = txtMinDonPrix.Text = "";
        }

        private void resetInfoDonateur()
        {
            txtIDDonateur.Text = txtPrenomDonateur.Text = txtNom.Text = txtAdresse.Text = txtTelephone.Text = txtNumeroCarte.Text = "";

            foreach(System.Windows.Forms.RadioButton item in gbTypeCarte.Controls)
            {
                if (item.Checked) { item.Checked = false; }
            }

            dateTimeExpiration.Value = DateTime.Now;
        }

        private void resetInfoDon()
        {
            txtIDDon.Text = txtMntDon.Text = "";
        }

        private void resetInfoAttrPrix()
        {
            txtIDPrix.Text = txtQtePrix.Text = "";
        }

        private void btnQuiter_Click(object sender, EventArgs e)
        {
            DialogResult repons = MessageBox.Show("Desirez-vous réellement quitter cette application ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (repons == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
