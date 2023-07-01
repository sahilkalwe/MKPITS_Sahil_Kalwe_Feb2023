namespace Registeration_Form
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelMno = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxage = new System.Windows.Forms.TextBox();
            this.textBoxMno = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBoxRegistrationForm = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxRegistrationForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.IndianRed;
            this.labelName.Location = new System.Drawing.Point(6, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(6, 60);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(33, 17);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "Age";
            // 
            // labelMno
            // 
            this.labelMno.AutoSize = true;
            this.labelMno.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMno.ForeColor = System.Drawing.Color.IndianRed;
            this.labelMno.Location = new System.Drawing.Point(6, 91);
            this.labelMno.Name = "labelMno";
            this.labelMno.Size = new System.Drawing.Size(105, 17);
            this.labelMno.TabIndex = 4;
            this.labelMno.Text = "Mobile Number";
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(131, 28);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(228, 25);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxage
            // 
            this.textBoxage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxage.Location = new System.Drawing.Point(131, 56);
            this.textBoxage.MaxLength = 2;
            this.textBoxage.Name = "textBoxage";
            this.textBoxage.Size = new System.Drawing.Size(228, 25);
            this.textBoxage.TabIndex = 3;
            this.textBoxage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxage_KeyPress);
            // 
            // textBoxMno
            // 
            this.textBoxMno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMno.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMno.Location = new System.Drawing.Point(131, 84);
            this.textBoxMno.MaxLength = 9;
            this.textBoxMno.Name = "textBoxMno";
            this.textBoxMno.Size = new System.Drawing.Size(228, 25);
            this.textBoxMno.TabIndex = 5;
            this.textBoxMno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMno_KeyPress);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(299, 111);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(60, 35);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBoxRegistrationForm
            // 
            this.groupBoxRegistrationForm.Controls.Add(this.buttonSave);
            this.groupBoxRegistrationForm.Controls.Add(this.labelName);
            this.groupBoxRegistrationForm.Controls.Add(this.buttonReset);
            this.groupBoxRegistrationForm.Controls.Add(this.labelAge);
            this.groupBoxRegistrationForm.Controls.Add(this.textBoxMno);
            this.groupBoxRegistrationForm.Controls.Add(this.labelMno);
            this.groupBoxRegistrationForm.Controls.Add(this.textBoxage);
            this.groupBoxRegistrationForm.Controls.Add(this.textBoxName);
            this.groupBoxRegistrationForm.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRegistrationForm.Location = new System.Drawing.Point(10, 13);
            this.groupBoxRegistrationForm.Name = "groupBoxRegistrationForm";
            this.groupBoxRegistrationForm.Size = new System.Drawing.Size(365, 168);
            this.groupBoxRegistrationForm.TabIndex = 7;
            this.groupBoxRegistrationForm.TabStop = false;
            this.groupBoxRegistrationForm.Text = "Registration Form";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(235, 111);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(62, 35);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 194);
            this.Controls.Add(this.groupBoxRegistrationForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.groupBoxRegistrationForm.ResumeLayout(false);
            this.groupBoxRegistrationForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelMno;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxage;
        private System.Windows.Forms.TextBox textBoxMno;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.GroupBox groupBoxRegistrationForm;
        private System.Windows.Forms.Button buttonSave;
    }
}

