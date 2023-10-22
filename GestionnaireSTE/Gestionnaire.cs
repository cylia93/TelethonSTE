using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireSTE
{
    public class Gestionnaire
    {
        List<Donateur> donateurs = new List<Donateur>();
        List<Commanditaire> commanditaires = new List<Commanditaire>();
        List<Don> dons = new List<Don>();
        List<Prix> steprix = new List<Prix>();

        public List<Donateur> ListDonateurs
        {
            get { return this.donateurs; }
        }

        public List<Commanditaire> ListCommanditaires
        {
            get { return this.commanditaires; }
        }

        public List<Don> ListDons
        {
            get { return this.dons; }
        }

        public List<Prix> ListPrix
        {
            get { return this.steprix; }
        }

        public void AjouterDonateur(string prenom, string surnom, string idDonateur, string address, string phone, char carte, string numCarte, string exp)
        {
            for (int i = 0; i < donateurs.Count; i++)
            {
                if (idDonateur == donateurs[i].ID)
                {
                    throw new Exception("Un donateur avec cet ID existe deja");
                }
            }

            if (prenom == "" || surnom == "" || idDonateur == "" || address == "" || phone == "" || carte == ' ' || numCarte == "" || exp == "")
            {
                throw new FormatException("Un champ est vide, veuillez completer tous les champs");
            }
            if (prenom.Contains(',') || surnom.Contains(',') || idDonateur.Contains(',') || address.Contains(',') || phone.Contains(',') || numCarte.Contains(',') || exp.Contains(','))
            {
                throw new FormatException(" Vous ne pouvez pas utiliser de virgules dans les champs");
            }
            Donateur donateur = new Donateur(prenom, surnom, idDonateur, address, phone, carte, numCarte, exp);
            donateurs.Add(donateur);
        }

        public void AjouterCommanditaire(string prenom, string surnom, string idComm)
        {
            for (int i = 0; i < commanditaires.Count; i++)
            {
                if (idComm == commanditaires[i].IDComm)
                {
                    throw new Exception("Un commanditaire avec cet ID existe deja");
                }
            }
            if (prenom == "" || surnom == "" || idComm == "")
            {
                throw new FormatException("Un champ est vide, veuillez completer tous les champs");
            }
            if (prenom.Contains(',') || surnom.Contains(',') || idComm.Contains(','))
            {
                throw new FormatException(" Vous ne pouvez pas utiliser de virgules dans les champs");
            }
            Commanditaire commanditaire = new Commanditaire(prenom, surnom, idComm);
            commanditaires.Add(commanditaire);
        }

        public void AjouterPrix(string idP, string desc, double val, double donMin, int qteOr, int qteDisp, string idC)
        {
            for (int i = 0; i < steprix.Count; i++)
            {
                if (idP == steprix[i].IdPrix)
                {
                    throw new Exception("Un prix avec cet ID existe deja.");
                }
            }

            if (idP == "" || desc == "" ||  idC == "")
            {
                throw new FormatException("Un champ est vide, veuillez completer tous les champs.");
            }

            if ( val <= 0 || donMin <= 0)
            {
                throw new FormatException("Vous devez donner une valeur positive.");
            }
            if (qteOr <= 0)
            {
                throw new FormatException("Vous devez donne au moins 1 prix - quantite invalide.");
            }


            if (idP.Contains(',') || idC.Contains(','))
            {
                throw new FormatException(" Vous ne pouvez pas utiliser de virgules dans les champs ID.");
            }

            Prix prix = new Prix(idP, desc, val, donMin, qteOr, qteDisp, idC);
            steprix.Add(prix);
        }

        public void AjouterDon(string idDon, string dateDuDon, string idDonateur, double montantDuDon, string idPrix)
        {
            for (int i = 0; i < dons.Count; i++)
            {
                if (idDon == dons[i].IDDon)
                {
                    throw new Exception("Un don avec cet ID existe deja");
                }
            }

            if (idDon == "" || dateDuDon == "" || idDonateur == "" || montantDuDon == null || idPrix == "")
            {
                throw new FormatException("Un champ est vide, veuillez completer tous les champs");
            }
            if (idDon.Contains(',') || dateDuDon.Contains(',') || idDonateur.Contains(',') || idPrix.Contains(','))
            {
                throw new FormatException(" Vous ne pouvez pas utiliser de virgules dans les champs");
            }
            Don don = new Don(idDon, dateDuDon, idDonateur, montantDuDon, idPrix);
            dons.Add(don);
        }

        public string AfficherDonateurs()
        {
            string listeDonateurs = "";
            foreach (Donateur donateur in donateurs)
            {
                listeDonateurs = listeDonateurs + donateur.ToString();
            }
            return listeDonateurs;
        }

        public string AfficherCommenditaires()
        {
            string listeCommanditaires = "La liste des commanditaires actuels:\r\n\r\n";
            foreach (Commanditaire commanditaire in commanditaires)
            {
                listeCommanditaires += commanditaire.ToString();
            }
            return listeCommanditaires;
        }

        public string AfficherPrix()
        {
            string listePrix = "La liste des prix actuels:\r\n\r\n";
            foreach (Prix prix in steprix)
            {
                listePrix = listePrix + prix.ToString();
            }
            return listePrix;
        }

        public string AfficherDons()
        {
            string listeDons = "La liste des dons actuels:\r\n\r\n";
            foreach (Don don in dons)
            {
                listeDons = listeDons + don.ToString();
            }
            return listeDons;
        }

        public Boolean AttribuerPrix(double donMin)
        {
            return false;
        }

        public Boolean EnregistrerDonateur()
        {
            return true;
        }

        public T trouverID<T>(Func<T, string> getID, string id, List<T> values) where T : class
        {
            int cnt = 0;

            while (values.Count > 0 && cnt < values.Count)
            {
                string refValue = getID(values[cnt]).ToLower();

                //Pour une correspondance exacte :
                if (refValue.Equals(id.ToLower()))
                {
                    return values[cnt];
                }
                cnt++;
            }
            return null;
        }

        public T trouverPersonne<T>(Func<T, string> getNom, Func<T, string> getPrenom, string nom, string prenom, List<T> values) where T : class
        {
            int cnt = 0;

            while (values.Count > 0 && cnt < values.Count)
            {
                string refNom = getNom(values[cnt]);
                string refPrenom = getPrenom(values[cnt]);

                //Pour une correspondance partielle sur les nom et prenom :
                if (refNom != null && refPrenom != null &&
                refNom.IndexOf(nom, StringComparison.OrdinalIgnoreCase) >= 0
                &&
                refPrenom.IndexOf(prenom, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    return values[cnt];
                }
                cnt++;
            }
            return null;
        }

    }
}
