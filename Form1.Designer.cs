namespace C_Storage
{
    partial class Start_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_Form));
            Login_button1 = new Button();
            Close_button = new Button();
            Signup_button = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Login_button1
            // 
            Login_button1.Location = new Point(71, 311);
            Login_button1.Name = "Login_button1";
            Login_button1.Size = new Size(185, 23);
            Login_button1.TabIndex = 0;
            Login_button1.Text = "Login";
            Login_button1.UseVisualStyleBackColor = true;
            Login_button1.Click += Login_button1_Click;
            // 
            // Close_button
            // 
            Close_button.Location = new Point(71, 369);
            Close_button.Name = "Close_button";
            Close_button.Size = new Size(185, 23);
            Close_button.TabIndex = 1;
            Close_button.Text = "Close";
            Close_button.UseVisualStyleBackColor = true;
            Close_button.Click += Close_button_Click;
            // 
            // Signup_button
            // 
            Signup_button.Location = new Point(71, 340);
            Signup_button.Name = "Signup_button";
            Signup_button.Size = new Size(185, 23);
            Signup_button.TabIndex = 2;
            Signup_button.Text = "Sign up";
            Signup_button.UseVisualStyleBackColor = true;
            Signup_button.Click += Signup_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(71, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 183);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Start_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(342, 416);
            Controls.Add(pictureBox1);
            Controls.Add(Signup_button);
            Controls.Add(Close_button);
            Controls.Add(Login_button1);
            Name = "Start_Form";
            Text = "Start";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Login_button1;
        private Button Close_button;
        private Button Signup_button;
        private PictureBox pictureBox1;
    }
}
