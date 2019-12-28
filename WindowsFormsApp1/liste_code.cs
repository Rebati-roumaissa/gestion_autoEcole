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
    public partial class liste_code : Form
    {
        Examen examen; bool frommodifier;Ajouter_examen aje;modifierExamen modifierExamen;
        public liste_code(Ajouter_examen aje, Examen examen)
        {
            this.aje = new Ajouter_examen();
            this.aje = aje;
            frommodifier = false;
            this.examen = new Examen(examen.getExaminateur(), examen.getDateExamen(), examen.gettypeExamen());
            this.examen.setId(examen.getId());
            InitializeComponent();
        }
        public liste_code(modifierExamen modifierExamen, Examen examen,bool frm)
        {
            this.modifierExamen = new modifierExamen();
            this.modifierExamen = modifierExamen;
            frommodifier = frm;
            this.examen = new Examen(examen.getExaminateur(), examen.getDateExamen(), examen.gettypeExamen());
            this.examen.setId(examen.getId());
            InitializeComponent();
        }

        private void confirmerbutton_Click(object sender, EventArgs e)
        {
            
            methodes m = new methodes();
            List<Eleve> list = new List<Eleve>();
            list = Listeviewtolist();
            m.addpassage(list, examen);
        }

        private void liste_code_Load(object sender, EventArgs e)
        {
            panel1.Width = this.Width;
            panel1.Height = (this.Height - panel2.Height);
            Actualiser();
        }
        private void Actualiser()
        {
            listVieweleves.Width = this.Width;
            listVieweleves.Height = this.Height;
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
                // lvi.Tag = eleve;
                listVieweleves.Items.Add(lvi);
            }
        }
        private List<Eleve> Listeviewtolist()
        {
            var list = new List<Eleve>();
            ListView.CheckedListViewItemCollection selected = listVieweleves.CheckedItems;
            foreach (ListViewItem it in selected)
            {
               
                Eleve eleve = new Eleve(Convert.ToInt32(it.SubItems[12].Text), it.SubItems[10].Text, it.SubItems[11].Text, it.SubItems[9].Text,
                    Convert.ToDateTime(it.SubItems[7].Text), it.SubItems[6].Text, it.SubItems[8].Text, Convert.ToDateTime(it.SubItems[4].Text));
               
                list.Add(eleve);
            }
            return list;
        }

        private void confirmerbutton_Click_1(object sender, EventArgs e)
        {
            methodes m = new methodes();
            List<Eleve> list = new List<Eleve>();
            list = Listeviewtolist();
            m.addpassage(list, examen);
            if (frommodifier == false) {
                aje.Show();
                this.Close();
                    }
            else
            {
                modifierExamen.Show();
                this.Close();
            }
        }

        private void Annulerbutton_Click(object sender, EventArgs e)
        {
            if (frommodifier == false)
            {
                aje.Show();
                this.Close();
            }
            else
            {
                modifierExamen.Show();
                this.Close();
            }
            }

        private void listVieweleves_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
