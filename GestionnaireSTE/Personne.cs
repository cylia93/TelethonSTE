using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace GestionnaireSTE
{
    public class Personne
    {
        private string prenom;
        private string surnom;

        public Personne(string prenom, string surnom)
        {
            this.prenom = prenom;
            this.surnom = surnom;
        }

        [Name("prenom")]
        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }

        [Name("surnom")]
        public string Surnom
        {
            get { return this.surnom; }
            set { this.surnom = value; }
        }
        public override string ToString()
        {
            string nomComplet = this.prenom + " " + this.surnom;
            return nomComplet;
        }


    }
}

