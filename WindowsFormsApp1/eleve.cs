using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Eleve
    {
        private int numeroseq;
        private string nom;
        private string prenom;
        private string nomparent;
        private DateTime datedenaissance;
        private string lieudenaissance;
        private string adresse;
        private long numerodossier;
        private DateTime dateentree;
        private DateTime datesortie;
        private string remarques;
        private string examinateur;
        
        public Eleve()
        { }
        public Eleve(int nsq, string nom, string prenom, string nomparent,DateTime dns,string ldn,string adr,DateTime dent)
        {
            this.numeroseq = nsq;
            this.nom = nom;
            this.prenom = prenom;
            this.nomparent= nomparent;
            this.datedenaissance = dns;
            this.lieudenaissance = ldn;
            this.adresse = adr;
            this.dateentree = dent;
        }
        public void setnsq(int nsq)
        { this.numeroseq = nsq; }
        public int getnsq()
        { return numeroseq; }
        public void setnom(string nom)
        {
            this.nom = nom;
        }
        public string getnom()
        {
            return this.nom;
        }
        public void setprenom(string prenom)
        {
            this.prenom = prenom;
        }
        public string getprenom()
        {
            return this.prenom;
        }
        public void setnomparent(string nomparent)
        {
            this.nomparent = nomparent;
        }
        public string getnomparent()
        {
            return this.nomparent;
        }
        public void setadr(string adr)
        {
            this.adresse = adr;
        }
        public string getadresse()
        {
            return this.adresse;
        }
        public void setdns(DateTime dns)
        { this.datedenaissance = dns; }
        public DateTime getdns()
        {return this.datedenaissance; }
        public void setlns(string lns)
        { this.lieudenaissance = lns; }
        public string getlns()
        {return this.lieudenaissance; }

        public void setdent(DateTime dent)
        { this.dateentree = dent; }
        public DateTime getdent()
        { return this.dateentree; }
        public void setds(DateTime ds)
        { this.datesortie = ds; }
        public DateTime getds()
        { return this.datesortie; }
        public void setexamin(string examin)
        {
            this.examinateur = examin;
        }
        public string getexamin()
        {
            return this.examinateur;
        }
        public void setrmrq(string rmrq)
        {
            this.remarques = rmrq;
        }
        public string getrmrq()
        {
            return this.remarques;
        }
        public void setnumerodossier(long numds)
        {
            this.numerodossier = numds;
        }
        public long getnumerodossier()
        { return this.numerodossier; }
        public void addnumdossier(Eleve eleve, int numds)
        { eleve.setnumerodossier(numds); }
        public void setInformation(string nom, string prenom, string nomparent, DateTime dns, string ldn, string adr, DateTime dent, string obs,string examinateur)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.nomparent = nomparent;
            this.datedenaissance = dns;
            this.lieudenaissance = ldn;
            this.adresse = adr;
            this.dateentree = dent;
            this.remarques = obs;
            this.examinateur = examinateur;
        }
    }
}

