using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class examen_gestionnaire : Form
    {
        methodes m = new methodes();
        CultureInfo culture = CultureInfo.CreateSpecificCulture("en-En");

        public examen_gestionnaire()
        {
            InitializeComponent();
        }

       

        private void tableauelevetbutton_Click(object sender, EventArgs e)
        {
            
 
            listes_passants listes_Passants = new listes_passants(examdateTimePicker.Value);
            listes_Passants.Show();
        }

        private void examen_gestionnaire_Load(object sender, EventArgs e)
        {
            /*listViewexam.Width = this.Width;
            listViewexam.Height = this.Height;*/
            panel1.Width = this.Width;
            panel1.Height = (this.Height - panel2.Height);
            Actualiser();
        }
        public void Actualiser()
        {
            listViewexam.Items.Clear();
            List<Examen> list = new List<Examen>();
            list = m.GetExamens();
            foreach (Examen examen in list)
            {
                ListViewItem lvi = new ListViewItem(" " );
                lvi.SubItems.Add(examen.getExaminateur());
                lvi.SubItems.Add(examen.getDateExamen().Date.ToString("dd/MM/yyyy"));
                listViewexam.Items.Add(lvi);
            }

        }
        private void ajoutbutton_Click(object sender, EventArgs e)
        {
            Ajouter_examen ajouter_Examen = new Ajouter_examen(this);
            ajouter_Examen.Show();
        }

        private void listViewexam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listViewexam.SelectedItems.Count == 0)
                return;
            listes_passants listes_Passants = new listes_passants(Convert.ToDateTime(this.listViewexam.SelectedItems[0].SubItems[2].Text));
            this.Hide();
            listes_Passants.Show();

        }
        private List<Examen> Listeviewtolist()
        {
            var list = new List<Examen>();
            ListView.CheckedListViewItemCollection selected = listViewexam.CheckedItems;
            foreach (ListViewItem it in selected)
            {
                int id = m.recuperer_examen(Convert.ToDateTime(it.SubItems[2].Text),it.SubItems[1].Text);
                Examen examen = new Examen(id, it.SubItems[1].Text, Convert.ToDateTime(it.SubItems[2].Text));
                list.Add(examen);
            }
            return list;
        }
        private void suppbutton_Click(object sender, EventArgs e)
        {
            DialogResult reslt = MessageBox.Show("Voullez-vous vraiment supprimer?  ", "Confirmation", MessageBoxButtons.YesNo);
            if (reslt == DialogResult.Yes)
            {
                List<Examen> list = new List<Examen>();
                list = Listeviewtolist();
                m.deleteListeExamen(list);
                Actualiser();
            }
        }

        private void modifierbutton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = m.recuperer_examen(Convert.ToDateTime(listViewexam.CheckedItems[0].SubItems[2].Text),
                listViewexam.CheckedItems[0].SubItems[1].Text);
                Examen examen = new Examen(id, listViewexam.CheckedItems[0].SubItems[1].Text, Convert.ToDateTime(listViewexam.CheckedItems[0].SubItems[2].Text));
                modifierExamen mdf = new modifierExamen(this,examen);
                mdf.Show();
            }
            catch
            {
                MessageBox.Show("Veuillez sélectionner un et un seul examen");
            }
         //   this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
