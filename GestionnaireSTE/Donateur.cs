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
        public String ID
        {
            get { return idDonateur; }
            set { this.idDonateur = value; }
        }

        public override string ToString()
        {
            return " Identification " + this.idDonateur + ", " + base.ToString() + ",\r\n Adresse: " + this.adresse +
                " , \r\n Telephone: " + this.telephone + " , \r\n Type de carte de credit: " + this.typeDeCarte +
                " , numero de carte: " + this.numeroCarte + " , Date d'expiration: " + this.dateExpiration;
        }


        }
    
}
