namespace KMART_final
{
    partial class User_Profile
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
            Working_Panel = new Panel();
            ID_textBox = new TextBox();
            View_Button = new Button();
            Phone_textBox = new TextBox();
            label1 = new Label();
            Name_textBox = new TextBox();
            Update_Button = new Button();
            UserDataGrid = new DataGridView();
            Nav_panel = new Panel();
            Controlbutton4 = new Button();
            Controlbutton3 = new Button();
            Controlbutton2 = new Button();
            Controlbutton1 = new Button();
            Header_Panel = new Panel();
            LogOut_button = new Button();
            Logo_Panel = new Label();
            Page_Label = new Label();
            Base_Panel.SuspendLayout();
            Working_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserDataGrid).BeginInit();
            Nav_panel.SuspendLayout();
            Header_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // Base_Panel
            // 
            Base_Panel.BackColor = SystemColors.ControlDarkDark;
            Base_Panel.Controls.Add(Working_Panel);
            Base_Panel.Controls.Add(Nav_panel);
            Base_Panel.Controls.Add(Header_Panel);
            Base_Panel.Dock = DockStyle.Fill;
            Base_Panel.Location = new Point(0, 0);
            Base_Panel.Name = "Base_Panel";
            Base_Panel.Size = new Size(982, 553);
            Base_Panel.TabIndex = 1;
            // 
            // Working_Panel
            // 
            Working_Panel.BackColor = SystemColors.AppWorkspace;
            Working_Panel.Controls.Add(ID_textBox);
            Working_Panel.Controls.Add(View_Button);
            Working_Panel.Controls.Add(Phone_textBox);
            Working_Panel.Controls.Add(label1);
            Working_Panel.Controls.Add(Name_textBox);
            Working_Panel.Controls.Add(Update_Button);
            Working_Panel.Controls.Add(UserDataGrid);
            Working_Panel.Location = new Point(209, 130);
            Working_Panel.Name = "Working_Panel";
            Working_Panel.Size = new Size(736, 380);
            Working_Panel.TabIndex = 3;
            // 
            // ID_textBox
            // 
            ID_textBox.Location = new Point(238, 60);
            ID_textBox.Name = "ID_textBox";
            ID_textBox.PlaceholderText = "Enter ID";
            ID_textBox.Size = new Size(206, 27);
            ID_textBox.TabIndex = 6;
            ID_textBox.TextChanged += ID_textBox_TextChanged;
            // 
            // View_Button
            // 
            View_Button.Location = new Point(351, 200);
            View_Button.Name = "View_Button";
            View_Button.Size = new Size(94, 29);
            View_Button.TabIndex = 5;
            View_Button.Text = "View";
            View_Button.UseVisualStyleBackColor = true;
            View_Button.Click += button1_Click;
            // 
            // Phone_textBox
            // 
            Phone_textBox.Location = new Point(239, 154);
            Phone_textBox.Name = "Phone_textBox";
            Phone_textBox.PlaceholderText = "Enter Phone Number";
            Phone_textBox.Size = new Size(206, 27);
            Phone_textBox.TabIndex = 4;
            Phone_textBox.TextChanged += Phone_textBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(275, 15);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 3;
            label1.Text = "User Details";
            label1.Click += label1_Click;
            // 
            // Name_textBox
            // 
            Name_textBox.Location = new Point(239, 107);
            Name_textBox.Name = "Name_textBox";
            Name_textBox.PlaceholderText = "Enter Name";
            Name_textBox.Size = new Size(206, 27);
            Name_textBox.TabIndex = 2;
            Name_textBox.TextChanged += Name_textBox_TextChanged;
            // 
            // Update_Button
            // 
            Update_Button.Location = new Point(238, 200);
            Update_Button.Name = "Update_Button";
            Update_Button.Size = new Size(94, 29);
            Update_Button.TabIndex = 1;
            Update_Button.Text = "Update";
            Update_Button.UseVisualStyleBackColor = true;
            Update_Button.Click += Update_Button_Click;
            // 
            // UserDataGrid
            // 
            UserDataGrid.BackgroundColor = SystemColors.ControlLight;
            UserDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDataGrid.Location = new Point(31, 242);
            UserDataGrid.Name = "UserDataGrid";
            UserDataGrid.RowHeadersWidth = 51;
            UserDataGrid.Size = new Size(678, 104);
            UserDataGrid.TabIndex = 0;
            UserDataGrid.CellContentClick += UserDataGrid_CellContentClick;
            // 
            // Nav_panel
            // 
            Nav_panel.BackColor = SystemColors.ButtonShadow;
            Nav_panel.BorderStyle = BorderStyle.Fixed3D;
            Nav_panel.Controls.Add(Controlbutton4);
            Nav_panel.Controls.Add(Controlbutton3);
            Nav_panel.Controls.Add(Controlbutton2);
            Nav_panel.Controls.Add(Controlbutton1);
            Nav_panel.Dock = DockStyle.Left;
            Nav_panel.Location = new Point(0, 81);
            Nav_panel.MaximumSize = new Size(180, 472);
            Nav_panel.MinimumSize = new Size(180, 472);
            Nav_panel.Name = "Nav_panel";
            Nav_panel.Size = new Size(180, 472);
            Nav_panel.TabIndex = 1;
            // 
            // Controlbutton4
            // 
            Controlbutton4.Dock = DockStyle.Top;
            Controlbutton4.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            Controlbutton4.Location = new Point(0, 141);
            Controlbutton4.Name = "Controlbutton4";
            Controlbutton4.Size = new Size(176, 47);
            Controlbutton4.TabIndex = 3;
            Controlbutton4.Text = "Customer";
            Controlbutton4.UseVisualStyleBackColor = true;
            Controlbutton4.Click += Controlbutton4_Click;
            // 
            // Controlbutton3
            // 
            Controlbutton3.Dock = DockStyle.Top;
            Controlbutton3.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            Controlbutton3.Location = new Point(0, 94);
            Controlbutton3.Name = "Controlbutton3";
            Controlbutton3.Size = new Size(176, 47);
            Controlbutton3.TabIndex = 2;
            Controlbutton3.Text = "Inventory";
            Controlbutton3.UseVisualStyleBackColor = true;
            Controlbutton3.Click += Controlbutton3_Click;
            // 
            // Controlbutton2
            // 
            Controlbutton2.Dock = DockStyle.Top;
            Controlbutton2.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            Controlbutton2.Location = new Point(0, 47);
            Controlbutton2.Name = "Controlbutton2";
            Controlbutton2.Size = new Size(176, 47);
            Controlbutton2.TabIndex = 1;
            Controlbutton2.Text = "Products";
            Controlbutton2.UseVisualStyleBackColor = true;
            Controlbutton2.Click += Controlbutton2_Click;
            // 
            // Controlbutton1
            // 
            Controlbutton1.BackColor = SystemColors.ControlDark;
            Controlbutton1.Dock = DockStyle.Top;
            Controlbutton1.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            Controlbutton1.Location = new Point(0, 0);
            Controlbutton1.Name = "Controlbutton1";
            Controlbutton1.Size = new Size(176, 47);
            Controlbutton1.TabIndex = 0;
            Controlbutton1.Text = "Profile";
            Controlbutton1.UseVisualStyleBackColor = false;
            Controlbutton1.Click += Controlbutton1_Click;
            // 
            // Header_Panel
            // 
            Header_Panel.BackColor = SystemColors.ActiveCaptionText;
            Header_Panel.Controls.Add(LogOut_button);
            Header_Panel.Controls.Add(Logo_Panel);
            Header_Panel.Controls.Add(Page_Label);
            Header_Panel.Dock = DockStyle.Top;
            Header_Panel.Location = new Point(0, 0);
            Header_Panel.Name = "Header_Panel";
            Header_Panel.Size = new Size(982, 81);
            Header_Panel.TabIndex = 0;
            // 
            // LogOut_button
            // 
            LogOut_button.Location = new Point(866, 31);
            LogOut_button.Name = "LogOut_button";
            LogOut_button.Size = new Size(94, 29);
            LogOut_button.TabIndex = 7;
            LogOut_button.Text = "Log Out";
            LogOut_button.UseVisualStyleBackColor = true;
            LogOut_button.Click += LogOut_button_Click;
            // 
            // Logo_Panel
            // 
            Logo_Panel.AutoSize = true;
            Logo_Panel.BackColor = SystemColors.ActiveCaptionText;
            Logo_Panel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Logo_Panel.ForeColor = SystemColors.ButtonFace;
            Logo_Panel.Location = new Point(12, 18);
            Logo_Panel.MaximumSize = new Size(1000, 600);
            Logo_Panel.Name = "Logo_Panel";
            Logo_Panel.Size = new Size(149, 46);
            Logo_Panel.TabIndex = 6;
            Logo_Panel.Text = "K MART";
            Logo_Panel.Click += Logo_Panel_Click;
            // 
            // Page_Label
            // 
            Page_Label.AutoSize = true;
            Page_Label.BackColor = SystemColors.ActiveCaptionText;
            Page_Label.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Page_Label.ForeColor = SystemColors.ButtonHighlight;
            Page_Label.Location = new Point(459, 27);
            Page_Label.MaximumSize = new Size(1000, 600);
            Page_Label.Name = "Page_Label";
            Page_Label.Size = new Size(93, 35);
            Page_Label.TabIndex = 5;
            Page_Label.Text = "Profile";
            // 
            // User_Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(Base_Panel);
            MaximumSize = new Size(1000, 600);
            MinimumSize = new Size(1000, 600);
            Name = "User_Profile";
            Text = "User_Profile";
            Base_Panel.ResumeLayout(false);
            Working_Panel.ResumeLayout(false);
            Working_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserDataGrid).EndInit();
            Nav_panel.ResumeLayout(false);
            Header_Panel.ResumeLayout(false);
            Header_Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Base_Panel;
        private Panel Nav_panel;
        private Button Controlbutton4;
        private Button Controlbutton3;
        private Button Controlbutton2;
        private Button Controlbutton1;
        private Panel Header_Panel;
        private Button LogOut_button;
        private Label Logo_Panel;
        private Label Page_Label;
        private Panel Working_Panel;
        private Label label1;
        private TextBox Name_textBox;
        private Button Update_Button;
        private DataGridView UserDataGrid;
        private TextBox Phone_textBox;
        private Button View_Button;
        private TextBox ID_textBox;
    }
}