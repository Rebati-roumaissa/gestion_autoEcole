using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Paiement
    {
        int id;string nom;string prenom;string papa;long numdossier;int ideleve;
        int montant, transit1, transit2, transit3, reste;
        public Paiement(int id, int montant, int transit1, int transit2, int transit3, int reste)
        {
            this.id = id;
            this.montant = montant;
            this.transit1 = transit1;
            this.transit2 = transit2;
            this.transit3 = transit3;
            this.reste = reste;

        }
        public Paiement()
        { }
        public Paiement(int montant, int transit1, int transit2, int transit3, int reste,string nom,string prenom,string papa, long numdossier, int ideleve)
        {
            
            this.montant = montant;
            this.transit1 = transit1;
            this.transit2 = transit2;
            this.transit3 = transit3;
            this.reste = reste;
            this.nom = nom;
            this.papa = papa;
            this.prenom = prenom;
            this.ideleve = ideleve;
            this.numdossier = numdossier;
        }
        public Paiement(int idEleve, int montant)
        {
            this.ideleve = idEleve;
            this.montant = montant;
            this.reste = this.montant - transit1 - transit2 - transit3;
        }
       
        public void setMontant(int montant)
        {
            this.montant = montant;
            this.reste = this.montant - transit1 - transit2 - transit3;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public void setTransit1(int transit1)
        {
            this.transit1 = transit1;
            this.reste = this.montant - transit1 - transit2 - transit3;
        }
        public void setTransit2(int transit2)
        {
            this.transit2 = transit2;
            this.reste = this.montant - transit1 - transit2 - transit3;
        }
        public void setTransit3(int transit3)
        {
            this.transit3 = transit3;
            this.reste = this.montant - transit1 - transit2 - transit3;
        }
        public int getMontant()
        {
            return this.montant;
        }
        public int getReste()
        {
            return this.reste;
        }
        public int getTransit1()
        {
          return  this.transit1;
        }
        public int getTransit2()
        {
          return  this.transit2;
        }
        public int getTransit3()
        {
          return  this.transit3;
        }
        public string getprenom()
        {
          return  this.prenom;
        }
        public string getnom()
        {
            return this.nom;
        }
        public string getpere()
        {
            return this.papa;
        }
        public long getnumdossier()
        {
            return this.numdossier;
        }
        public int getnsq()
        {
            return this.ideleve;
        }
        public void setnsq(int ideleve)
        {
            this.ideleve = ideleve;
        }
        
    }
}
