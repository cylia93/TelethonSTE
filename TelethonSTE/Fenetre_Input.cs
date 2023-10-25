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
    public partial class Fenetre_Input : Form
    {
        public Fenetre_Input()
        {
            InitializeComponent();

            // Attach the Shown event handler to the form
            this.Shown += Fenetre_Input_Shown;
        }

        public string InfoSurlesPrix
        {
            get { return lblInfo.Text; }
            set { lblInfo.Text = value; }
        }

        public string TxtReponse
        {
            get { return txtReponse.Text; }
            set { txtReponse.Text = value; }
        }

        private void Fenetre_Input_Shown(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void Fenetre_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
