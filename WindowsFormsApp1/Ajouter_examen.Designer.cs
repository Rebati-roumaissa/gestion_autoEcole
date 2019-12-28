namespace WindowsFormsApp1
{
    partial class Ajouter_examen
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
            this.DatetextBox = new System.Windows.Forms.TextBox();
            this.ExamintextBox = new System.Windows.Forms.TextBox();
            this.examinateurnomtextbox = new System.Windows.Forms.TextBox();
            this.examendateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.codebutton = new System.Windows.Forms.Button();
            this.crenobutton = new System.Windows.Forms.Button();
            this.conduitebutton = new System.Windows.Forms.Button();
            this.confirmerbutton = new System.Windows.Forms.Button();
            this.Annulerbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DatetextBox
            // 
            this.DatetextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.DatetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatetextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.DatetextBox.Location = new System.Drawing.Point(45, 76);
            this.DatetextBox.Name = "DatetextBox";
            this.DatetextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DatetextBox.Size = new System.Drawing.Size(228, 44);
            this.DatetextBox.TabIndex = 0;
            this.DatetextBox.Text = "Date d\'examen";
            // 
            // ExamintextBox
            // 
            this.ExamintextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.ExamintextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamintextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.ExamintextBox.Location = new System.Drawing.Point(45, 142);
            this.ExamintextBox.Name = "ExamintextBox";
            this.ExamintextBox.ReadOnly = true;
            this.ExamintextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExamintextBox.Size = new System.Drawing.Size(228, 44);
            this.ExamintextBox.TabIndex = 1;
            this.ExamintextBox.Text = "Examinateur";
            // 
            // examinateurnomtextbox
            // 
            this.examinateurnomtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examinateurnomtextbox.Location = new System.Drawing.Point(279, 142);
            this.examinateurnomtextbox.Name = "examinateurnomtextbox";
            this.examinateurnomtextbox.Size = new System.Drawing.Size(469, 39);
            this.examinateurnomtextbox.TabIndex = 2;
            // 
            // examendateTimePicker
            // 
            this.examendateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examendateTimePicker.Location = new System.Drawing.Point(279, 76);
            this.examendateTimePicker.Name = "examendateTimePicker";
            this.examendateTimePicker.Size = new System.Drawing.Size(473, 39);
            this.examendateTimePicker.TabIndex = 3;
            // 
            // codebutton
            // 
            this.codebutton.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codebutton.Location = new System.Drawing.Point(77, 256);
            this.codebutton.Name = "codebutton";
            this.codebutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.codebutton.Size = new System.Drawing.Size(184, 64);
            this.codebutton.TabIndex = 4;
            this.codebutton.Text = "Code";
            this.codebutton.UseVisualStyleBackColor = true;
            this.codebutton.Click += new System.EventHandler(this.codebutton_Click);
            // 
            // crenobutton
            // 
            this.crenobutton.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crenobutton.Location = new System.Drawing.Point(279, 256);
            this.crenobutton.Name = "crenobutton";
            this.crenobutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.crenobutton.Size = new System.Drawing.Size(179, 64);
            this.crenobutton.TabIndex = 5;
            this.crenobutton.Text = "Creno";
            this.crenobutton.UseVisualStyleBackColor = true;
            this.crenobutton.Click += new System.EventHandler(this.crenobutton_Click);
            // 
            // conduitebutton
            // 
            this.conduitebutton.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conduitebutton.Location = new System.Drawing.Point(474, 256);
            this.conduitebutton.Name = "conduitebutton";
            this.conduitebutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.conduitebutton.Size = new System.Drawing.Size(165, 64);
            this.conduitebutton.TabIndex = 6;
            this.conduitebutton.Text = "Conduite";
            this.conduitebutton.UseVisualStyleBackColor = true;
            this.conduitebutton.Click += new System.EventHandler(this.conduitebutton_Click);
            // 
            // confirmerbutton
            // 
            this.confirmerbutton.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmerbutton.Location = new System.Drawing.Point(196, 332);
            this.confirmerbutton.Name = "confirmerbutton";
            this.confirmerbutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.confirmerbutton.Size = new System.Drawing.Size(169, 61);
            this.confirmerbutton.TabIndex = 7;
            this.confirmerbutton.Text = "Confirmer";
            this.confirmerbutton.UseVisualStyleBackColor = true;
            this.confirmerbutton.Click += new System.EventHandler(this.confirmerbutton_Click);
            // 
            // Annulerbutton
            // 
            this.Annulerbutton.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annulerbutton.Location = new System.Drawing.Point(381, 332);
            this.Annulerbutton.Name = "Annulerbutton";
            this.Annulerbutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Annulerbutton.Size = new System.Drawing.Size(172, 61);
            this.Annulerbutton.TabIndex = 8;
            this.Annulerbutton.Text = "Annuler";
            this.Annulerbutton.UseVisualStyleBackColor = true;
            this.Annulerbutton.Click += new System.EventHandler(this.Annulerbutton_Click);
            // 
            // Ajouter_examen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Annulerbutton);
            this.Controls.Add(this.confirmerbutton);
            this.Controls.Add(this.conduitebutton);
            this.Controls.Add(this.crenobutton);
            this.Controls.Add(this.codebutton);
            this.Controls.Add(this.examendateTimePicker);
            this.Controls.Add(this.examinateurnomtextbox);
            this.Controls.Add(this.ExamintextBox);
            this.Controls.Add(this.DatetextBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.Name = "Ajouter_examen";
            this.Text = "Ajouter_examen";
            this.Load += new System.EventHandler(this.Ajouter_examen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DatetextBox;
        private System.Windows.Forms.TextBox ExamintextBox;
        private System.Windows.Forms.TextBox examinateurnomtextbox;
        private System.Windows.Forms.DateTimePicker examendateTimePicker;
        private System.Windows.Forms.Button codebutton;
        private System.Windows.Forms.Button crenobutton;
        private System.Windows.Forms.Button conduitebutton;
        private System.Windows.Forms.Button confirmerbutton;
        private System.Windows.Forms.Button Annulerbutton;
    }
}