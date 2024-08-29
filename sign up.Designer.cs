namespace C_Storage
{
    partial class sign_up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sign_up));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            Signup_Username_textBox = new TextBox();
            Signup_Password_textBox = new TextBox();
            Signup_Dept_textBox = new TextBox();
            Signup_Empno_textBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            Register_button = new Button();
            Cancel_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(41, 75);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(44, 121);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(41, 276);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "Employee no.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(41, 228);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(41, 171);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 4;
            label5.Text = "Date of birth";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(313, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 298);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Signup_Username_textBox
            // 
            Signup_Username_textBox.BackColor = SystemColors.GradientInactiveCaption;
            Signup_Username_textBox.BorderStyle = BorderStyle.None;
            Signup_Username_textBox.Location = new Point(41, 93);
            Signup_Username_textBox.Name = "Signup_Username_textBox";
            Signup_Username_textBox.Size = new Size(267, 16);
            Signup_Username_textBox.TabIndex = 6;
            // 
            // Signup_Password_textBox
            // 
            Signup_Password_textBox.BackColor = SystemColors.GradientInactiveCaption;
            Signup_Password_textBox.BorderStyle = BorderStyle.None;
            Signup_Password_textBox.Location = new Point(41, 139);
            Signup_Password_textBox.Name = "Signup_Password_textBox";
            Signup_Password_textBox.Size = new Size(267, 16);
            Signup_Password_textBox.TabIndex = 8;
            Signup_Password_textBox.TextChanged += Signup_Password_textBox_TextChanged;
            // 
            // Signup_Dept_textBox
            // 
            Signup_Dept_textBox.BackColor = SystemColors.GradientInactiveCaption;
            Signup_Dept_textBox.BorderStyle = BorderStyle.None;
            Signup_Dept_textBox.Location = new Point(41, 246);
            Signup_Dept_textBox.Name = "Signup_Dept_textBox";
            Signup_Dept_textBox.Size = new Size(267, 16);
            Signup_Dept_textBox.TabIndex = 10;
            // 
            // Signup_Empno_textBox
            // 
            Signup_Empno_textBox.BackColor = SystemColors.GradientInactiveCaption;
            Signup_Empno_textBox.BorderStyle = BorderStyle.None;
            Signup_Empno_textBox.Location = new Point(41, 294);
            Signup_Empno_textBox.Name = "Signup_Empno_textBox";
            Signup_Empno_textBox.Size = new Size(267, 16);
            Signup_Empno_textBox.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.GradientInactiveCaption;
            dateTimePicker1.Location = new Point(41, 189);
            dateTimePicker1.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1930, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(267, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // Register_button
            // 
            Register_button.BackColor = Color.LawnGreen;
            Register_button.Location = new Point(44, 316);
            Register_button.Name = "Register_button";
            Register_button.Size = new Size(119, 23);
            Register_button.TabIndex = 13;
            Register_button.Text = "Register";
            Register_button.UseVisualStyleBackColor = false;
            Register_button.Click += Register_button_Click;
            // 
            // Cancel_button
            // 
            Cancel_button.BackColor = Color.Red;
            Cancel_button.Location = new Point(189, 316);
            Cancel_button.Name = "Cancel_button";
            Cancel_button.Size = new Size(119, 23);
            Cancel_button.TabIndex = 14;
            Cancel_button.Text = "Cancel";
            Cancel_button.UseVisualStyleBackColor = false;
            Cancel_button.Click += Cancel_button_Click;
            // 
            // sign_up
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(597, 365);
            Controls.Add(Cancel_button);
            Controls.Add(Register_button);
            Controls.Add(dateTimePicker1);
            Controls.Add(Signup_Empno_textBox);
            Controls.Add(Signup_Dept_textBox);
            Controls.Add(Signup_Password_textBox);
            Controls.Add(Signup_Username_textBox);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "sign_up";
            Text = "sign_up";
            Load += sign_up_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private TextBox Signup_Username_textBox;
        private TextBox Signup_Password_textBox;
        private TextBox Signup_Dept_textBox;
        private TextBox Signup_Empno_textBox;
        private DateTimePicker dateTimePicker1;
        private Button Register_button;
        private Button Cancel_button;
    }
}