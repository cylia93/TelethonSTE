using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireSTE
{
    public class Commanditaire : Personne
    {
        private string IDCommanditaire;

        public Commanditaire(string prenom, string surnom, string iDCommanditaire) : base(prenom, surnom)
        {
            IDCommanditaire = iDCommanditaire;
        }

        public string IDComm
        {
            get { return this.IDCommanditaire; }
            set { this.IDCommanditaire = value; }
        }

        public override string ToString()
        {
            return base.ToString() + ", "+ " Identification " + this.IDCommanditaire+ "\r\n\r\n";
        }
    }
}
