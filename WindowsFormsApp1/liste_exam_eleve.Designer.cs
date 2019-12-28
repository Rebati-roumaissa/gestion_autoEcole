namespace WindowsFormsApp1
{
    partial class liste_exam_eleve
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
            this.listViewexam_eleve = new System.Windows.Forms.ListView();
            this.remarqueitem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.examinateuritem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultatitem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeitem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateitem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomtextBox = new System.Windows.Forms.TextBox();
            this.prenomtextBox = new System.Windows.Forms.TextBox();
            this.numdossiertextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewexam_eleve
            // 
            this.listViewexam_eleve.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.remarqueitem,
            this.examinateuritem,
            this.resultatitem,
            this.typeitem,
            this.dateitem});
            this.listViewexam_eleve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewexam_eleve.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewexam_eleve.GridLines = true;
            this.listViewexam_eleve.Location = new System.Drawing.Point(0, 0);
            this.listViewexam_eleve.Name = "listViewexam_eleve";
            this.listViewexam_eleve.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listViewexam_eleve.Size = new System.Drawing.Size(1394, 564);
            this.listViewexam_eleve.TabIndex = 0;
            this.listViewexam_eleve.UseCompatibleStateImageBehavior = false;
            this.listViewexam_eleve.View = System.Windows.Forms.View.Details;
            this.listViewexam_eleve.SelectedIndexChanged += new System.EventHandler(this.listViewexam_eleve_SelectedIndexChanged);
            // 
            // remarqueitem
            // 
            this.remarqueitem.DisplayIndex = 4;
            this.remarqueitem.Text = "Remarques";
            this.remarqueitem.Width = 200;
            // 
            // examinateuritem
            // 
            this.examinateuritem.DisplayIndex = 3;
            this.examinateuritem.Text = "Examinateur";
            this.examinateuritem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.examinateuritem.Width = 220;
            // 
            // resultatitem
            // 
            this.resultatitem.Text = "Résultat";
            this.resultatitem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resultatitem.Width = 260;
            // 
            // typeitem
            // 
            this.typeitem.DisplayIndex = 1;
            this.typeitem.Text = "Type";
            this.typeitem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.typeitem.Width = 150;
            // 
            // dateitem
            // 
            this.dateitem.DisplayIndex = 0;
            this.dateitem.Text = "Date";
            this.dateitem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dateitem.Width = 300;
            // 
            // nomtextBox
            // 
            this.nomtextBox.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomtextBox.Location = new System.Drawing.Point(743, 3);
            this.nomtextBox.Name = "nomtextBox";
            this.nomtextBox.ReadOnly = true;
            this.nomtextBox.Size = new System.Drawing.Size(211, 47);
            this.nomtextBox.TabIndex = 1;
            this.nomtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // prenomtextBox
            // 
            this.prenomtextBox.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomtextBox.Location = new System.Drawing.Point(530, 3);
            this.prenomtextBox.Name = "prenomtextBox";
            this.prenomtextBox.ReadOnly = true;
            this.prenomtextBox.Size = new System.Drawing.Size(207, 47);
            this.prenomtextBox.TabIndex = 2;
            this.prenomtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numdossiertextBox
            // 
            this.numdossiertextBox.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numdossiertextBox.Location = new System.Drawing.Point(307, 3);
            this.numdossiertextBox.Name = "numdossiertextBox";
            this.numdossiertextBox.ReadOnly = true;
            this.numdossiertextBox.Size = new System.Drawing.Size(217, 47);
            this.numdossiertextBox.TabIndex = 3;
            this.numdossiertextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numdossiertextBox.TextChanged += new System.EventHandler(this.numdossiertextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.listViewexam_eleve);
            this.panel1.Location = new System.Drawing.Point(1, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1394, 564);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numdossiertextBox);
            this.panel2.Controls.Add(this.prenomtextBox);
            this.panel2.Controls.Add(this.nomtextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1395, 53);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // liste_exam_eleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1395, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "liste_exam_eleve";
            this.Text = "liste_exam_eleve";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.liste_exam_eleve_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewexam_eleve;
        private System.Windows.Forms.ColumnHeader examinateuritem;
        private System.Windows.Forms.ColumnHeader dateitem;
        private System.Windows.Forms.ColumnHeader resultatitem;
        private System.Windows.Forms.ColumnHeader remarqueitem;
        private System.Windows.Forms.TextBox nomtextBox;
        private System.Windows.Forms.TextBox prenomtextBox;
        private System.Windows.Forms.TextBox numdossiertextBox;
        private System.Windows.Forms.ColumnHeader typeitem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}