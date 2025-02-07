namespace KMART_final
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            Base_Panel = new Panel();
            WorkingPanel = new Panel();
            BodyBox = new TextBox();
            label1 = new Label();
            Header_panel = new Panel();
            Page_header = new Label();
            login_button = new Button();
            Logo_label = new Label();
            Base_Panel.SuspendLayout();
            WorkingPanel.SuspendLayout();
            Header_panel.SuspendLayout();
            SuspendLayout();
            // 
            // Base_Panel
            // 
            Base_Panel.BackColor = SystemColors.ControlDarkDark;
            Base_Panel.Controls.Add(WorkingPanel);
            Base_Panel.Controls.Add(Header_panel);
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
            WorkingPanel.Controls.Add(BodyBox);
            WorkingPanel.Controls.Add(label1);
            WorkingPanel.Location = new Point(139, 144);
            WorkingPanel.Name = "WorkingPanel";
            WorkingPanel.Size = new Size(723, 352);
            WorkingPanel.TabIndex = 1;
            // 
            // BodyBox
            // 
            BodyBox.Location = new Point(33, 83);
            BodyBox.Multiline = true;
            BodyBox.Name = "BodyBox";
            BodyBox.Size = new Size(662, 239);
            BodyBox.TabIndex = 5;
            BodyBox.Text = resources.GetString("BodyBox.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(33, 16);
            label1.MaximumSize = new Size(1000, 600);
            label1.Name = "label1";
            label1.Size = new Size(162, 35);
            label1.TabIndex = 4;
            label1.Text = "Introduction";
            label1.Click += label1_Click;
            // 
            // Header_panel
            // 
            Header_panel.BackColor = SystemColors.ActiveCaptionText;
            Header_panel.Controls.Add(Page_header);
            Header_panel.Controls.Add(login_button);
            Header_panel.Controls.Add(Logo_label);
            Header_panel.Dock = DockStyle.Top;
            Header_panel.Location = new Point(0, 0);
            Header_panel.Name = "Header_panel";
            Header_panel.Size = new Size(982, 85);
            Header_panel.TabIndex = 0;
            // 
            // Page_header
            // 
            Page_header.AutoSize = true;
            Page_header.BackColor = SystemColors.ActiveCaptionText;
            Page_header.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Page_header.ForeColor = SystemColors.ButtonHighlight;
            Page_header.Location = new Point(442, 26);
            Page_header.MaximumSize = new Size(1000, 600);
            Page_header.Name = "Page_header";
            Page_header.Size = new Size(149, 35);
            Page_header.TabIndex = 3;
            Page_header.Text = "Home Page";
            // 
            // login_button
            // 
            login_button.Location = new Point(855, 34);
            login_button.Name = "login_button";
            login_button.Size = new Size(94, 29);
            login_button.TabIndex = 2;
            login_button.Text = "Log In";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // Logo_label
            // 
            Logo_label.AutoSize = true;
            Logo_label.BackColor = SystemColors.ActiveCaptionText;
            Logo_label.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Logo_label.ForeColor = SystemColors.ButtonHighlight;
            Logo_label.Location = new Point(34, 18);
            Logo_label.MaximumSize = new Size(1000, 600);
            Logo_label.Name = "Logo_label";
            Logo_label.Size = new Size(149, 46);
            Logo_label.TabIndex = 1;
            Logo_label.Text = "K MART";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(Base_Panel);
            MaximumSize = new Size(1000, 600);
            MinimumSize = new Size(1000, 600);
            Name = "HomePage";
            Text = "Home Page | K Mart";
            Base_Panel.ResumeLayout(false);
            WorkingPanel.ResumeLayout(false);
            WorkingPanel.PerformLayout();
            Header_panel.ResumeLayout(false);
            Header_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Base_Panel;
        private Panel Header_panel;
        private Button login_button;
        private Label Logo_label;
        private Panel WorkingPanel;
        private Label label1;
        private Label Page_header;
        private TextBox BodyBox;
    }
}
