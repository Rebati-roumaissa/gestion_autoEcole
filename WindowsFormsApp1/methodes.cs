using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
   
    class methodes
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        CultureInfo culture = CultureInfo.CreateSpecificCulture("en-En");

        public int save_student(string nom, string prenom, string nomparent, DateTime datenaiss, string lieunais, string adr, DateTime datentree)
        {
            String query = "INSERT INTO eleve(Nom,Prenom,Nompere,DateNaissance,LieuNaissance,Adresse,DateEntree) output INSERTED.Nseq VALUES ( N'"
            + nom + "', N'" + prenom + "',N'" + nomparent + "',N'" + datenaiss.Date.ToString("G", culture) + "',N'"+ lieunais+ "',N'" + adr + "','" + datentree.Date.ToString("G", culture) + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            int id = 0;
            id = (int)cmd.ExecuteScalar();
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
            return id;
        }
        public Eleve recuperer_eleve(int nsq)
        {
            Eleve eleve= new Eleve();
            String query = "Select * from Eleve where eleve.Nseq='"+nsq+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            using (SqlDataReader myReader = cmd.ExecuteReader())
            {

                if (myReader.Read())
                {

                    int Nsq = myReader.GetInt32(myReader.GetOrdinal("Nseq"));
                    string nom = myReader["Nom"].ToString();
                    string prenom = myReader["Prenom"].ToString();
                    string prepere = myReader["Nompere"].ToString();
                    DateTime datenais = (DateTime)myReader["DateNaissance"];
                    string lieunais = myReader["LieuNaissance"].ToString();
                    string adr = myReader["Adresse"].ToString();
                    DateTime dateent = (DateTime)myReader["DateEntree"];
                    DateTime datesort;
                    string exam;
                    try
                    {
                        exam = myReader["Examinateur"].ToString();
                    }
                    catch
                    {
                        exam = "";
                    }
                    string rmrq;
                    try
                    {
                        rmrq = myReader["Remarques"].ToString();
                    }
                    catch { rmrq = ""; }
                   long nds;
                    try
                    {
                        nds = myReader.GetInt64(myReader.GetOrdinal("Numerodossier"));
                    }
                    catch { nds = 0; }
                    try { datesort = (DateTime)myReader["DateSortie"]; }
                    catch
                    {
                        datesort = DateTime.MinValue;
                    }
                    eleve = new Eleve(Nsq, nom, prenom, prepere, datenais, lieunais, adr, dateent);
                    eleve.setds(datesort);
                    eleve.setexamin(exam);
                    eleve.setrmrq(rmrq);
                    eleve.setnumerodossier(nds);
                }

            }
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
            return eleve;
        }
        public int recuperer_examen(DateTime date,string examin)
        {
            string query = "Select id from examen where examen.dateExamen='" + date.ToString("G", culture) + "'and examinateur= N'"+examin+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;int id=0;
            con.Open();
            using (SqlDataReader myReader = cmd.ExecuteReader())
            {

                if (myReader.Read())
                {
                   id=myReader.GetInt32(myReader.GetOrdinal("id"));
                }

            }
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
            return id;
        }
        public void modifier_eleve_numerodossier(Eleve eleve)
        {
                String query = "Update eleve set Numerodossier=@numdossier,Nom=@nom,Prenom=@prenom,Nompere=@nompere,DateNaissance=@dtn," +
                "LieuNaissance=@ldn,Adresse=@adr,DateEntree=@de,Examinateur=@examin,Remarques=@rmq where eleve.Nseq=@nsq";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nsq", eleve.getnsq());
            cmd.Parameters.AddWithValue("@numdossier", eleve.getnumerodossier());
            cmd.Parameters.AddWithValue("@nom", eleve.getnom());
            cmd.Parameters.AddWithValue("@prenom", eleve.getprenom());
            cmd.Parameters.AddWithValue("@nompere", eleve.getnomparent());
            cmd.Parameters.AddWithValue("@dtn", eleve.getdns().Date.ToString("G", culture));
            cmd.Parameters.AddWithValue("@ldn", eleve.getlns());
            cmd.Parameters.AddWithValue("@adr", eleve.getadresse());
            cmd.Parameters.AddWithValue("@de", eleve.getdent().Date.ToString("G", culture));
            cmd.Parameters.AddWithValue("@examin", eleve.getexamin());
            cmd.Parameters.AddWithValue("@rmq", eleve.getrmrq());
            cmd.ExecuteNonQuery();
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();

        }
       public void modifier_eleve_datesortie(Eleve eleve)
        {
                String query = "Update eleve set Numerodossier=@numdossier,Nom=@nom,Prenom=@prenom,Nompere=@nompere,DateNaissance=@dtn," +
                "LieuNaissance=@ldn,Adresse=@adr,DateSortie=@ds,DateEntree=@de,Examinateur=@examin,Remarques=@rmq where eleve.Nseq=@nsq";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nsq", eleve.getnsq());
            cmd.Parameters.AddWithValue("@numdossier", eleve.getnumerodossier());
            cmd.Parameters.AddWithValue("@nom", eleve.getnom());
            cmd.Parameters.AddWithValue("@prenom", eleve.getprenom());
            cmd.Parameters.AddWithValue("@nompere", eleve.getnomparent());
            cmd.Parameters.AddWithValue("@dtn", eleve.getdns().Date.ToString("G", culture));
            cmd.Parameters.AddWithValue("@ldn", eleve.getlns());
            cmd.Parameters.AddWithValue("@adr", eleve.getadresse());
            cmd.Parameters.AddWithValue("@de", eleve.getdent().Date.ToString("G", culture));
            cmd.Parameters.AddWithValue("@ds", eleve.getds().Date.ToString("G", culture));
            cmd.Parameters.AddWithValue("@examin", eleve.getexamin());
            cmd.Parameters.AddWithValue("@rmq", eleve.getrmrq());
            cmd.ExecuteNonQuery();
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();

        }
        public void modifier_eleve(Eleve eleve)
        {
            String query = "Update eleve set Nom=@nom,Prenom=@prenom,Nompere=@nompere,DateNaissance=@dtn," +
                "LieuNaissance=@ldn,Adresse=@adr,DateEntree=@de,Examinateur=@examin,Remarques=@rmq where eleve.Nseq=@nsq";
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@nom", eleve.getnom());
            command.Parameters.AddWithValue("@prenom", eleve.getprenom());
            command.Parameters.AddWithValue("@nompere", eleve.getnomparent());
            command.Parameters.AddWithValue("@dtn", eleve.getdns().Date.ToString("G", culture));
            command.Parameters.AddWithValue("@ldn", eleve.getlns());
            command.Parameters.AddWithValue("@adr", eleve.getadresse());
            command.Parameters.AddWithValue("@de", eleve.getdent().Date.ToString("G", culture));
            command.Parameters.AddWithValue("@nsq", eleve.getnsq());
            command.Parameters.AddWithValue("@examin", eleve.getexamin());
            command.Parameters.AddWithValue("@rmq", eleve.getrmrq());
            command.ExecuteNonQuery();
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
        public void modifier_examen(Examen examen)
        {
            String query = "Update examen set examinateur=@examinateur,DateExamen=@de where examen.id=@id";
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
         
            command.Parameters.AddWithValue("@de", examen.getDateExamen().Date.ToString("G", culture));
            command.Parameters.AddWithValue("@id", examen.getId());
            command.Parameters.AddWithValue("@examinateur", examen.getExaminateur());
            command.ExecuteNonQuery();
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
        public int save_examen(String examinateur,DateTime dateexamen)
        {
            String query = "INSERT INTO examen(examinateur,dateExamen) output INSERTED.Id VALUES ( N'"
            + examinateur +"','" + dateexamen.Date.ToString("G", culture) +"')";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            int id = 0;
            id = (int)cmd.ExecuteScalar();
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
            return id;
        }
        public List<Eleve> GetEleves()
        {
           
            var list = new List<Eleve>();
            String qry = "SELECT * FROM eleve";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            using (SqlDataReader myReader = cmd.ExecuteReader())
            {
                
                 while (myReader.Read())
                {
                   
                    int Nsq = myReader.GetInt32(myReader.GetOrdinal("Nseq"));
                    string nom = myReader["Nom"].ToString();
                    string prenom = myReader["Prenom"].ToString();
                    string prepere = myReader["Nompere"].ToString();
                    DateTime  datenais= (DateTime)myReader["DateNaissance"];
                    string lieunais = myReader["LieuNaissance"].ToString();
                    string adr= myReader["Adresse"].ToString();
                    DateTime dateent = (DateTime)myReader["DateEntree"];
                    DateTime datesort;
                    string exam;
                    try
                    {
                        exam = myReader["Examinateur"].ToString();
                    }
                    catch
                    {  exam = ""; }
                    string rmrq;
                    try
                    {
                        rmrq = myReader["Remarques"].ToString();
                    }
                    catch { rmrq = ""; }
                    long nds;
                        try
                    { nds = myReader.GetInt64(myReader.GetOrdinal("Numerodossier")); }
                    catch { nds = 0; }
                    try { datesort = (DateTime)myReader["DateSortie"]; }
                    catch
                    { datesort = DateTime.MinValue;  }
                    Eleve eleve = new Eleve(Nsq, nom, prenom, prepere, datenais, lieunais, adr, dateent);
                    eleve.setds(datesort);
                    eleve.setexamin(exam); 
                    eleve.setrmrq(rmrq);
                    eleve.setnumerodossier(nds); 
                    list.Add(eleve);
                }
                
            }
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
            return list;
        }
        public List<Examen> GetExamens_eleve(int id_eleve)
        {
             var list = new List<Examen>();
            String qry = "SELECT id_examen,typeExamen,resultat,observations,examinateur,dateExamen FROM passer Join examen ON passer.id_examen = examen.id where passer.Nsq='"+id_eleve+"'";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            using (SqlDataReader myReader = cmd.ExecuteReader())
            {
                
                while (myReader.Read())
                {
                  
                    int id= myReader.GetInt32(myReader.GetOrdinal("id_examen"));
                    string type = myReader["typeExamen"].ToString();
                    string resultat;
                    try
                    {
                        resultat = myReader["resultat"].ToString();
                    }
                    catch { resultat = ""; }
                    string observations;
                    try { observations = myReader["observations"].ToString(); }
                    catch { observations = ""; }
                    DateTime date = (DateTime)myReader["dateExamen"];
                    string examinateur = myReader["Examinateur"].ToString();
                    Examen examen = new Examen(id, examinateur, date, type, resultat, observations);
                    list.Add(examen);
                }

            }
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
            return list;
        }
        public void deleteListeEleve(List<Eleve> list)
        {
           
            foreach (Eleve eleve in list)
            {
               
                String query = "Delete from eleve WHERE Nseq='" + eleve.getnsq() + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void deleteListeExamen(List<Examen> list)
        {

            foreach (Examen examen in list)
            {
                
                String query = "Delete from examen WHERE id='" + examen.getId() + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public List<Examen> GetExamens()
        {
            var list=new List<Examen>();
            
            String qry = "SELECT Id,examinateur,dateExamen FROM examen ";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            using (SqlDataReader myReader = cmd.ExecuteReader())
            {

                while (myReader.Read())
                {
                    int id = myReader.GetInt32(myReader.GetOrdinal("Id"));
                    DateTime date = (DateTime)myReader["dateExamen"];
                    string examinateur = myReader["Examinateur"].ToString();
                    Examen examen = new Examen(id, examinateur, date);
                    list.Add(examen);
                }

            }
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
            return list;
        }
        public bool paiementregle(int id)
        {
            if (recupererPaiement(id).getReste() > 0)
                return false;
            else return true;
        }
        public void addpassage(List<Eleve> list, Examen examen)
        {
            foreach (Eleve eleve in list)
            {
                
                if (examen.gettypeExamen() == "conduite" ) 
                {
                    
                    if (Adulte(eleve.getdns()) == false)
                        MessageBox.Show(eleve.getnom() + " " + eleve.getprenom()+"  "+" ne sera pas ajouté à la liste puisqu'il n'a pas encore 18 ans"
                        );
                    else
                    {
                        if (!paiementregle(eleve.getnsq()))
                        {
                            MessageBox.Show(eleve.getnom() + " " + eleve.getprenom() + "  " + "ne sera pas ajouté à la liste  puisqu'il n'a pas payé tous ses frais");
                        }
                        else
                        {
                            String query = "INSERT INTO passer(Nsq,Id_examen,typeexamen) VALUES ( N'"
           + eleve.getnsq() + "', N'" + examen.getId() + "',N'" + examen.gettypeExamen() + "')";

                            SqlCommand cmd = new SqlCommand(query, con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
                else
                {
                    String query = "INSERT INTO passer(Nsq,Id_examen,typeexamen) VALUES ( N'"
            + eleve.getnsq() + "', N'" + examen.getId() + "',N'" + examen.gettypeExamen() + "')";

                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        public bool Adulte(DateTime datenaissance)
        {
            bool adulte=false;
            DateTime today = DateTime.Today;
            int age = today.Year - datenaissance.Year;    //people perceive their age in years

            if (today.Month < datenaissance.Month ||
               ((today.Month == datenaissance.Month) && (today.Day < datenaissance.Day)))
            {
                age--;  //birthday in current year not yet reached, we are 1 year younger ;)
                        //+ no birthday for 29.2. guys ... sorry, just wrong date for birth
            }
            if (age>=18) { adulte = true; }
            return adulte;
        }
        public List<passant> getPassant(DateTime date)
        {
            List<passant> passants = new List<passant>();
            String qry = "SELECT Nsq,Nom,Prenom,Numerodossier,typeExamen,resultat,observations FROM passer Join examen ON passer.id_examen = examen.id Join eleve ON passer.Nsq=eleve.Nseq where examen.dateExamen='" + date.Date.ToString("G", culture) + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            using (SqlDataReader myReader = cmd.ExecuteReader())
            {
                while (myReader.Read())
                {
                   
                    int nsq = myReader.GetInt32(myReader.GetOrdinal("Nsq"));
                    string type = myReader["typeExamen"].ToString();
                    string nom = myReader["Nom"].ToString();
                    string prenom = myReader["Prenom"].ToString();
                    long nds;
                    try
                    { nds = myReader.GetInt64(myReader.GetOrdinal("Numerodossier")); }
                    catch { nds = 0; }
                    string resultat;
                    try
                    {
                        resultat = myReader["resultat"].ToString();
                    }
                    catch { resultat = ""; }
                    string observations; 
                    try { observations = myReader["observations"].ToString(); }
                    catch { observations = ""; }
                    passant passant = new  passant(nsq,nom,prenom,nds,type,resultat,observations);
                    passants.Add(passant);
                }

            }
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
            return passants;
         }
        public void savePaiement(Paiement paiement)
        {
            String query = "INSERT INTO paiement(eleve,montant) output INSERTED.Id VALUES ( '"
          + paiement.getnsq()+ "', '" + paiement.getMontant() + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            int id = 0;
            id = (int)cmd.ExecuteScalar();
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
            paiement.setId(id);
        }
        public void addtransit1(int idEleve, int transit1)
        {
            String query = "Update paiement set transit1=@transit1,reste=montant-@transit1-transit2-transit3 where paiement.eleve=@idEleve";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@transit1", transit1);
            cmd.Parameters.AddWithValue("@idEleve", idEleve);
            cmd.ExecuteNonQuery();
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
        public void addtransit2(int idEleve,int transit2)
        {
            String query = "Update paiement set transit2=@transit2,reste=montant-transit1-@transit2-transit3 where paiement.eleve=@idEleve";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@transit2", transit2);
            cmd.Parameters.AddWithValue("@idEleve", idEleve);
            cmd.ExecuteNonQuery();
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();

        }
        public void addtransit3(int idEleve, int transit3)
        {
            String query = "Update paiement set transit3=@transit3,reste=montant-transit1-transit2-@transit3 where paiement.eleve=@idEleve";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@transit3", transit3);
            cmd.Parameters.AddWithValue("@idEleve", idEleve);
            cmd.ExecuteNonQuery();
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
        public Paiement recupererPaiement(int idEleve)
        {
            int id; int montant; int t1; int t2; int t3; int r;
               String qry = "SELECT montant,id,transit1,transit2,transit3,reste FROM paiement where paiement.eleve ='" + idEleve+"'";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                using (SqlDataReader myReader = cmd.ExecuteReader())
                {
                    myReader.Read();
                    id = myReader.GetInt32(myReader.GetOrdinal("id"));
                    montant = myReader.GetInt32(myReader.GetOrdinal("montant"));
                    t1 = myReader.GetInt32(myReader.GetOrdinal("transit1"));
                    t2 = myReader.GetInt32(myReader.GetOrdinal("transit2"));
                    t3 = myReader.GetInt32(myReader.GetOrdinal("transit3"));
                    if (t1 == 0 && t2 == 0 && t3 == 0) r = montant;
                    else r = myReader.GetInt32(myReader.GetOrdinal("reste"));
                }
            }
            catch
            {
                id = 0;montant = 0;t1 = 0;t2 = 0;t3 = 0;r = 0;
            }
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
            Paiement p = new Paiement(id, montant, t1, t2, t3, r);
            return p;
        }
        public bool exist_examen(DateTime date, String Examinateur)
        {
            try
            {   SqlDataAdapter adapter = new SqlDataAdapter("Select Count(*) From examen Where dateExamen='" + date.ToString("G", culture) + "'and examinateur=N'"+Examinateur+"'", con);
                DataTable table = new DataTable();
                adapter.Fill(table);//table d'une seule ligne qui contient le nombre d'élément retourné par la requete
                if (table.Rows[0][0].ToString() != "0")
                {//il existe au moins un élément
                    return true;
                }
                else

                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
              MessageBox.Show(ex.Message);
                return false;
            }
        }
        public List<Paiement> GetPaiements()
        {
            List<Paiement> paiements = new List<Paiement>();
            String qry = "SELECT Nseq,Nom,Prenom,Nompere,Numerodossier,montant,transit1,transit2,transit3,reste FROM paiement Join eleve ON paiement.eleve = eleve.Nseq";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            using (SqlDataReader myReader = cmd.ExecuteReader())
            {
                while (myReader.Read())
                {
                    int nsq = myReader.GetInt32(myReader.GetOrdinal("Nseq"));
                    string nom = myReader["Nom"].ToString();
                    string prenom = myReader["Prenom"].ToString();
                    string papa = myReader["Nompere"].ToString();
                     long nds;
                    try
                    { nds = myReader.GetInt64(myReader.GetOrdinal("Numerodossier")); }
                    catch { nds = 0; }
                    int transit1 = myReader.GetInt32(myReader.GetOrdinal("transit1"));
                    int transit2 = myReader.GetInt32(myReader.GetOrdinal("transit2"));
                    int transit3 = myReader.GetInt32(myReader.GetOrdinal("transit3"));
                    int reste = myReader.GetInt32(myReader.GetOrdinal("reste"));
                    int montant = myReader.GetInt32(myReader.GetOrdinal("montant"));
                    Paiement p = new Paiement(montant, transit1, transit2, transit3, reste, nom, prenom, papa, nds, nsq);
                    paiements.Add(p);
                }

            }
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
            return paiements;
        }
        public void addpassantresultat(List<passant> list, string resultat)
        {
            foreach (passant passant in list)
            {
               // hna je dois vérifier le nombre d'examen
                    String query = "update passer set resultat=N'"+resultat+"' where passer.Nsq='" + passant.getnsq() +"'";
                    
                    SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        public void addpassantobservation(List<passant> list, string observation)
        {
            foreach (passant passant in list)
            {
                // hna je dois vérifier le nombre d'examen
                String query = "update passer set observations=N'" + observation + "' where passer.Nsq='" + passant.getnsq() + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
            }
        }
        
    }
}
