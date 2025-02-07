namespace KMART_final
{
    partial class SignUp
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
            Base_Panel = new Panel();
            WorkingPanel = new Panel();
            Phone_textBox = new TextBox();
            Phone_Label = new Label();
            Name_Label = new Label();
            Name_textBox = new TextBox();
            SignUp_Button = new Button();
            LogIn_Button = new Button();
            Password_textBox = new TextBox();
            Email_textBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Header_Panel = new Panel();
            Home_Button = new Button();
            Page_Label = new Label();
            Logo_label = new Label();
            Base_Panel.SuspendLayout();
            WorkingPanel.SuspendLayout();
            Header_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // Base_Panel
            // 
            Base_Panel.BackColor = SystemColors.ControlDarkDark;
            Base_Panel.Controls.Add(WorkingPanel);
            Base_Panel.Controls.Add(Header_Panel);
            Base_Panel.Dock = DockStyle.Fill;
            Base_Panel.Location = new Point(0, 0);
            Base_Panel.Name = "Base_Panel";
            Base_Panel.Size = new Size(982, 553);
            Base_Panel.TabIndex = 0;
            // 
            // WorkingPanel
            // 
            WorkingPanel.BackColor = SystemColors.ActiveBorder;
            WorkingPanel.BorderStyle = BorderStyle.Fixed3D;
            WorkingPanel.Controls.Add(Phone_textBox);
            WorkingPanel.Controls.Add(Phone_Label);
            WorkingPanel.Controls.Add(Name_Label);
            WorkingPanel.Controls.Add(Name_textBox);
            WorkingPanel.Controls.Add(SignUp_Button);
            WorkingPanel.Controls.Add(LogIn_Button);
            WorkingPanel.Controls.Add(Password_textBox);
            WorkingPanel.Controls.Add(Email_textBox);
            WorkingPanel.Controls.Add(label4);
            WorkingPanel.Controls.Add(label3);
            WorkingPanel.Controls.Add(label2);
            WorkingPanel.Controls.Add(label1);
            WorkingPanel.Location = new Point(133, 145);
            WorkingPanel.Name = "WorkingPanel";
            WorkingPanel.Size = new Size(723, 352);
            WorkingPanel.TabIndex = 3;
            // 
            // Phone_textBox
            // 
            Phone_textBox.Location = new Point(287, 217);
            Phone_textBox.Name = "Phone_textBox";
            Phone_textBox.PlaceholderText = "Enter Your Phone Number";
            Phone_textBox.Size = new Size(213, 27);
            Phone_textBox.TabIndex = 11;
            // 
            // Phone_Label
            // 
            Phone_Label.AutoSize = true;
            Phone_Label.Font = new Font("Segoe UI", 12F);
            Phone_Label.Location = new Point(183, 213);
            Phone_Label.Name = "Phone_Label";
            Phone_Label.Size = new Size(71, 28);
            Phone_Label.TabIndex = 10;
            Phone_Label.Text = "Phone:";
            // 
            // Name_Label
            // 
            Name_Label.AutoSize = true;
            Name_Label.Font = new Font("Segoe UI", 12F);
            Name_Label.Location = new Point(186, 95);
            Name_Label.Name = "Name_Label";
            Name_Label.Size = new Size(68, 28);
            Name_Label.TabIndex = 9;
            Name_Label.Text = "Name:";
            // 
            // Name_textBox
            // 
            Name_textBox.Location = new Point(287, 95);
            Name_textBox.Name = "Name_textBox";
            Name_textBox.PlaceholderText = "Enter your Name";
            Name_textBox.Size = new Size(213, 27);
            Name_textBox.TabIndex = 8;
            // 
            // SignUp_Button
            // 
            SignUp_Button.Location = new Point(332, 249);
            SignUp_Button.Name = "SignUp_Button";
            SignUp_Button.Size = new Size(107, 29);
            SignUp_Button.TabIndex = 7;
            SignUp_Button.Text = "Sign Up";
            SignUp_Button.UseVisualStyleBackColor = true;
            SignUp_Button.Click += SignUp_Button_Click;
            // 
            // LogIn_Button
            // 
            LogIn_Button.Location = new Point(406, 284);
            LogIn_Button.Name = "LogIn_Button";
            LogIn_Button.Size = new Size(94, 29);
            LogIn_Button.TabIndex = 6;
            LogIn_Button.Text = "Log In";
            LogIn_Button.UseVisualStyleBackColor = true;
            LogIn_Button.Click += LogIn_Button_Click;
            // 
            // Password_textBox
            // 
            Password_textBox.Location = new Point(287, 176);
            Password_textBox.Name = "Password_textBox";
            Password_textBox.PlaceholderText = "Enter Your Password";
            Password_textBox.Size = new Size(213, 27);
            Password_textBox.TabIndex = 5;
            // 
            // Email_textBox
            // 
            Email_textBox.Location = new Point(287, 135);
            Email_textBox.Name = "Email_textBox";
            Email_textBox.PlaceholderText = "Enter your Email";
            Email_textBox.Size = new Size(213, 27);
            Email_textBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 288);
            label4.Name = "label4";
            label4.Size = new Size(187, 20);
            label4.TabIndex = 3;
            label4.Text = "Already Have an Account? ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Italic);
            label3.Location = new Point(180, 33);
            label3.Name = "label3";
            label3.Size = new Size(372, 35);
            label3.TabIndex = 2;
            label3.Text = "Enter your Credentials to Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(157, 172);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(191, 135);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // Header_Panel
            // 
            Header_Panel.BackColor = SystemColors.ActiveCaptionText;
            Header_Panel.Controls.Add(Home_Button);
            Header_Panel.Controls.Add(Page_Label);
            Header_Panel.Controls.Add(Logo_label);
            Header_Panel.Dock = DockStyle.Top;
            Header_Panel.Location = new Point(0, 0);
            Header_Panel.Name = "Header_Panel";
            Header_Panel.Size = new Size(982, 87);
            Header_Panel.TabIndex = 0;
            // 
            // Home_Button
            // 
            Home_Button.Location = new Point(857, 36);
            Home_Button.Name = "Home_Button";
            Home_Button.Size = new Size(94, 29);
            Home_Button.TabIndex = 5;
            Home_Button.Text = "Home";
            Home_Button.UseVisualStyleBackColor = true;
            Home_Button.Click += Home_Button_Click;
            // 
            // Page_Label
            // 
            Page_Label.AutoSize = true;
            Page_Label.BackColor = SystemColors.ActiveCaptionText;
            Page_Label.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Page_Label.ForeColor = SystemColors.ButtonHighlight;
            Page_Label.Location = new Point(467, 31);
            Page_Label.MaximumSize = new Size(1000, 600);
            Page_Label.Name = "Page_Label";
            Page_Label.Size = new Size(107, 35);
            Page_Label.TabIndex = 4;
            Page_Label.Text = "Sign Up";
            // 
            // Logo_label
            // 
            Logo_label.AutoSize = true;
            Logo_label.BackColor = SystemColors.ActiveCaptionText;
            Logo_label.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Logo_label.ForeColor = SystemColors.ButtonHighlight;
            Logo_label.Location = new Point(12, 23);
            Logo_label.MaximumSize = new Size(1000, 600);
            Logo_label.Name = "Logo_label";
            Logo_label.Size = new Size(149, 46);
            Logo_label.TabIndex = 3;
            Logo_label.Text = "K MART";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(Base_Panel);
            MaximumSize = new Size(1000, 600);
            MinimumSize = new Size(1000, 600);
            Name = "SignUp";
            Text = "SignUp";
            Base_Panel.ResumeLayout(false);
            WorkingPanel.ResumeLayout(false);
            WorkingPanel.PerformLayout();
            Header_Panel.ResumeLayout(false);
            Header_Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Base_Panel;
        private Panel Header_Panel;
        private Label Logo_label;
        private Button Home_Button;
        private Label Page_Label;
        private Panel WorkingPanel;
        private Label Name_Label;
        private TextBox Name_textBox;
        private Button SignUp_Button;
        private Button LogIn_Button;
        private TextBox Password_textBox;
        private TextBox Email_textBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Phone_textBox;
        private Label Phone_Label;
    }
}