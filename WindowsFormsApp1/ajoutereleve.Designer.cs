using System.Drawing;

namespace WindowsFormsApp1
{
    partial class ajoutereleveform
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
            this.prenomtextBox = new System.Windows.Forms.TextBox();
            this.nomtextBox = new System.Windows.Forms.TextBox();
            this.nomparenttextBox = new System.Windows.Forms.TextBox();
            this.datenaissancetextBox = new System.Windows.Forms.TextBox();
            this.lieunaissancetextBox = new System.Windows.Forms.TextBox();
            this.adressetextBox = new System.Windows.Forms.TextBox();
            this.numerodossiertextBox = new System.Windows.Forms.TextBox();
            this.prentextBox = new System.Windows.Forms.TextBox();
            this.lieutextBox = new System.Windows.Forms.TextBox();
            this.adrtextBox = new System.Windows.Forms.TextBox();
            this.dosstextBox = new System.Windows.Forms.TextBox();
            this.preperetextBox = new System.Windows.Forms.TextBox();
            this.namtextBox = new System.Windows.Forms.TextBox();
            this.dateenttextBox = new System.Windows.Forms.TextBox();
            this.datenaissanceTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateentreeTimePicker = new System.Windows.Forms.DateTimePicker();
            this.savebutton = new System.Windows.Forms.Button();
            this.annulerbutton = new System.Windows.Forms.Button();
            this.montantvaluetextBox = new System.Windows.Forms.TextBox();
            this.montextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // prenomtextBox
            // 
            this.prenomtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.prenomtextBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomtextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.prenomtextBox.Location = new System.Drawing.Point(28, 44);
            this.prenomtextBox.Name = "prenomtextBox";
            this.prenomtextBox.ReadOnly = true;
            this.prenomtextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prenomtextBox.Size = new System.Drawing.Size(193, 51);
            this.prenomtextBox.TabIndex = 10;
            this.prenomtextBox.Text = "Prénom";
            this.prenomtextBox.TextChanged += new System.EventHandler(this.nomtextBox_TextChanged);
            // 
            // nomtextBox
            // 
            this.nomtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.nomtextBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomtextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.nomtextBox.Location = new System.Drawing.Point(28, 94);
            this.nomtextBox.Name = "nomtextBox";
            this.nomtextBox.ReadOnly = true;
            this.nomtextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nomtextBox.Size = new System.Drawing.Size(193, 51);
            this.nomtextBox.TabIndex = 11;
            this.nomtextBox.Text = "Nom";
            this.nomtextBox.TextChanged += new System.EventHandler(this.prenomtextBox_TextChanged);
            // 
            // nomparenttextBox
            // 
            this.nomparenttextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.nomparenttextBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomparenttextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.nomparenttextBox.Location = new System.Drawing.Point(28, 142);
            this.nomparenttextBox.Name = "nomparenttextBox";
            this.nomparenttextBox.ReadOnly = true;
            this.nomparenttextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nomparenttextBox.Size = new System.Drawing.Size(193, 51);
            this.nomparenttextBox.TabIndex = 12;
            this.nomparenttextBox.Text = "Père";
            this.nomparenttextBox.TextChanged += new System.EventHandler(this.nomparenttextBox_TextChanged);
            // 
            // datenaissancetextBox
            // 
            this.datenaissancetextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.datenaissancetextBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datenaissancetextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.datenaissancetextBox.Location = new System.Drawing.Point(28, 191);
            this.datenaissancetextBox.Name = "datenaissancetextBox";
            this.datenaissancetextBox.ReadOnly = true;
            this.datenaissancetextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datenaissancetextBox.Size = new System.Drawing.Size(288, 51);
            this.datenaissancetextBox.TabIndex = 13;
            this.datenaissancetextBox.Text = "Date de naissance";
            this.datenaissancetextBox.TextChanged += new System.EventHandler(this.datenaissancetextBox_TextChanged);
            // 
            // lieunaissancetextBox
            // 
            this.lieunaissancetextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.lieunaissancetextBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lieunaissancetextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.lieunaissancetextBox.Location = new System.Drawing.Point(28, 239);
            this.lieunaissancetextBox.Name = "lieunaissancetextBox";
            this.lieunaissancetextBox.ReadOnly = true;
            this.lieunaissancetextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lieunaissancetextBox.Size = new System.Drawing.Size(269, 51);
            this.lieunaissancetextBox.TabIndex = 14;
            this.lieunaissancetextBox.Text = "Lieu de naissance";
            this.lieunaissancetextBox.TextChanged += new System.EventHandler(this.lieunaissancetextBox_TextChanged);
            // 
            // adressetextBox
            // 
            this.adressetextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.adressetextBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressetextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.adressetextBox.Location = new System.Drawing.Point(28, 290);
            this.adressetextBox.Name = "adressetextBox";
            this.adressetextBox.ReadOnly = true;
            this.adressetextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adressetextBox.Size = new System.Drawing.Size(193, 51);
            this.adressetextBox.TabIndex = 15;
            this.adressetextBox.Text = "Adresse";
            this.adressetextBox.TextChanged += new System.EventHandler(this.adressetextBox_TextChanged);
            // 
            // numerodossiertextBox
            // 
            this.numerodossiertextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.numerodossiertextBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerodossiertextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.numerodossiertextBox.Location = new System.Drawing.Point(28, 339);
            this.numerodossiertextBox.Name = "numerodossiertextBox";
            this.numerodossiertextBox.ReadOnly = true;
            this.numerodossiertextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numerodossiertextBox.Size = new System.Drawing.Size(288, 51);
            this.numerodossiertextBox.TabIndex = 16;
            this.numerodossiertextBox.Text = "Numéro de dossier";
            this.numerodossiertextBox.TextChanged += new System.EventHandler(this.numerodossiertextBox_TextChanged);
            // 
            // prentextBox
            // 
            this.prentextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prentextBox.Location = new System.Drawing.Point(322, 44);
            this.prentextBox.Name = "prentextBox";
            this.prentextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.prentextBox.Size = new System.Drawing.Size(433, 39);
            this.prentextBox.TabIndex = 0;
            this.prentextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lieutextBox
            // 
            this.lieutextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lieutextBox.Location = new System.Drawing.Point(322, 247);
            this.lieutextBox.Name = "lieutextBox";
            this.lieutextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lieutextBox.Size = new System.Drawing.Size(433, 39);
            this.lieutextBox.TabIndex = 4;
            // 
            // adrtextBox
            // 
            this.adrtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adrtextBox.Location = new System.Drawing.Point(322, 298);
            this.adrtextBox.Name = "adrtextBox";
            this.adrtextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.adrtextBox.Size = new System.Drawing.Size(433, 39);
            this.adrtextBox.TabIndex = 5;
            // 
            // dosstextBox
            // 
            this.dosstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosstextBox.Location = new System.Drawing.Point(322, 351);
            this.dosstextBox.Name = "dosstextBox";
            this.dosstextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dosstextBox.Size = new System.Drawing.Size(433, 39);
            this.dosstextBox.TabIndex = 6;
            this.dosstextBox.TextChanged += new System.EventHandler(this.dosstextBox_TextChanged);
            // 
            // preperetextBox
            // 
            this.preperetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preperetextBox.Location = new System.Drawing.Point(322, 146);
            this.preperetextBox.Name = "preperetextBox";
            this.preperetextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.preperetextBox.Size = new System.Drawing.Size(433, 39);
            this.preperetextBox.TabIndex = 2;
            // 
            // namtextBox
            // 
            this.namtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namtextBox.Location = new System.Drawing.Point(322, 94);
            this.namtextBox.Name = "namtextBox";
            this.namtextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.namtextBox.Size = new System.Drawing.Size(433, 39);
            this.namtextBox.TabIndex = 1;
            // 
            // dateenttextBox
            // 
            this.dateenttextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.dateenttextBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateenttextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.dateenttextBox.Location = new System.Drawing.Point(28, 393);
            this.dateenttextBox.Name = "dateenttextBox";
            this.dateenttextBox.ReadOnly = true;
            this.dateenttextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateenttextBox.Size = new System.Drawing.Size(256, 51);
            this.dateenttextBox.TabIndex = 17;
            this.dateenttextBox.Text = "Date d\'entrée";
            // 
            // datenaissanceTimePicker
            // 
            this.datenaissanceTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datenaissanceTimePicker.Location = new System.Drawing.Point(322, 197);
            this.datenaissanceTimePicker.Name = "datenaissanceTimePicker";
            this.datenaissanceTimePicker.Size = new System.Drawing.Size(433, 39);
            this.datenaissanceTimePicker.TabIndex = 3;
            // 
            // dateentreeTimePicker
            // 
            this.dateentreeTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateentreeTimePicker.Location = new System.Drawing.Point(322, 405);
            this.dateentreeTimePicker.Name = "dateentreeTimePicker";
            this.dateentreeTimePicker.Size = new System.Drawing.Size(433, 39);
            this.dateentreeTimePicker.TabIndex = 7;
            this.dateentreeTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.Location = new System.Drawing.Point(187, 513);
            this.savebutton.Name = "savebutton";
            this.savebutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.savebutton.Size = new System.Drawing.Size(218, 61);
            this.savebutton.TabIndex = 8;
            this.savebutton.Text = "Sauvegarder";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click_1);
            // 
            // annulerbutton
            // 
            this.annulerbutton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annulerbutton.Location = new System.Drawing.Point(434, 513);
            this.annulerbutton.Name = "annulerbutton";
            this.annulerbutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.annulerbutton.Size = new System.Drawing.Size(190, 61);
            this.annulerbutton.TabIndex = 9;
            this.annulerbutton.Text = "Annuler";
            this.annulerbutton.UseVisualStyleBackColor = true;
            this.annulerbutton.Click += new System.EventHandler(this.annulerbutton_Click);
            // 
            // montantvaluetextBox
            // 
            this.montantvaluetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montantvaluetextBox.Location = new System.Drawing.Point(322, 456);
            this.montantvaluetextBox.Name = "montantvaluetextBox";
            this.montantvaluetextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.montantvaluetextBox.Size = new System.Drawing.Size(433, 39);
            this.montantvaluetextBox.TabIndex = 18;
            this.montantvaluetextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // montextBox
            // 
            this.montextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.montextBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.montextBox.Location = new System.Drawing.Point(28, 444);
            this.montextBox.Name = "montextBox";
            this.montextBox.ReadOnly = true;
            this.montextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.montextBox.Size = new System.Drawing.Size(256, 51);
            this.montextBox.TabIndex = 19;
            this.montextBox.Text = "Montant à payer";
            this.montextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ajoutereleveform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.montantvaluetextBox);
            this.Controls.Add(this.montextBox);
            this.Controls.Add(this.annulerbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.dateentreeTimePicker);
            this.Controls.Add(this.datenaissanceTimePicker);
            this.Controls.Add(this.dateenttextBox);
            this.Controls.Add(this.namtextBox);
            this.Controls.Add(this.preperetextBox);
            this.Controls.Add(this.dosstextBox);
            this.Controls.Add(this.adrtextBox);
            this.Controls.Add(this.lieutextBox);
            this.Controls.Add(this.prentextBox);
            this.Controls.Add(this.numerodossiertextBox);
            this.Controls.Add(this.adressetextBox);
            this.Controls.Add(this.lieunaissancetextBox);
            this.Controls.Add(this.datenaissancetextBox);
            this.Controls.Add(this.nomparenttextBox);
            this.Controls.Add(this.nomtextBox);
            this.Controls.Add(this.prenomtextBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.Name = "ajoutereleveform";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ajoutereleve";
            this.Load += new System.EventHandler(this.ajoutereleveform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prenomtextBox;
        private System.Windows.Forms.TextBox nomtextBox;
        private System.Windows.Forms.TextBox nomparenttextBox;
        private System.Windows.Forms.TextBox datenaissancetextBox;
        private System.Windows.Forms.TextBox lieunaissancetextBox;
        private System.Windows.Forms.TextBox adressetextBox;
        private System.Windows.Forms.TextBox numerodossiertextBox;
        private System.Windows.Forms.TextBox prentextBox;
        private System.Windows.Forms.TextBox lieutextBox;
        private System.Windows.Forms.TextBox adrtextBox;
        private System.Windows.Forms.TextBox dosstextBox;
        private System.Windows.Forms.TextBox preperetextBox;
        private System.Windows.Forms.TextBox namtextBox;
        private System.Windows.Forms.TextBox dateenttextBox;
        private System.Windows.Forms.DateTimePicker datenaissanceTimePicker;
        private System.Windows.Forms.DateTimePicker dateentreeTimePicker;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button annulerbutton;
        private System.Windows.Forms.TextBox montantvaluetextBox;
        private System.Windows.Forms.TextBox montextBox;
    }
}