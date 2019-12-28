namespace WindowsFormsApp1
{
    partial class FormAcceuil
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
            this.components = new System.ComponentModel.Container();
            this.database1DataSet = new WindowsFormsApp1.DataSet1();
            this.eleveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eleveTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.eleveTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.DataSet1TableAdapters.TableAdapterManager();
            this.Menupanel = new System.Windows.Forms.Panel();
            this.dossiersannulesbutton = new System.Windows.Forms.Button();
            this.elevebutton = new System.Windows.Forms.Button();
            this.papierbutton = new System.Windows.Forms.Button();
            this.examenbutton = new System.Windows.Forms.Button();
            this.comptabilitbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleveBindingSource)).BeginInit();
            this.Menupanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eleveBindingSource
            // 
            this.eleveBindingSource.DataMember = "eleve";
            this.eleveBindingSource.DataSource = this.database1DataSet;
            // 
            // eleveTableAdapter
            // 
            this.eleveTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.eleveTableAdapter = this.eleveTableAdapter;
            this.tableAdapterManager.examenTableAdapter = null;
            this.tableAdapterManager.paiementTableAdapter = null;
            this.tableAdapterManager.passerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Menupanel
            // 
            this.Menupanel.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.Menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.Menupanel.Controls.Add(this.dossiersannulesbutton);
            this.Menupanel.Controls.Add(this.elevebutton);
            this.Menupanel.Controls.Add(this.papierbutton);
            this.Menupanel.Controls.Add(this.examenbutton);
            this.Menupanel.Controls.Add(this.comptabilitbutton);
            this.Menupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menupanel.Location = new System.Drawing.Point(0, 0);
            this.Menupanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Menupanel.Name = "Menupanel";
            this.Menupanel.Size = new System.Drawing.Size(364, 730);
            this.Menupanel.TabIndex = 0;
            this.Menupanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Menupanel_Paint);
            // 
            // dossiersannulesbutton
            // 
            this.dossiersannulesbutton.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dossiersannulesbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.dossiersannulesbutton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dossiersannulesbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.dossiersannulesbutton.Location = new System.Drawing.Point(5, 402);
            this.dossiersannulesbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dossiersannulesbutton.Name = "dossiersannulesbutton";
            this.dossiersannulesbutton.Size = new System.Drawing.Size(359, 90);
            this.dossiersannulesbutton.TabIndex = 5;
            this.dossiersannulesbutton.Text = "Dossier annulés";
            this.dossiersannulesbutton.UseVisualStyleBackColor = false;
            this.dossiersannulesbutton.Click += new System.EventHandler(this.dossiersannulesbutton_Click);
            // 
            // elevebutton
            // 
            this.elevebutton.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.elevebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.elevebutton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elevebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.elevebutton.Location = new System.Drawing.Point(4, 7);
            this.elevebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.elevebutton.Name = "elevebutton";
            this.elevebutton.Size = new System.Drawing.Size(360, 90);
            this.elevebutton.TabIndex = 1;
            this.elevebutton.Text = "Etudiants";
            this.elevebutton.UseVisualStyleBackColor = false;
            this.elevebutton.Click += new System.EventHandler(this.elevebutton_Click);
            // 
            // papierbutton
            // 
            this.papierbutton.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.papierbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.papierbutton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.papierbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.papierbutton.Location = new System.Drawing.Point(4, 302);
            this.papierbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.papierbutton.Name = "papierbutton";
            this.papierbutton.Size = new System.Drawing.Size(360, 90);
            this.papierbutton.TabIndex = 4;
            this.papierbutton.Text = "Fiches administratives";
            this.papierbutton.UseVisualStyleBackColor = false;
            this.papierbutton.Click += new System.EventHandler(this.papierbutton_Click);
            // 
            // examenbutton
            // 
            this.examenbutton.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.examenbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.examenbutton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examenbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.examenbutton.Location = new System.Drawing.Point(4, 107);
            this.examenbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.examenbutton.Name = "examenbutton";
            this.examenbutton.Size = new System.Drawing.Size(360, 90);
            this.examenbutton.TabIndex = 2;
            this.examenbutton.Text = "Examens";
            this.examenbutton.UseVisualStyleBackColor = false;
            this.examenbutton.Click += new System.EventHandler(this.examenbutton_Click);
            // 
            // comptabilitbutton
            // 
            this.comptabilitbutton.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.comptabilitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.comptabilitbutton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comptabilitbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.comptabilitbutton.Location = new System.Drawing.Point(5, 204);
            this.comptabilitbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comptabilitbutton.Name = "comptabilitbutton";
            this.comptabilitbutton.Size = new System.Drawing.Size(359, 90);
            this.comptabilitbutton.TabIndex = 3;
            this.comptabilitbutton.Text = "Comptabilité";
            this.comptabilitbutton.UseVisualStyleBackColor = false;
            this.comptabilitbutton.Click += new System.EventHandler(this.comptabilitbutton_Click);
            // 
            // FormAcceuil
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 730);
            this.Controls.Add(this.Menupanel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAcceuil";
            this.Text = "Acceuil";
            this.Load += new System.EventHandler(this.FormAcceuil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleveBindingSource)).EndInit();
            this.Menupanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 database1DataSet;
        private System.Windows.Forms.BindingSource eleveBindingSource;
        private DataSet1TableAdapters.eleveTableAdapter eleveTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel Menupanel;
        private System.Windows.Forms.Button dossiersannulesbutton;
        private System.Windows.Forms.Button papierbutton;
        private System.Windows.Forms.Button comptabilitbutton;
        private System.Windows.Forms.Button examenbutton;
        private System.Windows.Forms.Button elevebutton;
    }
}