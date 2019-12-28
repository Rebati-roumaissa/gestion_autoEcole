namespace WindowsFormsApp1
{
    partial class examen_gestionnaire
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewexam = new System.Windows.Forms.ListView();
            this.select = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.examinteuritem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateitem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.examdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ajoutbutton = new System.Windows.Forms.Button();
            this.tableauelevetbutton = new System.Windows.Forms.Button();
            this.modifierbutton = new System.Windows.Forms.Button();
            this.suppbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.listViewexam);
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1602, 701);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listViewexam
            // 
            this.listViewexam.CheckBoxes = true;
            this.listViewexam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.select,
            this.examinteuritem,
            this.dateitem});
            this.listViewexam.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewexam.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewexam.GridLines = true;
            this.listViewexam.Location = new System.Drawing.Point(0, 0);
            this.listViewexam.Name = "listViewexam";
            this.listViewexam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listViewexam.Size = new System.Drawing.Size(1602, 689);
            this.listViewexam.TabIndex = 3;
            this.listViewexam.UseCompatibleStateImageBehavior = false;
            this.listViewexam.View = System.Windows.Forms.View.Details;
            this.listViewexam.SelectedIndexChanged += new System.EventHandler(this.listViewexam_SelectedIndexChanged);
            // 
            // select
            // 
            this.select.Text = "Sélection";
            this.select.Width = 202;
            // 
            // examinteuritem
            // 
            this.examinteuritem.Text = "Examinateur";
            this.examinteuritem.Width = 500;
            // 
            // dateitem
            // 
            this.dateitem.Text = "Date d\'examen";
            this.dateitem.Width = 533;
            // 
            // examdateTimePicker
            // 
            this.examdateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examdateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examdateTimePicker.Location = new System.Drawing.Point(624, 12);
            this.examdateTimePicker.Name = "examdateTimePicker";
            this.examdateTimePicker.Size = new System.Drawing.Size(405, 39);
            this.examdateTimePicker.TabIndex = 2;
            // 
            // ajoutbutton
            // 
            this.ajoutbutton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajoutbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.ajoutbutton.Location = new System.Drawing.Point(12, -2);
            this.ajoutbutton.Name = "ajoutbutton";
            this.ajoutbutton.Size = new System.Drawing.Size(198, 66);
            this.ajoutbutton.TabIndex = 4;
            this.ajoutbutton.Text = "Ajouter ";
            this.ajoutbutton.UseVisualStyleBackColor = true;
            this.ajoutbutton.Click += new System.EventHandler(this.ajoutbutton_Click);
            // 
            // tableauelevetbutton
            // 
            this.tableauelevetbutton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableauelevetbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.tableauelevetbutton.Location = new System.Drawing.Point(1045, 3);
            this.tableauelevetbutton.Name = "tableauelevetbutton";
            this.tableauelevetbutton.Size = new System.Drawing.Size(369, 61);
            this.tableauelevetbutton.TabIndex = 1;
            this.tableauelevetbutton.Text = "Liste des examinants";
            this.tableauelevetbutton.UseVisualStyleBackColor = true;
            this.tableauelevetbutton.Click += new System.EventHandler(this.tableauelevetbutton_Click);
            // 
            // modifierbutton
            // 
            this.modifierbutton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.modifierbutton.Location = new System.Drawing.Point(216, 0);
            this.modifierbutton.Name = "modifierbutton";
            this.modifierbutton.Size = new System.Drawing.Size(202, 64);
            this.modifierbutton.TabIndex = 6;
            this.modifierbutton.Text = "Modifier";
            this.modifierbutton.UseVisualStyleBackColor = true;
            this.modifierbutton.Click += new System.EventHandler(this.modifierbutton_Click);
            // 
            // suppbutton
            // 
            this.suppbutton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.suppbutton.Location = new System.Drawing.Point(424, 0);
            this.suppbutton.Name = "suppbutton";
            this.suppbutton.Size = new System.Drawing.Size(194, 64);
            this.suppbutton.TabIndex = 5;
            this.suppbutton.Text = "Supprimer";
            this.suppbutton.UseVisualStyleBackColor = true;
            this.suppbutton.Click += new System.EventHandler(this.suppbutton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.modifierbutton);
            this.panel2.Controls.Add(this.ajoutbutton);
            this.panel2.Controls.Add(this.suppbutton);
            this.panel2.Controls.Add(this.examdateTimePicker);
            this.panel2.Controls.Add(this.tableauelevetbutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1602, 64);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // examen_gestionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1602, 771);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.Name = "examen_gestionnaire";
            this.Text = "examen_gestionnaire";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.examen_gestionnaire_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewexam;
        private System.Windows.Forms.ColumnHeader select;
        private System.Windows.Forms.ColumnHeader examinteuritem;
        private System.Windows.Forms.ColumnHeader dateitem;
        private System.Windows.Forms.DateTimePicker examdateTimePicker;
        private System.Windows.Forms.Button ajoutbutton;
        private System.Windows.Forms.Button tableauelevetbutton;
        private System.Windows.Forms.Button modifierbutton;
        private System.Windows.Forms.Button suppbutton;
        private System.Windows.Forms.Panel panel2;
    }
}