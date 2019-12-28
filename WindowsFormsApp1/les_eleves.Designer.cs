namespace WindowsFormsApp1
{
    partial class les_eleves
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listVieweleves = new System.Windows.Forms.ListView();
            this.selectitem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.remarques = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.examinateur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datesortie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateentree = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numerodossier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lieunaissance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datenaissance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomparent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numeroseq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listVieweleves
            // 
            this.listVieweleves.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.listVieweleves.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listVieweleves.CheckBoxes = true;
            this.listVieweleves.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.selectitem,
            this.remarques,
            this.examinateur,
            this.datesortie,
            this.dateentree,
            this.numerodossier,
            this.lieunaissance,
            this.datenaissance,
            this.adresse,
            this.nomparent,
            this.nom,
            this.prenom,
            this.numeroseq});
            this.listVieweleves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listVieweleves.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVieweleves.FullRowSelect = true;
            this.listVieweleves.GridLines = true;
            this.listVieweleves.Location = new System.Drawing.Point(0, 0);
            this.listVieweleves.Margin = new System.Windows.Forms.Padding(4);
            this.listVieweleves.Name = "listVieweleves";
            this.listVieweleves.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listVieweleves.Size = new System.Drawing.Size(1872, 464);
            this.listVieweleves.TabIndex = 0;
            this.listVieweleves.UseCompatibleStateImageBehavior = false;
            this.listVieweleves.View = System.Windows.Forms.View.Details;
            this.listVieweleves.SelectedIndexChanged += new System.EventHandler(this.listVieweleves_SelectedIndexChanged);
            // 
            // selectitem
            // 
            this.selectitem.Text = "Sélection";
            this.selectitem.Width = 136;
            // 
            // remarques
            // 
            this.remarques.DisplayIndex = 12;
            this.remarques.Text = "Remarques";
            this.remarques.Width = 80;
            // 
            // examinateur
            // 
            this.examinateur.DisplayIndex = 11;
            this.examinateur.Text = "Examinateur";
            this.examinateur.Width = 80;
            // 
            // datesortie
            // 
            this.datesortie.DisplayIndex = 10;
            this.datesortie.Text = "Date de sortie";
            this.datesortie.Width = 160;
            // 
            // dateentree
            // 
            this.dateentree.DisplayIndex = 9;
            this.dateentree.Text = "Date d\'entrée";
            this.dateentree.Width = 206;
            // 
            // numerodossier
            // 
            this.numerodossier.DisplayIndex = 8;
            this.numerodossier.Text = "N°dossier";
            this.numerodossier.Width = 159;
            // 
            // lieunaissance
            // 
            this.lieunaissance.DisplayIndex = 7;
            this.lieunaissance.Text = "Lieu de naissance";
            this.lieunaissance.Width = 248;
            // 
            // datenaissance
            // 
            this.datenaissance.DisplayIndex = 6;
            this.datenaissance.Text = "Date de naissance";
            this.datenaissance.Width = 258;
            // 
            // adresse
            // 
            this.adresse.DisplayIndex = 5;
            this.adresse.Text = "Adresse";
            this.adresse.Width = 160;
            // 
            // nomparent
            // 
            this.nomparent.DisplayIndex = 4;
            this.nomparent.Text = "Père";
            this.nomparent.Width = 157;
            // 
            // nom
            // 
            this.nom.DisplayIndex = 3;
            this.nom.Text = "Nom";
            this.nom.Width = 159;
            // 
            // prenom
            // 
            this.prenom.DisplayIndex = 2;
            this.prenom.Text = "Prénom";
            this.prenom.Width = 130;
            // 
            // numeroseq
            // 
            this.numeroseq.DisplayIndex = 1;
            this.numeroseq.Text = "N°séquentiel";
            this.numeroseq.Width = 192;
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.Location = new System.Drawing.Point(121, 9);
            this.addbutton.Margin = new System.Windows.Forms.Padding(4);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(200, 74);
            this.addbutton.TabIndex = 1;
            this.addbutton.Text = "Ajouter";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.Location = new System.Drawing.Point(329, 9);
            this.deletebutton.Margin = new System.Windows.Forms.Padding(4);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(241, 74);
            this.deletebutton.TabIndex = 2;
            this.deletebutton.Text = "Supprimer";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listVieweleves);
            this.panel1.Location = new System.Drawing.Point(12, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1872, 464);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.deletebutton);
            this.panel2.Controls.Add(this.addbutton);
            this.panel2.Location = new System.Drawing.Point(457, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 108);
            this.panel2.TabIndex = 4;
            // 
            // les_eleves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1912, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "les_eleves";
            this.Text = "Les_eleves";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.les_eleves_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listVieweleves;
        private System.Windows.Forms.ColumnHeader remarques;
        private System.Windows.Forms.ColumnHeader examinateur;
        private System.Windows.Forms.ColumnHeader datesortie;
        private System.Windows.Forms.ColumnHeader dateentree;
        private System.Windows.Forms.ColumnHeader lieunaissance;
        private System.Windows.Forms.ColumnHeader datenaissance;
        private System.Windows.Forms.ColumnHeader adresse;
        private System.Windows.Forms.ColumnHeader nomparent;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.ColumnHeader prenom;
        private System.Windows.Forms.ColumnHeader numerodossier;
        private System.Windows.Forms.ColumnHeader numeroseq;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.ColumnHeader selectitem;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}