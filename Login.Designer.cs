namespace C_Storage
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Username_label = new Label();
            Username_textBox = new TextBox();
            Password_textBox = new TextBox();
            Password_label = new Label();
            Continue_button = new Button();
            Cancel_button = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Username_label
            // 
            Username_label.AutoSize = true;
            Username_label.Location = new Point(19, 282);
            Username_label.Name = "Username_label";
            Username_label.Size = new Size(60, 15);
            Username_label.TabIndex = 0;
            Username_label.Text = "Username";
            // 
            // Username_textBox
            // 
            Username_textBox.BorderStyle = BorderStyle.FixedSingle;
            Username_textBox.Location = new Point(127, 274);
            Username_textBox.Name = "Username_textBox";
            Username_textBox.Size = new Size(180, 23);
            Username_textBox.TabIndex = 1;
            // 
            // Password_textBox
            // 
            Password_textBox.BorderStyle = BorderStyle.FixedSingle;
            Password_textBox.Location = new Point(127, 311);
            Password_textBox.Name = "Password_textBox";
            Password_textBox.PasswordChar = '*';
            Password_textBox.Size = new Size(180, 23);
            Password_textBox.TabIndex = 2;
            Password_textBox.TextChanged += Password_textBox_TextChanged;
            // 
            // Password_label
            // 
            Password_label.AutoSize = true;
            Password_label.Location = new Point(22, 319);
            Password_label.Name = "Password_label";
            Password_label.Size = new Size(57, 15);
            Password_label.TabIndex = 3;
            Password_label.Text = "Password";
            Password_label.Click += label1_Click;
            // 
            // Continue_button
            // 
            Continue_button.Location = new Point(169, 357);
            Continue_button.Name = "Continue_button";
            Continue_button.Size = new Size(75, 23);
            Continue_button.TabIndex = 4;
            Continue_button.Text = "Continue";
            Continue_button.UseVisualStyleBackColor = true;
            Continue_button.Click += Continue_button_Click;
            // 
            // Cancel_button
            // 
            Cancel_button.Location = new Point(169, 386);
            Cancel_button.Name = "Cancel_button";
            Cancel_button.Size = new Size(75, 23);
            Cancel_button.TabIndex = 5;
            Cancel_button.Text = "Cancel";
            Cancel_button.UseVisualStyleBackColor = true;
            Cancel_button.Click += Cancel_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(-24, -72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(461, 340);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(419, 418);
            Controls.Add(pictureBox1);
            Controls.Add(Cancel_button);
            Controls.Add(Continue_button);
            Controls.Add(Password_label);
            Controls.Add(Password_textBox);
            Controls.Add(Username_textBox);
            Controls.Add(Username_label);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username_label;
        private TextBox Username_textBox;
        private TextBox Password_textBox;
        private Label Password_label;
        private Button Continue_button;
        private Button Cancel_button;
        private PictureBox pictureBox1;
    }
}