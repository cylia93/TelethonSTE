using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelethonSTE
{
    public partial class Login : Form
    {
        int nbrTentatives = 3;

        public Login()
        {
            InitializeComponent();
            /*this.FormBorderStyle = FormBorderStyle.FixedSingle; */
        }

        private void bTnOK_Click(object sender, EventArgs e)
        {
            // Récupération des valeurs saisies par l'utilisateur en lettres minuscules.
            string utilisateur = txtUtilisateur.Text.Trim();
            string motPasse = txtMotPasse.Text.Trim().ToLower();
            // On vérifie si les valeurs saisies sont vides ou des valeurs nulles.
            // S'il y a des valeurs dans nos éléments TextBox....
            if (!String.IsNullOrEmpty(utilisateur) &&
            !String.IsNullOrEmpty(motPasse))
            {
                // Si les variables contiennent des valeurs, comparaison avec les valeurs attendues.
                if (utilisateur == "STE" && motPasse == "admin")
                {
                    // Si les valeurs saisies sont valides, nous souhaitons la bienvenue à l'utilisateur.
                    MessageBox.Show("Bienvenue  au système de gestion du Téléthon", "Accès validé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new SystemeTelethonSTE().Show();

                    // On reintialise le nombre de tentatives pour le prochain utilisateur :
                    nbrTentatives = 3;
                }
                else
                {
                    nbrTentatives--;

                    string msg = "Les informations saisies ne sont pas valides. ";

                    if (nbrTentatives > 0) msg += "(encore " + nbrTentatives + " tentative(s)";

                    MessageBox.Show(msg, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtUtilisateur.Text = String.Empty; txtMotPasse.Text = String.Empty; txtUtilisateur.Focus();

                    if (nbrTentatives == 0)
                    {
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous devez saisir votre nom d'utilisateur et votre mot de passe.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Nous redonnons le focus à l'élément txtUtilisateur. txtUtilisateur.Focus();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Desirez-vous réellement quitter cette application?",
            "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
