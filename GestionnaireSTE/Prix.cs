using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireSTE
{
    public class Prix
    {
        private string idPrix;
        private string description;
        private double valeur;
        private double donMinimum;
        private int qnte_Originale;
        private int qnte_Disponible;
        private string idCommenditaire;

        public Prix() { }

        public Prix(string idPrix, string description, double valeur, double donMinimum, int qnte_Originale, int qnte_Disponible, string idCommenditaire)
        {
            this.idPrix = idPrix;
            this.description = description;
            this.valeur = valeur;
            this.donMinimum = donMinimum < 50 ? 50 : donMinimum;
            this.qnte_Originale = qnte_Originale;
            this.qnte_Disponible = qnte_Disponible;
            this.idCommenditaire = idCommenditaire;
        }

        public void Deduire(int qte)
        {
            if (this.IdPrix.Equals("N/A")) return;

            if(this.qnte_Disponible == 0)
            {
                throw new Exception("Ce prix est épuisé.");
            }
            if (this.qnte_Disponible - qte < 0)
            {
                throw new Exception("Il n'y a pas assez de ce prix disponible.");
            }
            this.qnte_Disponible -= qte;
        }

        [Name("idPrix")]
        public string IdPrix
        {
            get { return this.idPrix; }
            set { this.idPrix = value; }
        }

        [Name("description")]
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        [Name("valeur")]
        public double Valeur
        {
            get { return this.valeur; }
            set { this.valeur = value; }
        }

        [Name("donMinimum")]
        public double DonMinimum
        {
            get { return this.donMinimum; }
            set { this.donMinimum = value; }
        }

        [Name("qnte_Originale")]
        public int Qnte_Originale
        {
            get { return this.qnte_Originale; }
            set { this.qnte_Originale = value; }
        }

        [Name("qnte_Disponible")]
        public int Qnte_Disponible
        {
            get { return this.qnte_Disponible; }
            set { this.qnte_Disponible = value; }
        }

        [Name("idCommanditaire")]
        public string IdCommenditaire
        {
            get { return this.idCommenditaire; }
            set { this.idCommenditaire = value; }
        }

        public override string ToString()
        {
            return this.description + ", #" + this.idPrix + ", Valeur " + this.valeur +
                "$, Qté init. " + this.qnte_Originale + ", Qté dispo. " + this.qnte_Disponible + ", Don min. "+ this.donMinimum + "$, Commanditaire #" + this.idCommenditaire + "\r\n\r\n";
        }
    }
}

