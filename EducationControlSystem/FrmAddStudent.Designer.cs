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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxIsAbroad = new System.Windows.Forms.CheckBox();
            this.checkBoxOnContract = new System.Windows.Forms.CheckBox();
            this.checkBoxIsLeader = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdStudyGroups = new System.Windows.Forms.ComboBox();
            this.txtBoxYearEntry = new System.Windows.Forms.TextBox();
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
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date of birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year entry:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone number:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(143, 6);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(281, 20);
            this.txtBoxName.TabIndex = 7;
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(143, 84);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.txtBoxPhoneNumber.TabIndex = 8;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBirth.Location = new System.Drawing.Point(143, 32);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBirth.TabIndex = 9;
            this.dateTimePickerBirth.Value = new System.DateTime(2016, 10, 10, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(268, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(349, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxIsAbroad
            // 
            this.checkBoxIsAbroad.AutoSize = true;
            this.checkBoxIsAbroad.Location = new System.Drawing.Point(143, 137);
            this.checkBoxIsAbroad.Name = "checkBoxIsAbroad";
            this.checkBoxIsAbroad.Size = new System.Drawing.Size(70, 17);
            this.checkBoxIsAbroad.TabIndex = 16;
            this.checkBoxIsAbroad.Text = "Is abroad";
            this.checkBoxIsAbroad.UseVisualStyleBackColor = true;
            // 
            // checkBoxOnContract
            // 
            this.checkBoxOnContract.AutoSize = true;
            this.checkBoxOnContract.Location = new System.Drawing.Point(143, 160);
            this.checkBoxOnContract.Name = "checkBoxOnContract";
            this.checkBoxOnContract.Size = new System.Drawing.Size(82, 17);
            this.checkBoxOnContract.TabIndex = 16;
            this.checkBoxOnContract.Text = "On contract";
            this.checkBoxOnContract.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsLeader
            // 
            this.checkBoxIsLeader.AutoSize = true;
            this.checkBoxIsLeader.Location = new System.Drawing.Point(143, 183);
            this.checkBoxIsLeader.Name = "checkBoxIsLeader";
            this.checkBoxIsLeader.Size = new System.Drawing.Size(136, 17);
            this.checkBoxIsLeader.TabIndex = 16;
            this.checkBoxIsLeader.Text = "Is leader of study group";
            this.checkBoxIsLeader.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Study group:";
            // 
            // cmdStudyGroups
            // 
            this.cmdStudyGroups.DisplayMember = "Prx";
            this.cmdStudyGroups.FormattingEnabled = true;
            this.cmdStudyGroups.Location = new System.Drawing.Point(143, 110);
            this.cmdStudyGroups.Name = "cmdStudyGroups";
            this.cmdStudyGroups.Size = new System.Drawing.Size(200, 21);
            this.cmdStudyGroups.TabIndex = 17;
            this.cmdStudyGroups.SelectedIndexChanged += new System.EventHandler(this.cmdStudyGroups_SelectedIndexChanged);
            // 
            // txtBoxYearEntry
            // 
            this.txtBoxYearEntry.Location = new System.Drawing.Point(143, 58);
            this.txtBoxYearEntry.Name = "txtBoxYearEntry";
            this.txtBoxYearEntry.Size = new System.Drawing.Size(200, 20);
            this.txtBoxYearEntry.TabIndex = 18;
            // 
            // FrmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 249);
            this.Controls.Add(this.txtBoxYearEntry);
            this.Controls.Add(this.cmdStudyGroups);
            this.Controls.Add(this.checkBoxIsLeader);
            this.Controls.Add(this.checkBoxOnContract);
            this.Controls.Add(this.checkBoxIsAbroad);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.txtBoxPhoneNumber);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxPhoneNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxIsAbroad;
        private System.Windows.Forms.CheckBox checkBoxOnContract;
        private System.Windows.Forms.CheckBox checkBoxIsLeader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmdStudyGroups;
        private System.Windows.Forms.TextBox txtBoxYearEntry;
    }
}