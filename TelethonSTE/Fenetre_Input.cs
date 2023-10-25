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

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
