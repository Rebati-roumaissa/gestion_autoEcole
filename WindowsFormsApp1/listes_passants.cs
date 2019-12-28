using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class listes_passants : Form
    {
        DateTime date;
        methodes m = new methodes();
        public listes_passants(DateTime date)
        {
            this.date = date;
            InitializeComponent();
        }

        private void listes_passants_Load(object sender, EventArgs e)
        {
            panel1.Width = this.Width;
            panel1.Height= (this.Height - panel2.Height);
            Actualiser();
        }
        private void Actualiser()
        {
            listVieweleve_exam.Items.Clear();
            methodes m = new methodes();
            var list = new List<passant>();
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-En");
            list = m.getPassant(date);
            foreach (passant passant in list)
            {
                ListViewItem lvi = new ListViewItem(" ");
                lvi.SubItems.Add(passant.getObservation());
                lvi.SubItems.Add(passant.getResultat());
                lvi.SubItems.Add(passant.gettypeExamen());
                lvi.SubItems.Add(passant.getnumerodossier().ToString());
                lvi.SubItems.Add(passant.getprenom());
                lvi.SubItems.Add(passant.getnom());
                lvi.SubItems.Add(passant.getnsq().ToString());
                listVieweleve_exam.Items.Add(lvi);
            }
        }
        private List<passant> Listeviewtolist()
        {
            var list = new List<passant>();
            ListView.CheckedListViewItemCollection selected = listVieweleve_exam.CheckedItems;
            foreach (ListViewItem it in selected)
            { int nsq = Convert.ToInt32(it.SubItems[7].Text);string nom = it.SubItems[6].Text;
              long nds = Convert.ToInt64(it.SubItems[4].Text);
                string prenom = it.SubItems[5].Text;
                string type = it.SubItems[3].Text; string res = it.SubItems[2].Text;string obs = it.SubItems[1].Text;
                passant passant = new passant(nsq, nom, prenom, nds, type, res, obs);
               list.Add(passant);
            }
            return list;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            m.addpassantresultat(Listeviewtolist(), "Reussite");
            Actualiser();
        }

        private void perdrebutton_Click(object sender, EventArgs e)
        {
            m.addpassantresultat(Listeviewtolist(), "Echec");
            Actualiser();
        }

        private void justifiantbutton_Click(object sender, EventArgs e)
        {
            m.addpassantobservation(Listeviewtolist(), "Absence avec justification");
            Actualiser();
        }

        private void absentbutton_Click(object sender, EventArgs e)
        {
            m.addpassantobservation(Listeviewtolist(),"Absence sans justification");
            Actualiser();
        }

        private void listVieweleve_exam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
