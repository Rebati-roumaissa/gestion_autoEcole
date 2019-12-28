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
    public partial class liste_exam_eleve : Form
    {
        int id_eleve;
        Eleve eleve = new Eleve();
        public liste_exam_eleve(int id)
        {
            
            id_eleve = id;
            methodes m = new methodes();
            this.eleve = m.recuperer_eleve(id_eleve);
            InitializeComponent();
        }

        private void liste_exam_eleve_Load(object sender, EventArgs e)
        {
            panel1.Width = this.Width;
            actualiser();
        }
        private void actualiser()
        {
            numdossiertextBox.Text=eleve.getnumerodossier().ToString();
            prenomtextBox.Text = eleve.getprenom().ToString();
            nomtextBox.Text = eleve.getnom().ToString();
               methodes m = new methodes();
            var list = new List<Examen>();
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-En");
            list = m.GetExamens_eleve(id_eleve);
            foreach (Examen examen in list)
            {

                ListViewItem lvi = new ListViewItem(examen.getObservation());
                lvi.SubItems.Add(examen.getExaminateur());
                lvi.SubItems.Add(examen.getResultat());
                lvi.SubItems.Add(examen.gettypeExamen());
                if (examen.getDateExamen() != DateTime.MinValue)
                { lvi.SubItems.Add(examen.getDateExamen().Date.ToString("dd/MM/yyyy")); }
                else lvi.SubItems.Add("");
                listViewexam_eleve.Items.Add(lvi);
            }
        }

        private void numdossiertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewexam_eleve_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
