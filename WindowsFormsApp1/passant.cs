using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class passant
    {
        private int numeroseq;
        private string nom;
        private string prenom;
        private long numerodossier;
        string typeExamen;
        string resultat;
        string observation;
        public passant(int nsq, string nom, string prenom, long num, string type, string res, string obs)
        {
            numeroseq = nsq;
            this.nom = nom;
            this.prenom = prenom;
            typeExamen = type;
            numerodossier = num;
            resultat = res;
            observation = obs;

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
        public void setnumerodossier(long numds)
        {
            this.numerodossier = numds;
        }
        public long getnumerodossier()
        {
            return numerodossier;
        }
        public string gettypeExamen()
        { return this.typeExamen; }
        public void setResultat(string res)
        { resultat = res; }
        public string getResultat()
        { return this.resultat; }
        public void setObservation(string obs)
        { observation = obs; }
        public string getObservation()
        { return this.observation; }
    }
}
