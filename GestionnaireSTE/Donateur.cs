using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireSTE
{
   
        public class Donateur : Personne
        {
        private String idDonateur;
        private String adresse;
        private String telephone;
        private char typeDeCarte;
        private String numeroCarte;
        private String dateExpiration;

        public Donateur (String prenom, String surnom , String idDonateur , String adresse , String telephone ,
            char typeDeCarte , String numeroCarte ,String dateExpiration) : base(prenom , surnom)
        {
            this.idDonateur = idDonateur;
            this.adresse = adresse;
            this.typeDeCarte = typeDeCarte; 
            this.telephone = telephone;
            this.numeroCarte = numeroCarte;
            this.dateExpiration = dateExpiration;
        }

        [Name("idDonateur")]
        public String ID
        {
            get { return idDonateur; }
            set { this.idDonateur = value; }
        }

        [Name("adresse")]
        public String Adresse
        {
            get { return adresse; }
            set { this.adresse = value; }
        }

        [Name("telephone")]
        public String Telephone
        {
            get { return telephone; }
            set { this.telephone = value; }
        }

        [Name("numeroCarte")]
        public String NumeroDeCarte
        {
            get { return numeroCarte; }
            set { this.numeroCarte = value; }
        }

        [Name("typeDeCarte")]
        public char TypeDeCarte
        {
            get { return typeDeCarte; }
        }

        [Name("dateExpiration")]
        public String DateExpiration
        {
            get { return dateExpiration; }
            set { this.dateExpiration = value; }
        }

        public override string ToString()
        {
            return " Identification " + this.idDonateur + ", " + base.ToString() + ", Adresse: " + this.adresse +
                " , Telephone: " + this.telephone + " , Type de carte de credit: " + this.typeDeCarte +
                " , numero de carte: " + this.numeroCarte + " , Date d'expiration: " + this.dateExpiration + "\r\n";
        }


        }
    
}
