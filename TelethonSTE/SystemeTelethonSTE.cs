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
using System.Globalization;

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

        private void btnAffPrix_Click(object sender, EventArgs e)
        {
            try
            {
                if(Double.TryParse(txtMntDon.Text, out double montantDuDon) && montantDuDon > 0)
                {
                    if (gestionnaire.determinerNbrPrix(montantDuDon) > 0 && gestionnaire.AttribuerPrix(montantDuDon))
                    {
                        String infoSurlesPrix = "";

                        txtBoxMain.Clear();
                        txtBoxMain.Paste(gestionnaire.AfficherPrix(montantDuDon));

                        txtQtePrix.Text = gestionnaire.determinerNbrPrix(montantDuDon).ToString();

                        foreach (Prix item in gestionnaire.ListPrix)
                        {
                            if (item.DonMinimum <= montantDuDon)
                                infoSurlesPrix += "ID: " + item.IdPrix + " , Description: " + item.Description + " , quantite disponible : " + item.Qnte_Disponible + " unites\r\n";
                        }

                        Reponse_Prix customDialog = new Reponse_Prix();
                        customDialog.InfoSurlesPrix = "Choissississez un prix parmis la liste proposee (Renseignez l'ID uniquement puis fermez la fenetre). Si le donateur ne veut pas de prix, ne rien renseignez:\r\n\r\n" + infoSurlesPrix;
                        customDialog.ShowDialog();

                        txtIDPrix.Text = customDialog.TxtReponsePrix.Length == 0 ? "N/A" : customDialog.TxtReponsePrix;

                        customDialog.Dispose();                    
                    } else
                    {
                        txtIDPrix.Text = txtQtePrix.Text = "N/A";
                        txtBoxMain.Clear();
                        txtBoxMain.Text = "Pas de prix disponible pour ce don.";
                    }
                } else
                {
                    MessageBox.Show("Le montant du don renseigne doit etre une valeur positive.","Erreur Afficher Prix");
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur Afficher Prix");
            }
        }
        

        private void btnAjoutDon_Click(object sender, EventArgs e)
        {
            String idPrixCourant = "";
            Prix prixPropose = null;
            int quantiteDemandee = 0;

            try
            {
                if (donateurCourant != null) {

                    afficherInfoDonateur();

                    this.idDon = txtIDDon.Text.Trim().ToLower();
                    this.dateDuDon = DateTime.Now.ToShortDateString();
                    this.idDonateur = donateurCourant.ID;

                    if (!Double.TryParse(txtMntDon.Text.Trim().ToLower(), out montantDuDon))
                    {
                        MessageBox.Show("Le montant doit etre specifie", "Erreur Ajout Don");
                        return;
                    }

                    idPrixCourant = txtIDPrix.Text.Trim();

                    if(!idPrixCourant.Equals("N/A"))
                    {
                        txtBoxMain.Clear();
                        txtBoxMain.Text = "idPrix : " + idPrix;

                        // Validation sur l'elligibilite au prix :

                        Func<Prix, string> getIDPrix = prix => prix.IdPrix;
                        prixPropose = gestionnaire.trouverID(getIDPrix, idPrixCourant, gestionnaire.ListPrix);

                        if (montantDuDon < prixPropose.DonMinimum)
                        {
                            throw new FormatException("Ce don n'est pas elligible pour ce prix.");
                        }

                        if (!Int32.TryParse(txtQtePrix.Text.Trim().ToLower(), out quantiteDemandee))
                        {
                            throw new FormatException("Vous devez saisir une quantite valide.");
                        }

                        if (prixPropose.Qnte_Disponible - quantiteDemandee < 0)
                        {
                            throw new FormatException("Il n'y a pas assez d'unites pour ce prix.");
                        }
                    }

                    gestionnaire.AjouterDon(idDon, dateDuDon, idDonateur, montantDuDon, idPrixCourant);
                    if (!idPrixCourant.Equals("N/A")) prixPropose.Deduire(quantiteDemandee);

                    MessageBox.Show("Don ajoute avec succes", "Ajout Don");
                    resetInfoDon();
                    resetInfoDonateur();
                    resetInfoAttrPrix();
                    txtBoxMain.Clear();
                }
                else
                {
                    MessageBox.Show("Veuillez renseigner les informations du donateur.", "Erreur Ajout Don");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Erreur Ajout Don");
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
                MessageBox.Show(ex.Message, "Erreur Ajout Commanditaire");
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

        private void btnAfficherDonateur_Click(object sender, EventArgs e)
        {
            donateurCourant = null;

            txtBoxMain.Text = "";
            txtBoxMain.Text += gestionnaire.AfficherDonateurs()+ "\n----------------------------\r\n";

            String idDonateur = txtIDDonateur.Text.Trim().ToLower();
            String nom = txtNom.Text.Trim().ToLower();
            String prenom = txtPrenomDonateur.Text.Trim().ToLower();


            try
            {
                if (!String.IsNullOrEmpty(idDonateur) && String.IsNullOrEmpty(nom) && String.IsNullOrEmpty(prenom))
            {
                // Trouver le donateur par son ID :
                Func<Donateur, string> getIDDonateur = donateur => donateur.ID;

                donateurCourant = gestionnaire.trouverID(getIDDonateur, idDonateur, gestionnaire.ListDonateurs);
            }
            if (String.IsNullOrEmpty(idDonateur) && !String.IsNullOrEmpty(nom) && !String.IsNullOrEmpty(prenom))
            {
                // Trouver le donateur par son nom et prenom :
                Func<Donateur, string> getNomDonateur = donateur => donateur.Surnom;
                Func<Donateur, string> getPrenomDonateur = donateur => donateur.Prenom;

                donateurCourant = gestionnaire.trouverPersonne(getNomDonateur, getPrenomDonateur, nom, prenom, gestionnaire.ListDonateurs);
            }

            if (donateurCourant == null)
            {
                MessageBox.Show("Donateur non trouve");
                resetInfoDonateur();
                return;
            }

                afficherInfoDonateur();

                txtBoxMain.Text += "Donateur trouve: " + donateurCourant.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de l'ajout du commanditaire");
                resetInfoDonateur();
            }
        }

        public void afficherInfoDonateur()
        {
            txtIDDonateur.Text = donateurCourant.ID;
            txtNom.Text = donateurCourant.Surnom;
            txtPrenomDonateur.Text = donateurCourant.Prenom;
            txtAdresse.Text = donateurCourant.Adresse;
            txtTelephone.Text = donateurCourant.Telephone;

            foreach (System.Windows.Forms.RadioButton item in gbTypeCarte.Controls.OfType<System.Windows.Forms.RadioButton>())
            {
                // Pour selectionner le type de carte :
                if (donateurCourant.TypeDeCarte == item.Text.ToCharArray()[0])
                {
                    item.Checked = true;
                }
            }

            txtNumeroCarte.Text = donateurCourant.NumeroDeCarte;
            dateTimeExpiration.Value =
    DateTime.ParseExact(donateurCourant.DateExpiration, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        }
    }
}
