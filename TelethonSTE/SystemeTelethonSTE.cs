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
using CsvHelper;
using System.IO;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;


namespace TelethonSTE
{
    public partial class SystemeTelethonSTE : Form
    {
        TextInfo convMajuscule = new CultureInfo("en-US", false).TextInfo;

        // Acces aux .csv dans le dossier Resources :

        static string RunningPath = AppDomain.CurrentDomain.BaseDirectory;

        string fichier_Commanditaires = string.Format("{0}Resources\\Liste_Commanditaires.csv", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
        string fichier_Donateurs= string.Format("{0}Resources\\Liste_Donateurs.csv", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
        string fichier_Dons= string.Format("{0}Resources\\Liste_Dons.csv", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
        string fichier_Prix= string.Format("{0}Resources\\Liste_Prix.csv", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
             
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
        Commanditaire commanditaireCourant = null;

        public Gestionnaire gestionnaire = new Gestionnaire();

        public SystemeTelethonSTE()
        {
            InitializeComponent();
           /* this.FormBorderStyle = FormBorderStyle.FixedSingle;*/

            // On popule toutes les listes de l'instance gestionnaire :

            using (var streamReader = new StreamReader(fichier_Commanditaires))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    foreach (var ligne in csvReader.GetRecords<Commanditaire>().ToList())
                    {
                        gestionnaire.ListCommanditaires.Add(ligne);
                    }
                }
            }

            using (var streamReader = new StreamReader(fichier_Donateurs))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    foreach (var ligne in csvReader.GetRecords<Donateur>().ToList())
                    {
                        gestionnaire.ListDonateurs.Add(ligne);
                    }
                }
            }

            using (var streamReader = new StreamReader(fichier_Dons))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    foreach (var ligne in csvReader.GetRecords<Don>().ToList())
                    {
                        gestionnaire.ListDons.Add(ligne);
                    }
                }
            }

            using (var streamReader = new StreamReader(fichier_Prix))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    foreach (var ligne in csvReader.GetRecords<Prix>().ToList())
                    {
                        gestionnaire.ListPrix.Add(ligne);
                    }
                }
            }
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
                                infoSurlesPrix += "ID: " + item.IdPrix + " , Description: " + item.Description + " , quantité disponible : " + item.Qnte_Disponible + " unités\r\n";
                        }

                        Fenetre_Input customDialog = new Fenetre_Input();
                        customDialog.InfoSurlesPrix = "Choississez un prix parmis la liste proposée (Renseignez l'ID uniquement puis fermez la fenêtre). Si le donateur ne veut pas de prix, ne rien renseigner:\r\n\r\n" + infoSurlesPrix;
                        customDialog.ShowDialog();

                        txtIDPrix.Text = customDialog.TxtReponse.Length == 0 ? "N/A" : customDialog.TxtReponse;

                        customDialog.Dispose();                    
                    } else
                    {
                        txtIDPrix.Text = txtQtePrix.Text = "N/A";
                        txtBoxMain.Clear();
                        txtBoxMain.Text = "Pas de prix disponible pour ce don.";
                    }
                } else
                {
                    MessageBox.Show("Le montant du don renseigné doit être une valeur positive.","Erreur Afficher Prix");
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
                bool IDExistant = false;

                foreach (Donateur d in gestionnaire.ListDonateurs)
                {
                    if (d.ID.Equals(txtIDDonateur.Text.ToUpper()))
                    {
                        IDExistant = true;
                        donateurCourant = d;
                        break;
                    }
                }

                if (!IDExistant) btnAjoutDonateur_Click(sender, e);

                if (donateurCourant != null) {

                    afficherInfoDonateur();

                    this.idDon = txtIDDon.Text.Trim().ToLower();
                    this.dateDuDon = DateTime.Now.ToShortDateString();
                    this.idDonateur = donateurCourant.ID;

                    if (!Double.TryParse(txtMntDon.Text.Trim().ToLower(), out montantDuDon))
                    {
                        MessageBox.Show("Le montant doit être specifié", "Erreur Ajout Don");
                        return;
                    }

                    idPrixCourant = txtIDPrix.Text.Trim();
                    idPrixCourant = !String.IsNullOrEmpty(idPrixCourant) ? idPrixCourant : "N/A";

                    if(!idPrixCourant.Equals("N/A"))
                    {
                        txtBoxMain.Clear();

                        // Validation sur l'elligibilite au prix :

                        Func<Prix, string> getIDPrix = prix => prix.IdPrix;
                        prixPropose = gestionnaire.trouverID(getIDPrix, idPrixCourant, gestionnaire.ListPrix);

                        if (montantDuDon < prixPropose.DonMinimum)
                        {
                            throw new FormatException("Ce don n'est pas éligible pour ce prix.");
                        }

                        if (!Int32.TryParse(txtQtePrix.Text.Trim().ToLower(), out quantiteDemandee))
                        {
                            throw new FormatException("Vous devez saisir une quantité valide.");
                        }

                        if (prixPropose.Qnte_Disponible - quantiteDemandee < 0)
                        {
                            throw new FormatException("Il n'y a pas assez d'unités pour ce prix.");
                        }
                    }

                    gestionnaire.AjouterDon(idDon.ToUpper(), dateDuDon, idDonateur.ToUpper(), montantDuDon, idPrixCourant.ToUpper());

                    // Si l'ajout est reussi, alors on deduit le nombre de prix attribues :
                    if (!idPrixCourant.Equals("N/A")) prixPropose.Deduire(quantiteDemandee);

                    MessageBox.Show("Don ajouté avec succès", "Ajout Don");
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
                this.adresse = txtAdresse.Text.Trim();
                this.telephone = txtTelephone.Text.Trim();

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

                gestionnaire.AjouterDonateur(convMajuscule.ToTitleCase(prenom), convMajuscule.ToTitleCase(surnom), idDonateur.ToUpper(), adresse, telephone, typeDeCarte, numeroCarte, dateExpiration);

                donateurCourant = gestionnaire.ListDonateurs.Last();

                txtBoxMain.Text = gestionnaire.ListDonateurs.Last().ToString();

                MessageBox.Show("Donateur ajouter avec succès.", "Ajout Info Donateur");
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
                string IDCommanditaire = txtIDCommanditaire.Text;

                Func<Commanditaire, string> getIDCommanditaire = commanditaire => commanditaire.IDComm;
                commanditaireCourant = gestionnaire.trouverID(getIDCommanditaire, IDCommanditaire, gestionnaire.ListCommanditaires);

                if (commanditaireCourant != null)
                {
                    MessageBox.Show("Ajout impossible: ce commanditaire existe deja.", "Ajout commanditaire");
                    resetFieldsCommanditaire();
                    return;
                }

                gestionnaire.AjouterCommanditaire(convMajuscule.ToTitleCase(prenom), convMajuscule.ToTitleCase(surnom), IDCommanditaire.ToUpper());

                commanditaireCourant = gestionnaire.ListCommanditaires.Last();

                txtBoxMain.Text = gestionnaire.ListCommanditaires.Last().ToString();

                MessageBox.Show("Commanditaire ajouter avec succès.", "Ajout commanditaire");
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
                    txtBoxMain.Text += "Aucun commanditaire sélectionné actuellement.";
                    resetFieldsCommanditaire();
                    return;
                }

                txtIDCommanditaire.Text = commanditaireCourant.IDComm;
                txtNomCommanditaire.Text = commanditaireCourant.Surnom;
                txtPrenomCommanditaire.Text = commanditaireCourant.Prenom;

                txtBoxMain.Text += "Commanditaire trouvé: " + commanditaireCourant.ToString();
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
                bool IDExistant = false;

                foreach(Commanditaire c in gestionnaire.ListCommanditaires)
                {
                    if (c.IDComm.Equals(txtIDCommanditaire.Text.ToUpper()))
                    {
                        IDExistant = true;
                        commanditaireCourant = c;
                        break;
                    }
                }
                
                if(!IDExistant) btnAjoutCommanditaire_Click(sender, e);

                if (this.commanditaireCourant == null)
                {
                    MessageBox.Show("Ajout impossible: commanditaire non trouvé.", "Ajout prix");
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
                gestionnaire.AjouterPrix(idPrix.ToUpper(), description,
                    Double.TryParse(valeur_str, out double valeur) ? valeur : 0,
                    Double.TryParse(donMinimum_str, out double donMinimum) ? donMinimum : 0, Int32.TryParse(qnte_Originale_str, out int qnte_Originale) ? qnte_Originale : 0,
                    Int32.TryParse(qnte_Disponible_str, out int qnte_Disponible) ? qnte_Disponible : 0,
                     idCommenditaire.ToUpper());

                MessageBox.Show("Prix ajouté avec succès.", "Ajout prix");
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
            DialogResult repons = MessageBox.Show("Désirez-vous réellement quitter cette application?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (repons == DialogResult.Yes)
            {
                // On enregistre les nouvelles valeurs des listes de gestionnaire dans leurs fichiers respectifs :

                using (var writer = new StreamWriter(fichier_Commanditaires, false))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csv.WriteRecords(gestionnaire.ListCommanditaires);
                }

                using (var writer = new StreamWriter(fichier_Donateurs, false))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csv.WriteRecords(gestionnaire.ListDonateurs);
                }

                using (var writer = new StreamWriter(fichier_Dons, false))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csv.WriteRecords(gestionnaire.ListDons);
                }

                using (var writer = new StreamWriter(fichier_Prix, false))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csv.WriteRecords(gestionnaire.ListPrix);
                }


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

                if (donateurCourant != null)
                {
                    afficherInfoDonateur();
                    txtBoxMain.Text += "Donateur courant: " + donateurCourant.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de l'ajout du donateur");
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

        private void btnAfficherDon_Click(object sender, EventArgs e)
        {
            txtBoxMain.Clear();
            txtBoxMain.Text += gestionnaire.AfficherDons() + "\r\n----------------------------\r\n";

            try
            {
                if (donateurCourant == null)
                {
                    return;
                }

                txtBoxMain.Text += "Don du donateur courant (" + donateurCourant.Prenom + "," + donateurCourant.Surnom +" ) :\r\n";

                String donsDonateurCourant = "";

                foreach (Don item in gestionnaire.ListDons)
                {
                    if (item.IdDonateurDon.Equals(donateurCourant.ID))
                        donsDonateurCourant += item.ToString() + "\r\n";
                }
                txtBoxMain.Text += String.IsNullOrEmpty(donsDonateurCourant) ? "Aucun don pour ce donateur." : donsDonateurCourant;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur Affichage Don");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            resetFieldsPrix();
            resetFieldsCommanditaire();
            resetInfoDon();
            resetInfoDonateur();
            resetInfoAttrPrix();
            txtBoxMain.Clear();
        }

        private void retirerDonateur_Click(object sender, EventArgs e)
        {
            Fenetre_Input customDialog = new Fenetre_Input();
            customDialog.InfoSurlesPrix = "Indiquez l'identifiant du donateur à supprimer, puis fermez la fenêtre:";
            customDialog.ShowDialog();

            String reponse = customDialog.TxtReponse;

            customDialog.Dispose();

            Func<Donateur, string> getIDDonateur = donateur => donateur.ID;

            Donateur donateurTrouve = gestionnaire.trouverID(getIDDonateur, reponse, gestionnaire.ListDonateurs);

            if (donateurTrouve == null)
            {
                MessageBox.Show("Ce donateur n'a pas été trouvé.", "Annulation Suppression");
                return;
            }

            DialogResult repons = MessageBox.Show("Êtes-vous sur de vouloir supprimer ce donateur?\r\n" + donateurTrouve.ToString(), "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (repons == DialogResult.Yes)
            {
                gestionnaire.ListDonateurs.Remove(donateurTrouve);
                MessageBox.Show("Donateur supprimé.", "Suppression donateur");
                btnRefresh_Click(sender, e);
            }
        }

        private void retirerCommanditaire_Click(object sender, EventArgs e)
        {
            Fenetre_Input customDialog = new Fenetre_Input();
            customDialog.InfoSurlesPrix = "Indiquez l'identifiant du commanditaire à supprimer, puis fermez la fenêtre:";
            customDialog.ShowDialog();

            String reponse = customDialog.TxtReponse;

            customDialog.Dispose();

            Func<Commanditaire, string> getIDCommanditaire = commanditaire => commanditaire.IDComm;

            Commanditaire commanditaireTrouve = gestionnaire.trouverID(getIDCommanditaire, reponse, gestionnaire.ListCommanditaires);

            if (commanditaireTrouve == null)
            {
                MessageBox.Show("Ce commanditaire n'a pas été trouvé.", "Annulation Suppression");
                return;
            }

            DialogResult repons = MessageBox.Show("Êtes-vous sur de vouloir supprimer ce commanditaire?\r\n" + commanditaireTrouve.ToString(), "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (repons == DialogResult.Yes)
            {
                gestionnaire.ListCommanditaires.Remove(commanditaireTrouve);
                MessageBox.Show("Commanditaire supprimé.", "Suppression commanditaire");
                btnRefresh_Click(sender, e);
            }
        }

        private void retirerPrix_Click(object sender, EventArgs e)
        {
            Fenetre_Input customDialog = new Fenetre_Input();
            customDialog.InfoSurlesPrix = "Indiquer l'identifiant du prix à supprimer, puis fermer la fenêtre:";
            customDialog.ShowDialog();

            String reponse = customDialog.TxtReponse;

            customDialog.Dispose();

            Func<Prix, string> getIDPrix = prix => prix.IdPrix;

            Prix prixTrouve = gestionnaire.trouverID(getIDPrix, reponse, gestionnaire.ListPrix);

            if (prixTrouve == null)
            {
                MessageBox.Show("Ce prix n'a pas été trouvé.", "Annulation Suppression");
                return;
            }

            DialogResult repons = MessageBox.Show("Êtes-vous sur de vouloir supprimer ce prix?\r\n" + prixTrouve.ToString(), "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (repons == DialogResult.Yes)
            {
                gestionnaire.ListPrix.Remove(prixTrouve);
                MessageBox.Show("Prix supprimé.", "Suppression Prix");
                btnRefresh_Click(sender, e);
            }
        }
    }
}
