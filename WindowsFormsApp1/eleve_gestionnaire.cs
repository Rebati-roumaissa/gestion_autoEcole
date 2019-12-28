using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Windows.Input;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class eleve_gestionnaire : Form
    {
        methodes m = new methodes();
        int id_eleve;
        Eleve eleve;
        Paiement paiement;
        bool ds;
        bool nds;
        bool t1;bool t2; bool t3;
        public eleve_gestionnaire(int id)
        {
            t1 = false;
            t2 = false;
            t3 = false;
            eleve = new Eleve();
            paiement = new Paiement();
            id_eleve = id;
            ds = false;
            nds = false;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ajouterpaiementbutton_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Listeexamensbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + id_eleve);
            liste_exam_eleve liste_Exam_Eleve = new liste_exam_eleve(id_eleve);
            liste_Exam_Eleve.Show();
        }

        private void eleve_gestionnaire_Load(object sender, EventArgs e)
        {
            getinfo(id_eleve);
        }
        private void getinfo(int id_eleve)
        {
            Eleve eleve = m.recuperer_eleve(id_eleve);
            this.eleve = eleve;
            prentextBox.Text = eleve.getprenom();
            namtextBox.Text = eleve.getnom();
            preperetextBox.Text = eleve.getnomparent();
            datenaissanceTimePicker.Value = eleve.getdns();
            lieutextBox.Text = eleve.getlns();
            adrtextBox.Text = eleve.getadresse();
            dosstextBox.Text = eleve.getnumerodossier().ToString();
            dateentreeTimePicker.Value = eleve.getdent();
            if (eleve.getds() != DateTime.MinValue)
            { datesortieTimePicker.Value = eleve.getds(); }
            examtextBox.Text = eleve.getexamin();
            obscomboBox.Text = eleve.getrmrq();
            paiement = m.recupererPaiement(id_eleve);
            if (paiement.getTransit1() != 0) { transit1.Text = paiement.getTransit1().ToString(); t1 = true; }
            if (paiement.getTransit2() != 0) { transit2.Text = paiement.getTransit2().ToString(); t2 = true; }
            if (paiement.getTransit3() != 0) { transit3.Text = paiement.getTransit3().ToString(); t3 = true; }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
          DialogResult reslt = MessageBox.Show("Voullez vous vraiment confirmer ? ", "Confirmation", MessageBoxButtons.YesNo);
            if (reslt == DialogResult.Yes)
            {
                eleve.setInformation(namtextBox.Text, prentextBox.Text, preperetextBox.Text, datenaissanceTimePicker.Value,

                lieutextBox.Text, adrtextBox.Text, dateentreeTimePicker.Value, obscomboBox.Text, examtextBox.Text);
                if (nds && ds)
                { m.modifier_eleve_numerodossier(this.eleve);
                    m.modifier_eleve_datesortie(this.eleve);
                }
                else
                {
                    if (ds)
                    { m.modifier_eleve_datesortie(this.eleve); }
                    else
                    {
                        if (nds) { m.modifier_eleve_numerodossier(this.eleve); }
                        else
                        { m.modifier_eleve(this.eleve); }
                    }
                }
                this.Close();
            }
        }

        private void prentextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            eleve.setnumerodossier(Convert.ToInt64(dosstextBox.Text));
            nds = true;
            MessageBox.Show("Ajout de numéro effectué, veuillez cliquer sur le boutton confirmer avant de quitter la fenêtre ");
        }

        private void confirmerdatesortiebutton_Click(object sender, EventArgs e)
        {
            eleve.setds(datesortieTimePicker.Value);
            ds = true;
            MessageBox.Show("Ajout de date effectué, veuillez ajouter les remarques de sortie ou le nom d'examinateur et cliquer sur le boutton confirmer avant de quitter la fenêtre ");
        }

        private void annulerbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(transit3.Text, "[^0-9].").Success)
            {
                MessageBox.Show("Seuls les chiffres sont accptés");

            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(transit1.Text, "[^0-9].").Success)
            {
                MessageBox.Show("Seuls les chiffres sont accptés");

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            if (Regex.Match(transit2.Text, "[^0-9].").Success)
            {
                MessageBox.Show("Seuls les chiffres sont accptés");

            }
        }

        private void confirmert1button_Click(object sender, EventArgs e)
        {
            if (transit1.Text != null)
            {
                if (paiement.getTransit1() != 0) MessageBox.Show("Impossible d'effectuer l'opération, la tranche est déjà ajoutée ");
                else
                {
                    if (paiement.getMontant() >= Convert.ToInt32(transit1.Text))
                    {
                        paiement.setTransit1(Convert.ToInt32(transit1.Text));
                        m.addtransit1(id_eleve, Convert.ToInt32(transit1.Text));
                        t1 = true;
                        MessageBox.Show(" Paiement ajouté, il reste à payer  " + paiement.getReste());
                    }
                    else MessageBox.Show("Il est impossible que la tranche dépasse le montant à payer");
                }
            }
          }

        private void confirmert2button_Click(object sender, EventArgs e)
        {
            if (paiement.getTransit2() != 0) MessageBox.Show("Impossible d'effectuer l'opération, la tranche est déjà ajoutée ");
            else
            {
                if (paiement.getReste() > 0)
                {
                    if (!t1) MessageBox.Show(" Impossible d'ajouter cette tranche, il faut commencer par la première"); 
                    else
                    {
                        if (paiement.getReste() >= Convert.ToInt32(transit2.Text))
                        {
                            paiement.setTransit2(Convert.ToInt32(transit2.Text));
                            m.addtransit2(id_eleve, Convert.ToInt32(transit2.Text));
                            t2 = true;
                            MessageBox.Show("  Paiement ajouté, il reste à payer " + paiement.getReste());
                        }
                        else MessageBox.Show("Il est impossible que la tranche dépasse le reste à payer");
                    }
                }
                else
                {
                    MessageBox.Show("Tout le montant a été payé, impossible d'effectuer un nouveau paiement");
                }
            }
        }

        private void confirmert3button_Click(object sender, EventArgs e)
        {
            if (paiement.getTransit3() != 0) MessageBox.Show("Impossible d'effectuer l'opération, la tranche est déjà ajoutée ");
            else
            {
                if (paiement.getReste() > 0)
                {
                    if (!t1 || !t2 ) MessageBox.Show(" Impossible d'ajouter cette tranche, il faut commencer par la première et la deuxième tranche   ");
                    else
                    {
                        if (paiement.getReste() == Convert.ToInt32(transit3.Text))
                        {
                            paiement.setTransit3(Convert.ToInt32(transit3.Text));
                            m.addtransit3(id_eleve, Convert.ToInt32(transit3.Text));
                            t3 = true;
                            MessageBox.Show("Dernier paiement effectué " );
                        }
                        else
                        {
                            MessageBox.Show("Impossible, il faut payer " + paiement.getReste());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("");
                }
            }
        }

        private void dosstextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(dosstextBox.Text, "[^0-9].").Success)
            {
                MessageBox.Show("Tout le montant a été payé, impossible d'effectuer ");

            }
        }

        private void remarquetextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
