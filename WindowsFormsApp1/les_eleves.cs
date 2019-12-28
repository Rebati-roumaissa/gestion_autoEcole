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
    public partial class les_eleves : Form
    {
        int id_eleve;
        public les_eleves()
        {
            InitializeComponent();
           
        }

        private void les_eleves_Load(object sender, EventArgs e)
        {
            
            actualiser();
            }
        public void actualiser()
        {
            listVieweleves.Items.Clear();
            methodes m = new methodes();
            var list = new List<Eleve>();
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-En");
            list = m.GetEleves();
            foreach (var eleve in list)
            {

                ListViewItem lvi = new ListViewItem(" ");
                lvi.SubItems.Add(eleve.getrmrq());
                lvi.SubItems.Add(eleve.getexamin());
                if (eleve.getds() != DateTime.MinValue)
                { lvi.SubItems.Add(eleve.getds().Date.ToString("dd/MM/yyyy")); }
                else lvi.SubItems.Add("");
                lvi.SubItems.Add(eleve.getdent().Date.ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(eleve.getnumerodossier().ToString());
                lvi.SubItems.Add(eleve.getlns());
                lvi.SubItems.Add(eleve.getdns().Date.ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(eleve.getadresse());
                lvi.SubItems.Add(eleve.getnomparent());
                lvi.SubItems.Add(eleve.getnom());
                lvi.SubItems.Add(eleve.getprenom());
                lvi.SubItems.Add(eleve.getnsq().ToString());
                listVieweleves.Items.Add(lvi);
            }
        }
        private List<Eleve> Listeviewtolist()
        {
            var list = new List<Eleve>();
            ListView.CheckedListViewItemCollection selected = listVieweleves.CheckedItems;
            foreach (ListViewItem it in selected)
            {
              
                Eleve eleve=new Eleve(Convert.ToInt32(it.SubItems[12].Text), it.SubItems[10].Text, it.SubItems[11].Text, it.SubItems[9].Text,
                    Convert.ToDateTime(it.SubItems[7].Text), it.SubItems[6].Text, it.SubItems[8].Text, Convert.ToDateTime(it.SubItems[4].Text));
                list.Add(eleve);
            }
            return list;
        }
        private void listVieweleves_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listVieweleves.SelectedItems.Count == 0)
                return;
            id_eleve = Convert.ToInt32(this.listVieweleves.SelectedItems[0].SubItems[12].Text);
            eleve_gestionnaire eleve_Gestionnaire = new eleve_gestionnaire(id_eleve);
            this.Hide();
            eleve_Gestionnaire.Show();

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            ajoutereleveform ajel = new ajoutereleveform(this);
            this.Hide();
            ajel.Show();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            DialogResult reslt = MessageBox.Show("Voullez-vous vraiment supprimer  ", "Confirmation", MessageBoxButtons.YesNo);
            if (reslt == DialogResult.Yes)
            {
                methodes m = new methodes();
                List<Eleve> list = new List<Eleve>();
                list = Listeviewtolist();
                m.deleteListeEleve(list);
                actualiser();
            }
        }
    }
}
