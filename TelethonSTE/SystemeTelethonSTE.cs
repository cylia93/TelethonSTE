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
        string prenom;
        string surnom;

        public Gestionnaire gestionnaire = new Gestionnaire();
        public Personne personne = new Personne("Emilie", "Echevin");
        public SystemeTelethonSTE()
        {
            InitializeComponent();
            txtID.Text = personne.Surnom;
        }

        private void btnAffPrix_Click(object sender, EventArgs e)
        {

        }

        private void btnAjoutDon_Click(object sender, EventArgs e)
        {

        }

        private void btnAjoutDonateur_Click(object sender, EventArgs e)
        {
            /*try
            {
                this.idDonateur = lblID.Text;
            }*/
        }
    }
}
