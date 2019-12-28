using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAcceuil : Form
    {
        public FormAcceuil()
        {
            InitializeComponent();
        }
        private void FormAcceuil_Load(object sender, EventArgs e)
        {
            Menupanel.Height = this.Height;

        }

        private void comptabilitbutton_Click(object sender, EventArgs e)
        {
            comptability_gestionnaire cmpg = new comptability_gestionnaire();
            cmpg.Show();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {

        }

        private void dossiersannulesbutton_Click(object sender, EventArgs e)
        {

        }

        private void papierbutton_Click(object sender, EventArgs e)
        {

        }

        private void examenbutton_Click(object sender, EventArgs e)
        {
            /*  Ajouter_examen ajouter_Examen = new Ajouter_examen();
              ajouter_Examen.Show();*/
            examen_gestionnaire examen_Gestionnaire = new examen_gestionnaire();
            examen_Gestionnaire.Show();
        }

        private void elevebutton_Click(object sender, EventArgs e)
        {
            les_eleves listeleve = new les_eleves();
            listeleve.Show();
            // ajoutereleveform ajoutereleveform = new ajoutereleveform();
            
            //ajoutereleveform.Show();
        }

        private void Menupanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
