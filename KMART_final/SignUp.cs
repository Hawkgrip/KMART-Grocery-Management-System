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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Button_Click(object sender, EventArgs e)
        {
           
            string name = Name_textBox.Text;
            string email = Email_textBox.Text;
            string password = Password_textBox.Text;
            string phone = Phone_textBox.Text;

            
            string connString = @"Server=VULCAN\SQLEXPRESS;Database=kmart_IMS;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                   
                    string checkEmailQuery = "SELECT COUNT(*) FROM Staff WHERE Email = @Email";

                    using (SqlCommand cmdCheck = new SqlCommand(checkEmailQuery, conn))
                    {
                       
                        cmdCheck.Parameters.AddWithValue("@Email", email);

                        
                        int emailExists = (int)cmdCheck.ExecuteScalar();

                        if (emailExists > 0)
                        {
                           
                            MessageBox.Show("The email address is already registered.");
                        }
                        else
                        {
                            string insertQuery = "INSERT INTO Staff (Name, Email, Password, Phone) VALUES (@Name, @Email, @Password, @Phone)";

                            using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                            {
                                
                                cmdInsert.Parameters.AddWithValue("@Name", name);
                                cmdInsert.Parameters.AddWithValue("@Email", email);
                                cmdInsert.Parameters.AddWithValue("@Password", password);
                                cmdInsert.Parameters.AddWithValue("@Phone", phone);

                               
                                cmdInsert.ExecuteNonQuery();

                              
                                MessageBox.Show("Sign-up successful! You can now log in.");

                               
                                this.Hide();
                                LogIn logIn = new LogIn();
                                logIn.Show();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LogIn_Button_Click(object sender, EventArgs e)
        {
            this.Hide();

            LogIn logIn = new LogIn();
            logIn.Show();
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            this.Hide();

           HomePage homePage = new HomePage();
           homePage.Show();
        }
    }
}
