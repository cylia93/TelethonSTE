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
    public partial class Reponse_Prix : Form
    {
        public Reponse_Prix()
        {
            InitializeComponent();
        }

        public string InfoSurlesPrix
        {
            get { return lblInfo.Text; }
            set { lblInfo.Text = value; }
        }

        public string TxtReponsePrix
        {
            get { return txtReponsePrix.Text; }
            set { txtReponsePrix.Text = value; }
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
