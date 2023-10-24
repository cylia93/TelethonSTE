using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace GestionnaireSTE
{
    public class Commanditaire : Personne
    {
        private string IDCommanditaire;

        public Commanditaire(string prenom, string surnom, string IDCommanditaire) : base(prenom, surnom)
        {
            this.IDCommanditaire = IDCommanditaire;
        }

        [Name("IDCommanditaire")]
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
