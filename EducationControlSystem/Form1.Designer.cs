namespace EducationControlSystem
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grvStudents = new System.Windows.Forms.DataGridView();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.grvSubjects = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bndStudyGroups = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEntryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAbroadDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isContractDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bndStudents = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndStudyGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(218, 462);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grvSubjects);
            this.panel1.Controls.Add(this.grvStudents);
            this.panel1.Location = new System.Drawing.Point(236, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 462);
            this.panel1.TabIndex = 2;
            // 
            // grvStudents
            // 
            this.grvStudents.AllowUserToAddRows = false;
            this.grvStudents.AllowUserToDeleteRows = false;
            this.grvStudents.AutoGenerateColumns = false;
            this.grvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.dateEntryDataGridViewTextBoxColumn,
            this.isAbroadDataGridViewCheckBoxColumn,
            this.isContractDataGridViewCheckBoxColumn});
            this.grvStudents.DataSource = this.bndStudents;
            this.grvStudents.Location = new System.Drawing.Point(0, 0);
            this.grvStudents.Name = "grvStudents";
            this.grvStudents.ReadOnly = true;
            this.grvStudents.Size = new System.Drawing.Size(353, 187);
            this.grvStudents.TabIndex = 0;
            // 
            // grvSubjects
            // 
            this.grvSubjects.AllowUserToAddRows = false;
            this.grvSubjects.AllowUserToDeleteRows = false;
            this.grvSubjects.AutoGenerateColumns = false;
            this.grvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.grvSubjects.DataSource = this.bndStudyGroups;
            this.grvSubjects.Location = new System.Drawing.Point(0, 193);
            this.grvSubjects.Name = "grvSubjects";
            this.grvSubjects.ReadOnly = true;
            this.grvSubjects.Size = new System.Drawing.Size(353, 187);
            this.grvSubjects.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ім\'я";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // bndStudyGroups
            // 
            this.bndStudyGroups.DataSource = typeof(EducationControlSystem.ProxyClasses.PrxStudyGroup);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Номер телефону";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEntryDataGridViewTextBoxColumn
            // 
            this.dateEntryDataGridViewTextBoxColumn.DataPropertyName = "DateEntry";
            this.dateEntryDataGridViewTextBoxColumn.HeaderText = "Дата вступу";
            this.dateEntryDataGridViewTextBoxColumn.Name = "dateEntryDataGridViewTextBoxColumn";
            this.dateEntryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isAbroadDataGridViewCheckBoxColumn
            // 
            this.isAbroadDataGridViewCheckBoxColumn.DataPropertyName = "IsAbroad";
            this.isAbroadDataGridViewCheckBoxColumn.HeaderText = "За кордоном";
            this.isAbroadDataGridViewCheckBoxColumn.Name = "isAbroadDataGridViewCheckBoxColumn";
            this.isAbroadDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isContractDataGridViewCheckBoxColumn
            // 
            this.isContractDataGridViewCheckBoxColumn.DataPropertyName = "IsContract";
            this.isContractDataGridViewCheckBoxColumn.HeaderText = "Контрактна форма навчання";
            this.isContractDataGridViewCheckBoxColumn.Name = "isContractDataGridViewCheckBoxColumn";
            this.isContractDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bndStudents
            // 
            this.bndStudents.DataSource = typeof(EducationControlSystem.ProxyClasses.PrxStudent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndStudyGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grvStudents;
        private System.Windows.Forms.BindingSource bndStudents;
        private System.Windows.Forms.BindingSource bndStudyGroups;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEntryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAbroadDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isContractDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView grvSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

