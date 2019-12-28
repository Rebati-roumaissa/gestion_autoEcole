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
    public partial class modifierExamen : Form
    {
        examen_gestionnaire _Gestionnaire;
        private Examen examen;
        public modifierExamen()
        {
            InitializeComponent();
        }
        public modifierExamen(examen_gestionnaire _Gestionnaire, Examen examen)
        {
            this._Gestionnaire = _Gestionnaire;
            this.examen = new Examen(examen.getId(),examen.getExaminateur(),examen.getDateExamen());
            InitializeComponent();
        }
        public Examen getExamen()
        {
            return this.examen;
        }
        private void modifierExamen_Load(object sender, EventArgs e)
        {
            examendateTimePicker.Value = examen.getDateExamen();
            examinateurnomtextbox.Text = examen.getExaminateur();
        }

        private void codebutton_Click(object sender, EventArgs e)
        {
            examen.settypeExamen("code");
            liste_code liste_Code = new liste_code(this,examen,true);
            this.Hide();
            liste_Code.Show();
        }

        private void crenobutton_Click(object sender, EventArgs e)
        {
            examen.settypeExamen("creno");
            liste_code liste_Code = new liste_code(this,examen,true);
            this.Hide();
            liste_Code.Show();
        }

        private void conduitebutton_Click(object sender, EventArgs e)
        {
            examen.settypeExamen("conduite");
            liste_code liste_Code = new liste_code(this,examen,true);
            this.Hide();
            liste_Code.Show();
        }

        private void confirmerbutton_Click(object sender, EventArgs e)
        {
            methodes m = new methodes();
            examen.setDateExamen(examendateTimePicker.Value);
            examen.setExaminateur(examinateurnomtextbox.Text);
            m.modifier_examen(examen);
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
