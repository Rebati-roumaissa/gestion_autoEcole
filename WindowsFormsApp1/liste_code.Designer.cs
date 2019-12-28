namespace WindowsFormsApp1
{
    partial class liste_code
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
            this.Annulerbutton = new System.Windows.Forms.Button();
            this.confirmerbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listVieweleves
            // 
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
            this.listVieweleves.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVieweleves.FullRowSelect = true;
            this.listVieweleves.GridLines = true;
            this.listVieweleves.Location = new System.Drawing.Point(0, 0);
            this.listVieweleves.Name = "listVieweleves";
            this.listVieweleves.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listVieweleves.Size = new System.Drawing.Size(1379, 451);
            this.listVieweleves.TabIndex = 1;
            this.listVieweleves.UseCompatibleStateImageBehavior = false;
            this.listVieweleves.View = System.Windows.Forms.View.Details;
            this.listVieweleves.SelectedIndexChanged += new System.EventHandler(this.listVieweleves_SelectedIndexChanged);
            // 
            // selectitem
            // 
            this.selectitem.Text = "Sélection";
            this.selectitem.Width = 120;
            // 
            // remarques
            // 
            this.remarques.DisplayIndex = 12;
            this.remarques.Text = "Remarques";
            this.remarques.Width = 150;
            // 
            // examinateur
            // 
            this.examinateur.DisplayIndex = 11;
            this.examinateur.Text = "Examinateur";
            this.examinateur.Width = 150;
            // 
            // datesortie
            // 
            this.datesortie.DisplayIndex = 10;
            this.datesortie.Text = "Date de sortie";
            this.datesortie.Width = 150;
            // 
            // dateentree
            // 
            this.dateentree.DisplayIndex = 9;
            this.dateentree.Text = "Date d\'entrée";
            this.dateentree.Width = 150;
            // 
            // numerodossier
            // 
            this.numerodossier.DisplayIndex = 8;
            this.numerodossier.Text = "N°dossier";
            this.numerodossier.Width = 120;
            // 
            // lieunaissance
            // 
            this.lieunaissance.DisplayIndex = 7;
            this.lieunaissance.Text = "Lieu de naissance";
            this.lieunaissance.Width = 150;
            // 
            // datenaissance
            // 
            this.datenaissance.DisplayIndex = 6;
            this.datenaissance.Text = "Date de naissance";
            this.datenaissance.Width = 150;
            // 
            // adresse
            // 
            this.adresse.DisplayIndex = 5;
            this.adresse.Text = "Adresse";
            this.adresse.Width = 150;
            // 
            // nomparent
            // 
            this.nomparent.DisplayIndex = 4;
            this.nomparent.Text = "Père";
            this.nomparent.Width = 100;
            // 
            // nom
            // 
            this.nom.DisplayIndex = 3;
            this.nom.Text = "Nom";
            this.nom.Width = 100;
            // 
            // prenom
            // 
            this.prenom.DisplayIndex = 2;
            this.prenom.Text = "Prénom";
            this.prenom.Width = 150;
            // 
            // numeroseq
            // 
            this.numeroseq.DisplayIndex = 1;
            this.numeroseq.Text = "N°séquentiel";
            this.numeroseq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numeroseq.Width = 200;
            // 
            // Annulerbutton
            // 
            this.Annulerbutton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annulerbutton.Location = new System.Drawing.Point(756, 0);
            this.Annulerbutton.Name = "Annulerbutton";
            this.Annulerbutton.Size = new System.Drawing.Size(219, 75);
            this.Annulerbutton.TabIndex = 12;
            this.Annulerbutton.Text = "Annuler";
            this.Annulerbutton.UseVisualStyleBackColor = true;
            this.Annulerbutton.Click += new System.EventHandler(this.Annulerbutton_Click);
            // 
            // confirmerbutton
            // 
            this.confirmerbutton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmerbutton.Location = new System.Drawing.Point(540, 0);
            this.confirmerbutton.Name = "confirmerbutton";
            this.confirmerbutton.Size = new System.Drawing.Size(210, 75);
            this.confirmerbutton.TabIndex = 11;
            this.confirmerbutton.Text = "Confirmer";
            this.confirmerbutton.UseVisualStyleBackColor = true;
            this.confirmerbutton.Click += new System.EventHandler(this.confirmerbutton_Click_1);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.listVieweleves);
            this.panel1.Location = new System.Drawing.Point(2, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1379, 451);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.confirmerbutton);
            this.panel2.Controls.Add(this.Annulerbutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1417, 78);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // liste_code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1417, 560);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.Name = "liste_code";
            this.Text = "liste_examen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.liste_code_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listVieweleves;
        private System.Windows.Forms.ColumnHeader selectitem;
        private System.Windows.Forms.ColumnHeader remarques;
        private System.Windows.Forms.ColumnHeader examinateur;
        private System.Windows.Forms.ColumnHeader datesortie;
        private System.Windows.Forms.ColumnHeader dateentree;
        private System.Windows.Forms.ColumnHeader numerodossier;
        private System.Windows.Forms.ColumnHeader lieunaissance;
        private System.Windows.Forms.ColumnHeader datenaissance;
        private System.Windows.Forms.ColumnHeader adresse;
        private System.Windows.Forms.ColumnHeader nomparent;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.ColumnHeader prenom;
        private System.Windows.Forms.ColumnHeader numeroseq;
        private System.Windows.Forms.Button Annulerbutton;
        private System.Windows.Forms.Button confirmerbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}