namespace WindowsFormsApp1
{
    partial class comptability_gestionnaire
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
            this.listViewcompta = new System.Windows.Forms.ListView();
            this.selectitem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reste = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transit3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transit2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transit1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numerodossier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomparent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numeroseq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sortirbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewcompta
            // 
            this.listViewcompta.CheckBoxes = true;
            this.listViewcompta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.selectitem,
            this.reste,
            this.total,
            this.transit3,
            this.transit2,
            this.transit1,
            this.numerodossier,
            this.nomparent,
            this.nom,
            this.prenom,
            this.numeroseq});
            this.listViewcompta.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewcompta.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewcompta.FullRowSelect = true;
            this.listViewcompta.GridLines = true;
            this.listViewcompta.Location = new System.Drawing.Point(1, 0);
            this.listViewcompta.Margin = new System.Windows.Forms.Padding(4);
            this.listViewcompta.Name = "listViewcompta";
            this.listViewcompta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listViewcompta.Size = new System.Drawing.Size(1692, 667);
            this.listViewcompta.TabIndex = 1;
            this.listViewcompta.UseCompatibleStateImageBehavior = false;
            this.listViewcompta.View = System.Windows.Forms.View.Details;
            this.listViewcompta.SelectedIndexChanged += new System.EventHandler(this.listViewcompta_SelectedIndexChanged);
            // 
            // selectitem
            // 
            this.selectitem.Text = "Sélection";
            this.selectitem.Width = 180;
            // 
            // reste
            // 
            this.reste.DisplayIndex = 10;
            this.reste.Text = "Reste";
            this.reste.Width = 100;
            // 
            // total
            // 
            this.total.DisplayIndex = 9;
            this.total.Text = "Total";
            this.total.Width = 100;
            // 
            // transit3
            // 
            this.transit3.DisplayIndex = 8;
            this.transit3.Text = "Paiement3";
            this.transit3.Width = 199;
            // 
            // transit2
            // 
            this.transit2.DisplayIndex = 7;
            this.transit2.Text = "Paiement2";
            this.transit2.Width = 175;
            // 
            // transit1
            // 
            this.transit1.DisplayIndex = 6;
            this.transit1.Text = "Paiement1";
            this.transit1.Width = 179;
            // 
            // numerodossier
            // 
            this.numerodossier.DisplayIndex = 5;
            this.numerodossier.Text = "N°dossier";
            this.numerodossier.Width = 159;
            // 
            // nomparent
            // 
            this.nomparent.DisplayIndex = 4;
            this.nomparent.Text = "père";
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
            this.prenom.Width = 136;
            // 
            // numeroseq
            // 
            this.numeroseq.DisplayIndex = 1;
            this.numeroseq.Text = "N°Séquentiel";
            this.numeroseq.Width = 208;
            // 
            // sortirbutton
            // 
            this.sortirbutton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortirbutton.Location = new System.Drawing.Point(-1, -2);
            this.sortirbutton.Margin = new System.Windows.Forms.Padding(4);
            this.sortirbutton.Name = "sortirbutton";
            this.sortirbutton.Size = new System.Drawing.Size(127, 60);
            this.sortirbutton.TabIndex = 3;
            this.sortirbutton.Text = "Exit";
            this.sortirbutton.UseVisualStyleBackColor = true;
            this.sortirbutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViewcompta);
            this.panel1.Location = new System.Drawing.Point(-2, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1693, 667);
            this.panel1.TabIndex = 4;
            // 
            // comptability_gestionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1693, 826);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sortirbutton);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "comptability_gestionnaire";
            this.Text = "comptability_gestionnaire";
            this.Load += new System.EventHandler(this.comptability_gestionnaire_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewcompta;
        private System.Windows.Forms.ColumnHeader selectitem;
        private System.Windows.Forms.ColumnHeader reste;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ColumnHeader transit3;
        private System.Windows.Forms.ColumnHeader transit2;
        private System.Windows.Forms.ColumnHeader transit1;
        private System.Windows.Forms.ColumnHeader numerodossier;
        private System.Windows.Forms.ColumnHeader nomparent;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.ColumnHeader prenom;
        private System.Windows.Forms.ColumnHeader numeroseq;
        private System.Windows.Forms.Button sortirbutton;
        private System.Windows.Forms.Panel panel1;
    }
}