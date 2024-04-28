
namespace CsvToDb
{
    partial class Form1
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
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.cnttableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsDataSet = new CsvToDb.ContactsDataSet();
            this.cnt_tableTableAdapter = new CsvToDb.ContactsDataSetTableAdapters.Cnt_tableTableAdapter();
            this.btnExpToCSV = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnImportToDb = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.contactsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cnttableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnttableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnttableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgItems
            // 
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Location = new System.Drawing.Point(12, 59);
            this.dgItems.Name = "dgItems";
            this.dgItems.RowHeadersWidth = 51;
            this.dgItems.RowTemplate.Height = 24;
            this.dgItems.Size = new System.Drawing.Size(740, 310);
            this.dgItems.TabIndex = 0;
            // 
            // cnttableBindingSource
            // 
            this.cnttableBindingSource.DataMember = "Cnt_table";
            this.cnttableBindingSource.DataSource = this.contactsDataSet;
            // 
            // contactsDataSet
            // 
            this.contactsDataSet.DataSetName = "ContactsDataSet";
            this.contactsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cnt_tableTableAdapter
            // 
            this.cnt_tableTableAdapter.ClearBeforeFill = true;
            // 
            // btnExpToCSV
            // 
            this.btnExpToCSV.Location = new System.Drawing.Point(294, 391);
            this.btnExpToCSV.Name = "btnExpToCSV";
            this.btnExpToCSV.Size = new System.Drawing.Size(148, 34);
            this.btnExpToCSV.TabIndex = 1;
            this.btnExpToCSV.Text = "Eksportuoti i CSV";
            this.btnExpToCSV.UseVisualStyleBackColor = true;
            this.btnExpToCSV.Click += new System.EventHandler(this.btnExpToCSV_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImportToDb
            // 
            this.btnImportToDb.Location = new System.Drawing.Point(475, 391);
            this.btnImportToDb.Name = "btnImportToDb";
            this.btnImportToDb.Size = new System.Drawing.Size(156, 39);
            this.btnImportToDb.TabIndex = 2;
            this.btnImportToDb.Text = "Importuotti i Programa";
            this.btnImportToDb.UseVisualStyleBackColor = true;
            this.btnImportToDb.Click += new System.EventHandler(this.btnImportToDb_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(659, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 39);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(327, 12);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(144, 22);
            this.txtFile.TabIndex = 5;
            // 
            // contactsDataSetBindingSource
            // 
            this.contactsDataSetBindingSource.DataSource = this.contactsDataSet;
            this.contactsDataSetBindingSource.Position = 0;
            // 
            // cnttableBindingSource1
            // 
            this.cnttableBindingSource1.DataMember = "Cnt_table";
            this.cnttableBindingSource1.DataSource = this.contactsDataSetBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Failas ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnImportToDb);
            this.Controls.Add(this.btnExpToCSV);
            this.Controls.Add(this.dgItems);
            this.Name = "Form1";
            this.Text = "CSV Importas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnttableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnttableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgItems;
        private ContactsDataSet contactsDataSet;
        private System.Windows.Forms.BindingSource cnttableBindingSource;
        private ContactsDataSetTableAdapters.Cnt_tableTableAdapter cnt_tableTableAdapter;
        private System.Windows.Forms.Button btnExpToCSV;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnImportToDb;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.BindingSource contactsDataSetBindingSource;
        private System.Windows.Forms.BindingSource cnttableBindingSource1;
        private System.Windows.Forms.Label label1;
    }
}

