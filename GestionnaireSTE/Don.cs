using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireSTE
{
    public class Don
    {
        private string idDon;
        private string dateDuDon;
        private string idDonateurDon;
        private double montantDuDon;
        private string idPrixDon;

        public Don() { }

        public Don(string idDon, string dateDuDon, string idDonateurDon, double montantDuDon, string idPrixDon)
        {
            this.idDon = idDon;
            this.dateDuDon = dateDuDon;
            this.idDonateurDon = idDonateurDon;
            this.montantDuDon = montantDuDon;
            this.idPrixDon = idPrixDon;
        }

        public string IDDon
        {
            get { return idDon; }
            set { idDon = value; }
        }

        public string DateDuDon
        {
            get { return dateDuDon; }
            set { dateDuDon = value; }
        }

        public string IdDonateurDon
        {
            get { return idDonateurDon; }
            set { idDonateurDon = value; }
        }

        public double MontantDuDon
        {
            get { return montantDuDon; }
            set { this.montantDuDon = value; }
        }

        public string IdPrixDon
        {
            get { return this.idPrixDon; }
            set { this.idPrixDon = value; }
        }

        public override string ToString()
        {
            return "ID numero " + this.idPrixDon + " a ete gagne par " + this.idDonateurDon + " grace au don " + idDon +
                "d'un montant de " + this.montantDuDon + " fait en date du " + this.dateDuDon;

        }

    }
}
