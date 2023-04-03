namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "INDIA", "USA" });
            comboBox1.Location = new Point(361, 67);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(158, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 75);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 1;
            label1.Text = "Select Country";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Nagpur", "Amravati", "Ballarshah", "san fransisco", "Los Angeles", "America" });
            comboBox2.Location = new Point(364, 119);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(160, 28);
            comboBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 121);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 3;
            label2.Text = "Select City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 369);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "JAVA ", "DOTNET", "JAVA PREMIUM" });
            listBox1.Location = new Point(369, 171);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(155, 104);
            listBox1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2023_03_12_at_21_46_17;
            pictureBox1.Location = new Point(576, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(355, 307);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(183, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(370, 422);
            button1.Name = "button1";
            button1.Size = new Size(135, 41);
            button1.TabIndex = 8;
            button1.Text = "sumbit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(378, 356);
            maskedTextBox1.Mask = "0000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(153, 27);
            maskedTextBox1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 605);
            Controls.Add(maskedTextBox1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private MaskedTextBox maskedTextBox1;
    }
}