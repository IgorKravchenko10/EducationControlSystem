namespace EducationControlSystem
{
    partial class FrmAddStudyGroup
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
            this.checkBoxIsLeader = new System.Windows.Forms.CheckBox();
            this.checkBoxOnContract = new System.Windows.Forms.CheckBox();
            this.checkBoxIsAbroad = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxIsLeader
            // 
            this.checkBoxIsLeader.AutoSize = true;
            this.checkBoxIsLeader.Location = new System.Drawing.Point(143, 158);
            this.checkBoxIsLeader.Name = "checkBoxIsLeader";
            this.checkBoxIsLeader.Size = new System.Drawing.Size(136, 17);
            this.checkBoxIsLeader.TabIndex = 29;
            this.checkBoxIsLeader.Text = "Is leader of study group";
            this.checkBoxIsLeader.UseVisualStyleBackColor = true;
            // 
            // checkBoxOnContract
            // 
            this.checkBoxOnContract.AutoSize = true;
            this.checkBoxOnContract.Location = new System.Drawing.Point(143, 135);
            this.checkBoxOnContract.Name = "checkBoxOnContract";
            this.checkBoxOnContract.Size = new System.Drawing.Size(82, 17);
            this.checkBoxOnContract.TabIndex = 30;
            this.checkBoxOnContract.Text = "On contract";
            this.checkBoxOnContract.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsAbroad
            // 
            this.checkBoxIsAbroad.AutoSize = true;
            this.checkBoxIsAbroad.Location = new System.Drawing.Point(143, 112);
            this.checkBoxIsAbroad.Name = "checkBoxIsAbroad";
            this.checkBoxIsAbroad.Size = new System.Drawing.Size(70, 17);
            this.checkBoxIsAbroad.TabIndex = 31;
            this.checkBoxIsAbroad.Text = "Is abroad";
            this.checkBoxIsAbroad.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(349, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(268, 189);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 27;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(143, 6);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(281, 20);
            this.txtBoxName.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name:";
            // 
            // FrmAddStudyGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 326);
            this.Controls.Add(this.checkBoxIsLeader);
            this.Controls.Add(this.checkBoxOnContract);
            this.Controls.Add(this.checkBoxIsAbroad);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddStudyGroup";
            this.Text = "FrmAddStudyGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxIsLeader;
        private System.Windows.Forms.CheckBox checkBoxOnContract;
        private System.Windows.Forms.CheckBox checkBoxIsAbroad;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label label1;
    }
}