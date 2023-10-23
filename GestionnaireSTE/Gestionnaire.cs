using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
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
                    throw new Exception("Un donateur avec cet ID existe deja.");
                }
            }

            if (prenom == "" || surnom == "" || idDonateur == "" || address == "" || phone == "" || carte == ' ' || numCarte == "" || exp == "")
            {
                throw new FormatException("Un champ est vide, veuillez completer tous les champs.");
            }

            if (ContientCharacteresSpeciaux(prenom) || ContientCharacteresSpeciaux(surnom) || ContientCharacteresSpeciaux(idDonateur) || ContientCharacteresSpeciaux(address) || ContientCharacteresSpeciaux(phone) || ContientCharacteresSpeciaux(numCarte))
            {
                throw new FormatException("Les caracteres speciaux ne sont pas permis.");
            }
            if (numCarte.Length != 16)
            {
                throw new FormatException("Le numero de la carte doit contenir 16 chiffres.");
            }
            if (!Double.TryParse(numCarte, out double numeroDeCarte))
            {
                throw new FormatException("La carte de credit doit etre une valeur numerique.");
            }

            // On valide que la carte de credit proposee est valide :

            DateTime dateExpiration =  DateTime.ParseExact(exp, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime dateActuelle = DateTime.Now;

            int monthsDifference = (dateExpiration.Year - dateActuelle.Year) * 12 + dateExpiration.Month - dateActuelle.Month;

            if (monthsDifference < 7)
            {
                throw new FormatException("La date d'expiration de votre carte de credit doit etre d'au moins 6 mois apres la date d'aujourd'hui.");
            }


            if (prenom.Contains(',') || surnom.Contains(',') || idDonateur.Contains(',') || address.Contains(',') || phone.Contains(',') || numCarte.Contains(',') || exp.Contains(','))
            {
                throw new FormatException(" Vous ne pouvez pas utiliser de virgules dans les champs.");
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
            if (ContientCharacteresSpeciaux(prenom) || ContientCharacteresSpeciaux(surnom) || ContientCharacteresSpeciaux(idComm))
            {
                throw new FormatException("Les caracteres speciaux ne sont pas permis.");
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
            if (ContientCharacteresSpeciaux(idP) || ContientCharacteresSpeciaux(desc) || ContientCharacteresSpeciaux(idC))
            {
                throw new FormatException("Les caracteres speciaux ne sont pas permis.");
            }

            if ( val <= 0 || donMin <= 0)
            {
                throw new FormatException("Vous devez donner une valeur positive.");
            }
            if (qteOr <= 0)
            {
                throw new FormatException("Vous devez donne au moins 1 prix - quantite invalide.");
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
            if (idDon == "" || dateDuDon == "" || idDonateur == "" || montantDuDon < 0 || idPrix == "")
            {
                throw new FormatException("Un champ est vide, veuillez completer tous les champs");
            }
            if (ContientCharacteresSpeciaux(idDon) || ContientCharacteresSpeciaux(idDonateur))
            {
                throw new FormatException("Les caracteres speciaux ne sont pas permis.");
            }

            Don don = new Don(idDon, dateDuDon, idDonateur, montantDuDon, idPrix);
            dons.Add(don);
        }

        public string AfficherDonateurs()
        {
            string listeDonateurs = "La liste des donateurs actuels:\r\n\r\n";
            foreach (Donateur donateur in donateurs)
            {
                listeDonateurs += donateur.ToString();
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


        public string AfficherPrix(double montant)
        {
            string listePrix = "La liste des prix elligibles pour ce don :\r\n\r\n";
            foreach (Prix prix in steprix)
            {
                if(montant >= prix.DonMinimum && prix.Qnte_Disponible > 0)
                {
                    listePrix += listePrix + prix.ToString();
                }
            }
            return listePrix;
        }

        public int determinerNbrPrix (double montant)
        {
            if(montant < 50)
            {
                return 0;
            } 
            else if( montant < 200 && montant >= 50)
            {
                return 1;
            }            
            else if( montant < 350 && montant >= 200)
            {
                return 2;
            }            
            else if( montant < 500 && montant >= 350)
            {
                return 3;
            } else
            {
                return 4;
            }
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

        public Boolean AttribuerPrix(double montant)
        {
            foreach (Prix prix in steprix)
            {
                if (montant >= prix.DonMinimum)
                    return true;
            }
            return false;
        }

        public Boolean EnregistrerDonateur()
        {
            return true;
        }

        // Methodes utilitaires :

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

        public bool ContientCharacteresSpeciaux(string input)
        {
            return Regex.IsMatch(input, @"[^a-zA-Z0-9\s]");
        }

    }
}
