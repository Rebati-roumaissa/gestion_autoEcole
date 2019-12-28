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
    public partial class Ajouter_examen : Form
    {
        examen_gestionnaire _Gestionnaire;
        private Examen examen;
        public Ajouter_examen()
        {
            InitializeComponent();
        }
        public Ajouter_examen(examen_gestionnaire _Gestionnaire)
        {
            this._Gestionnaire = _Gestionnaire;
            InitializeComponent();
        }
        
        public Examen getExamen()
        {
            return this.examen;
        }
        private void codebutton_Click(object sender, EventArgs e)
        {
            examen = new Examen(examinateurnomtextbox.Text,examendateTimePicker.Value, "code");
            methodes m = new methodes();int id;
            if (!m.exist_examen(examendateTimePicker.Value, examinateurnomtextbox.Text))
            { id = m.save_examen(examen.getExaminateur(), examen.getDateExamen()); }
            else
            {
                id = m.recuperer_examen(examendateTimePicker.Value, examinateurnomtextbox.Text);
            } 
            examen.setId(id);
            liste_code liste_Code = new liste_code(this,examen);
            liste_Code.Show();
        }

        private void Ajouter_examen_Load(object sender, EventArgs e)
        {

        }

        private void crenobutton_Click(object sender, EventArgs e)
        {
            examen = new Examen(examinateurnomtextbox.Text, examendateTimePicker.Value, "creno");
            methodes m = new methodes();int id;
            if (!m.exist_examen(examendateTimePicker.Value, examinateurnomtextbox.Text))
            { id = m.save_examen(examen.getExaminateur(), examen.getDateExamen()); }
            else
            {
                id = m.recuperer_examen(examendateTimePicker.Value,examinateurnomtextbox.Text);
            }
            examen.setId(id);
            liste_code liste_Code = new liste_code(this,examen);
            liste_Code.Show();
        }

        private void conduitebutton_Click(object sender, EventArgs e)
        {
            examen = new Examen(examinateurnomtextbox.Text, examendateTimePicker.Value, "conduite");
            methodes m = new methodes();int id;
            if (!m.exist_examen(examendateTimePicker.Value, examinateurnomtextbox.Text))
            { id = m.save_examen(examen.getExaminateur(), examen.getDateExamen()); }
            else
            {
                id = m.recuperer_examen(examendateTimePicker.Value, examinateurnomtextbox.Text);
            }
            examen.setId(id);
            liste_code liste_Code = new liste_code(this,examen);
            liste_Code.Show();
        }

        private void confirmerbutton_Click(object sender, EventArgs e)
        {
             examen = new Examen(examinateurnomtextbox.Text, examendateTimePicker.Value);
            int id=0; methodes m = new methodes();
            if (!m.exist_examen(examendateTimePicker.Value, examinateurnomtextbox.Text))
            { id = m.save_examen(examen.getExaminateur(), examen.getDateExamen()); }
            _Gestionnaire.Actualiser();
            _Gestionnaire.Show();
            this.Close();
        }

        private void Annulerbutton_Click(object sender, EventArgs e)
        {
            _Gestionnaire.Actualiser();
            _Gestionnaire.Show();
            this.Close();
        }
    }
}
