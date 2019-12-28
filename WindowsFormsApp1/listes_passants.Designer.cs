namespace WindowsFormsApp1
{
    partial class listes_passants
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
            this.listVieweleve_exam = new System.Windows.Forms.ListView();
            this.selectitem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.remarqueitem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultatitem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeitem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ndsitem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenomitem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomitem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nseqitem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.réussirbutton = new System.Windows.Forms.Button();
            this.perdrebutton = new System.Windows.Forms.Button();
            this.justifiantbutton = new System.Windows.Forms.Button();
            this.absentbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listVieweleve_exam
            // 
            this.listVieweleve_exam.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listVieweleve_exam.CheckBoxes = true;
            this.listVieweleve_exam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.selectitem,
            this.remarqueitem,
            this.resultatitem,
            this.typeitem,
            this.ndsitem,
            this.prenomitem,
            this.nomitem,
            this.nseqitem});
            this.listVieweleve_exam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listVieweleve_exam.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVieweleve_exam.GridLines = true;
            this.listVieweleve_exam.Location = new System.Drawing.Point(0, 0);
            this.listVieweleve_exam.Name = "listVieweleve_exam";
            this.listVieweleve_exam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listVieweleve_exam.Size = new System.Drawing.Size(1370, 695);
            this.listVieweleve_exam.TabIndex = 1;
            this.listVieweleve_exam.UseCompatibleStateImageBehavior = false;
            this.listVieweleve_exam.View = System.Windows.Forms.View.Details;
            this.listVieweleve_exam.SelectedIndexChanged += new System.EventHandler(this.listVieweleve_exam_SelectedIndexChanged);
            // 
            // selectitem
            // 
            this.selectitem.Text = "Sélection";
            this.selectitem.Width = 70;
            // 
            // remarqueitem
            // 
            this.remarqueitem.DisplayIndex = 7;
            this.remarqueitem.Text = "Remarques";
            this.remarqueitem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.remarqueitem.Width = 175;
            // 
            // resultatitem
            // 
            this.resultatitem.DisplayIndex = 6;
            this.resultatitem.Text = "Résultat";
            this.resultatitem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resultatitem.Width = 213;
            // 
            // typeitem
            // 
            this.typeitem.DisplayIndex = 5;
            this.typeitem.Text = "Type";
            this.typeitem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.typeitem.Width = 160;
            // 
            // ndsitem
            // 
            this.ndsitem.Text = "N°dossier";
            this.ndsitem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ndsitem.Width = 167;
            // 
            // prenomitem
            // 
            this.prenomitem.DisplayIndex = 3;
            this.prenomitem.Text = "Prénom";
            this.prenomitem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.prenomitem.Width = 150;
            // 
            // nomitem
            // 
            this.nomitem.DisplayIndex = 2;
            this.nomitem.Text = "Nom";
            this.nomitem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nomitem.Width = 180;
            // 
            // nseqitem
            // 
            this.nseqitem.DisplayIndex = 1;
            this.nseqitem.Text = "N°séquentiel";
            this.nseqitem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nseqitem.Width = 180;
            // 
            // réussirbutton
            // 
            this.réussirbutton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.réussirbutton.Location = new System.Drawing.Point(59, 10);
            this.réussirbutton.Name = "réussirbutton";
            this.réussirbutton.Size = new System.Drawing.Size(278, 61);
            this.réussirbutton.TabIndex = 2;
            this.réussirbutton.Text = "Ont réussi";
            this.réussirbutton.UseVisualStyleBackColor = true;
            this.réussirbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // perdrebutton
            // 
            this.perdrebutton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perdrebutton.Location = new System.Drawing.Point(343, 12);
            this.perdrebutton.Name = "perdrebutton";
            this.perdrebutton.Size = new System.Drawing.Size(282, 59);
            this.perdrebutton.TabIndex = 3;
            this.perdrebutton.Text = "Ont échoué";
            this.perdrebutton.UseVisualStyleBackColor = true;
            this.perdrebutton.Click += new System.EventHandler(this.perdrebutton_Click);
            // 
            // justifiantbutton
            // 
            this.justifiantbutton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.justifiantbutton.Location = new System.Drawing.Point(631, 12);
            this.justifiantbutton.Name = "justifiantbutton";
            this.justifiantbutton.Size = new System.Drawing.Size(301, 59);
            this.justifiantbutton.TabIndex = 4;
            this.justifiantbutton.Text = "Absence justifiée";
            this.justifiantbutton.UseVisualStyleBackColor = true;
            this.justifiantbutton.Click += new System.EventHandler(this.justifiantbutton_Click);
            // 
            // absentbutton
            // 
            this.absentbutton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absentbutton.Location = new System.Drawing.Point(938, 12);
            this.absentbutton.Name = "absentbutton";
            this.absentbutton.Size = new System.Drawing.Size(348, 59);
            this.absentbutton.TabIndex = 5;
            this.absentbutton.Text = "Absence non justifiée";
            this.absentbutton.UseVisualStyleBackColor = true;
            this.absentbutton.Click += new System.EventHandler(this.absentbutton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.listVieweleve_exam);
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 695);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.absentbutton);
            this.panel2.Controls.Add(this.justifiantbutton);
            this.panel2.Controls.Add(this.réussirbutton);
            this.panel2.Controls.Add(this.perdrebutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1382, 83);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // listes_passants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1408, 518);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.Name = "listes_passants";
            this.Text = "listes_passants";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.listes_passants_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listVieweleve_exam;
        private System.Windows.Forms.ColumnHeader remarqueitem;
        private System.Windows.Forms.ColumnHeader ndsitem;
        private System.Windows.Forms.ColumnHeader resultatitem;
        private System.Windows.Forms.ColumnHeader prenomitem;
        private System.Windows.Forms.ColumnHeader nomitem;
        private System.Windows.Forms.ColumnHeader typeitem;
        private System.Windows.Forms.ColumnHeader selectitem;
        private System.Windows.Forms.Button réussirbutton;
        private System.Windows.Forms.Button perdrebutton;
        private System.Windows.Forms.Button justifiantbutton;
        private System.Windows.Forms.Button absentbutton;
        private System.Windows.Forms.ColumnHeader nseqitem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}