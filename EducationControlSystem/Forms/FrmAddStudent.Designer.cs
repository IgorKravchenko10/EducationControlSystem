namespace EducationControlSystem
{
    partial class FrmAddStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkBoxIsAbroad = new System.Windows.Forms.CheckBox();
            this.checkBoxOnContract = new System.Windows.Forms.CheckBox();
            this.checkBoxIsLeader = new System.Windows.Forms.CheckBox();
            this.cmbStudyGroups = new System.Windows.Forms.ComboBox();
            this.txtBoxYearEntry = new System.Windows.Forms.TextBox();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date of birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year entry:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Study group:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(98, 6);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(245, 21);
            this.txtBoxName.TabIndex = 7;
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(98, 84);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(245, 21);
            this.txtBoxPhoneNumber.TabIndex = 8;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBirth.Location = new System.Drawing.Point(98, 32);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(245, 21);
            this.dateTimePickerBirth.TabIndex = 9;
            this.dateTimePickerBirth.Value = new System.DateTime(1996, 1, 1, 0, 0, 0, 0);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(187, 212);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(268, 212);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkBoxIsAbroad
            // 
            this.checkBoxIsAbroad.AutoSize = true;
            this.checkBoxIsAbroad.Location = new System.Drawing.Point(98, 137);
            this.checkBoxIsAbroad.Name = "checkBoxIsAbroad";
            this.checkBoxIsAbroad.Size = new System.Drawing.Size(72, 17);
            this.checkBoxIsAbroad.TabIndex = 16;
            this.checkBoxIsAbroad.Text = "Is abroad";
            this.checkBoxIsAbroad.UseVisualStyleBackColor = true;
            // 
            // checkBoxOnContract
            // 
            this.checkBoxOnContract.AutoSize = true;
            this.checkBoxOnContract.Location = new System.Drawing.Point(98, 160);
            this.checkBoxOnContract.Name = "checkBoxOnContract";
            this.checkBoxOnContract.Size = new System.Drawing.Size(83, 17);
            this.checkBoxOnContract.TabIndex = 16;
            this.checkBoxOnContract.Text = "On contract";
            this.checkBoxOnContract.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsLeader
            // 
            this.checkBoxIsLeader.AutoSize = true;
            this.checkBoxIsLeader.Location = new System.Drawing.Point(98, 183);
            this.checkBoxIsLeader.Name = "checkBoxIsLeader";
            this.checkBoxIsLeader.Size = new System.Drawing.Size(142, 17);
            this.checkBoxIsLeader.TabIndex = 16;
            this.checkBoxIsLeader.Text = "Is leader of study group";
            this.checkBoxIsLeader.UseVisualStyleBackColor = true;
            // 
            // cmbStudyGroups
            // 
            this.cmbStudyGroups.FormattingEnabled = true;
            this.cmbStudyGroups.Location = new System.Drawing.Point(98, 110);
            this.cmbStudyGroups.Name = "cmbStudyGroups";
            this.cmbStudyGroups.Size = new System.Drawing.Size(245, 21);
            this.cmbStudyGroups.TabIndex = 17;
            // 
            // txtBoxYearEntry
            // 
            this.txtBoxYearEntry.Location = new System.Drawing.Point(98, 58);
            this.txtBoxYearEntry.Name = "txtBoxYearEntry";
            this.txtBoxYearEntry.Size = new System.Drawing.Size(245, 21);
            this.txtBoxYearEntry.TabIndex = 18;
            // 
            // FrmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 244);
            this.Controls.Add(this.txtBoxYearEntry);
            this.Controls.Add(this.cmbStudyGroups);
            this.Controls.Add(this.checkBoxIsLeader);
            this.Controls.Add(this.checkBoxOnContract);
            this.Controls.Add(this.checkBoxIsAbroad);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.txtBoxPhoneNumber);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Name = "FrmAddStudent";
            this.Text = "Adding student";
            this.Load += new System.EventHandler(this.FrmAddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxPhoneNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkBoxIsAbroad;
        private System.Windows.Forms.CheckBox checkBoxOnContract;
        private System.Windows.Forms.CheckBox checkBoxIsLeader;
        private System.Windows.Forms.ComboBox cmbStudyGroups;
        private System.Windows.Forms.TextBox txtBoxYearEntry;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}