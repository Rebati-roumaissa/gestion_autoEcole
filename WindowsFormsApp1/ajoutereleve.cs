using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace WindowsFormsApp1
{
    public partial class ajoutereleveform : Form
    {
        les_eleves _Eleves;
        public ajoutereleveform()
        {
            InitializeComponent();
        }
        public ajoutereleveform(les_eleves _Eleves)
        {
            this._Eleves = new les_eleves();
            this._Eleves = _Eleves;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ajoutereleveform_Load(object sender, EventArgs e)
        {

        }

        private void nomtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void prenomtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomparenttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void datenaissancetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lieunaissancetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adressetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numerodossiertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
           
            if(!string.IsNullOrEmpty(prentextBox.Text)&& !string.IsNullOrEmpty(namtextBox.Text)&& !string.IsNullOrEmpty(preperetextBox.Text)&& !string.IsNullOrEmpty(datenaissanceTimePicker.Text))
            {
               
                methodes m = new methodes();
                int Nseq = m.save_student(namtextBox.Text, prentextBox.Text, preperetextBox.Text, datenaissanceTimePicker.Value, lieutextBox.Text, adrtextBox.Text, dateentreeTimePicker.Value);
               
            }

        }

        private void savebutton_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(prentextBox.Text) && !string.IsNullOrEmpty(namtextBox.Text) && !string.IsNullOrEmpty(preperetextBox.Text) && !string.IsNullOrEmpty(datenaissanceTimePicker.Text) && !string.IsNullOrEmpty(montantvaluetextBox.Text) )
            {    methodes m = new methodes();
                int Nseq = m.save_student(namtextBox.Text, prentextBox.Text, preperetextBox.Text, datenaissanceTimePicker.Value, lieutextBox.Text, adrtextBox.Text, dateentreeTimePicker.Value);
                Paiement p = new Paiement(Nseq, Convert.ToInt32(montantvaluetextBox.Text));
                m.savePaiement(p);
                if (!string.IsNullOrEmpty(dosstextBox.Text))
                {
                    Eleve eleve = m.recuperer_eleve(Nseq);
                    eleve.setnumerodossier(Convert.ToInt64(dosstextBox.Text));
                    m.modifier_eleve_numerodossier(eleve);
                }
                _Eleves.actualiser();
                _Eleves.Show();
                this.Close();
            }
            else
                MessageBox.Show("Il faut remplir tous les champs obligatoires");
        }

        private void annulerbutton_Click(object sender, EventArgs e)
        {
            _Eleves.Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {           
            if (Regex.Match(montantvaluetextBox.Text, "[^0-9].").Success)
            {
                MessageBox.Show("Seuls les nombres sont acceptés");
             
            }
        }

        private void dosstextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(dosstextBox.Text, "[^0-9].").Success)
            {
                MessageBox.Show("Seuls les nombres sont acceptés");

            }
        }
    }
}
