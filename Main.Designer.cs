namespace C_Storage
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Register_button = new Button();
            Modification_button = new Button();
            Find_button = new Button();
            Close_button = new Button();
            SuspendLayout();
            // 
            // Register_button
            // 
            Register_button.FlatStyle = FlatStyle.Flat;
            Register_button.Location = new Point(489, 215);
            Register_button.Name = "Register_button";
            Register_button.Size = new Size(131, 48);
            Register_button.TabIndex = 1;
            Register_button.Text = "Register";
            Register_button.UseVisualStyleBackColor = true;
            Register_button.Click += button1_Click;
            // 
            // Modification_button
            // 
            Modification_button.FlatStyle = FlatStyle.Flat;
            Modification_button.Location = new Point(40, 217);
            Modification_button.Name = "Modification_button";
            Modification_button.Size = new Size(131, 45);
            Modification_button.TabIndex = 2;
            Modification_button.Text = "Modification";
            Modification_button.UseVisualStyleBackColor = true;
            // 
            // Find_button
            // 
            Find_button.FlatStyle = FlatStyle.Flat;
            Find_button.Location = new Point(238, 215);
            Find_button.Name = "Find_button";
            Find_button.Size = new Size(139, 46);
            Find_button.TabIndex = 3;
            Find_button.Text = "Find";
            Find_button.UseVisualStyleBackColor = true;
            // 
            // Close_button
            // 
            Close_button.Location = new Point(251, 389);
            Close_button.Name = "Close_button";
            Close_button.Size = new Size(75, 23);
            Close_button.TabIndex = 4;
            Close_button.Text = "Close";
            Close_button.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(632, 422);
            Controls.Add(Close_button);
            Controls.Add(Find_button);
            Controls.Add(Modification_button);
            Controls.Add(Register_button);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button Register_button;
        private Button Modification_button;
        private Button Find_button;
        private Button Close_button;
    }
}