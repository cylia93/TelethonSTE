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

        public Prix(string idP, string desc, double val, double donMin, int qteOr, int qteDisp, string idC)
        {
            this.idPrix = idP;
            this.description = desc;
            this.valeur = 0;
            this.donMinimum = donMin;
            this.qnte_Originale = 0;
            this.qnte_Disponible = 0;
            this.idCommenditaire = idC;
        }

        public void Deduire(int qte)
        {
            this.qnte_Disponible -= qte;
        }

        public string IdPrix
        {
            get { return this.idPrix; }
            set { this.idPrix = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public double Valeur
        {
            get { return this.valeur; }
            set { this.valeur = value; }
        }

        public double DonMinimum
        {
            get { return this.donMinimum; }
            set { this.donMinimum = value; }
        }

        public int Qnte_Originale
        {
            get { return this.qnte_Originale; }
            set { this.qnte_Originale = value; }
        }

        public int Qnte_Disponible
        {
            get { return this.qnte_Disponible; }
            set { this.qnte_Disponible = value; }
        }

        public string IdCommenditaire
        {
            get { return this.idCommenditaire; }
            set { this.idCommenditaire = value; }
        }

        public override string ToString()
        {
            return " Le prix numero " + this.idPrix + " ," + this.description + "de valeur " + this.valeur +
                " de quantite initiale de " + this.qnte_Originale + " a ete fourni par " + this.idCommenditaire +
                " , il reste desormais " + this.qnte_Disponible + " a gagne pour un don minimum de " + this.donMinimum;
        }
    }
}

