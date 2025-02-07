using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMART_final
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            this.Hide();

            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void LogIn_Button_Click(object sender, EventArgs e)
        {
            string email = Email_textBox.Text;
            string password = Password_textBox.Text;

            string connString = @"Server=VULCAN\SQLEXPRESS;Database=kmart_IMS;Trusted_Connection=True;TrustServerCertificate=True;";


            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Staff WHERE Email = @Email AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int userCount = (int)cmd.ExecuteScalar(); 

                        if (userCount > 0)
                        {
                            this.Hide();
                            Dashboard dashboard = new Dashboard();
                            dashboard.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void SignUp_Button_Click(object sender, EventArgs e)
        {
            this.Hide();

            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void WorkingPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
