using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Examen
    {
        int id;
        string examinateur;
        DateTime dateexamen;
        string typeExamen;
        string resultat;
        string observation;
        public Examen(int id, string examinateur, DateTime dateexamen, string type, string resultat, string observation)
        {
            this.id = id;
            this.examinateur = examinateur;
            this.dateexamen = dateexamen;
            this.typeExamen = type;
            this.resultat = resultat;
            this.observation = observation;
        }
        public Examen(string examinateur, DateTime dateexamen, string type)
        {
            this.examinateur = examinateur;
            this.dateexamen = dateexamen;
            this.typeExamen = type;
          
        }
        public Examen(string examinateur, DateTime dateexamen)
        {
            this.examinateur = examinateur;
            this.dateexamen = dateexamen;
        }
        public Examen(int id,string examinateur, DateTime dateexamen)
        {
            this.examinateur = examinateur;
            this.dateexamen = dateexamen;
            this.id = id;
          
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }
        public void setExaminateur(string examin)
        { examinateur = examin; }
        public string getExaminateur()
        { return this.examinateur; }
        public void setDateExamen(DateTime date)
        { dateexamen = date; }
        public DateTime getDateExamen()
        { return this.dateexamen; }
        public void settypeExamen(string typeExam)
        { typeExamen =  typeExam; }
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
