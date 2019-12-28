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
    public partial class comptability_gestionnaire : Form
    {
        public comptability_gestionnaire()
        {
            InitializeComponent();
        }

        private void comptability_gestionnaire_Load(object sender, EventArgs e)
        {
            /*listViewcompta.Width = this.Width;
            listViewcompta.Height = this.Height;*/
            actualiser();
        }
        private void actualiser()
        {
            methodes m = new methodes();
            var list = new List<Paiement>();
            list = m.GetPaiements();
            foreach (Paiement p in list)
            {
                ListViewItem lvi = new ListViewItem(" ");
                lvi.SubItems.Add(p.getReste().ToString());
                lvi.SubItems.Add((p.getTransit1()+p.getTransit2()+p.getTransit3()).ToString());
                lvi.SubItems.Add(p.getTransit3().ToString());
                lvi.SubItems.Add(p.getTransit2().ToString());
                lvi.SubItems.Add(p.getTransit1().ToString());
                lvi.SubItems.Add(p.getnumdossier().ToString());
                lvi.SubItems.Add(p.getpere());
                lvi.SubItems.Add(p.getnom());
                lvi.SubItems.Add(p.getprenom());
                lvi.SubItems.Add(p.getnsq().ToString());
                listViewcompta.Items.Add(lvi);
            }
        }

        private void listViewcompta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void confirmerbutton_Click(object sender, EventArgs e)
        {

        }

        private void Annulerbutton_Click(object sender, EventArgs e)
        {

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
