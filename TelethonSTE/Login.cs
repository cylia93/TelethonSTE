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
        private int essai;
        public Login()
        {
            InitializeComponent();
        }

        private void bTnOK_Click(object sender, EventArgs e)
        {
            if (txtUtilisateur.Text == "STE" && txtMotPasse.Text == "admin")
            {
                this.Hide();
                new SystemeTelethonSTE().Show();
            }
            else if (essai == 2)
                Application.Exit();
            else
                essai++;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
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
