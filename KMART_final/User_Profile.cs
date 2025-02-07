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
    public partial class User_Profile : Form
    {
        public User_Profile()
        {
            InitializeComponent();
        }

        private void Controlbutton2_Click(object sender, EventArgs e)
        {

            this.Hide();

            Products products = new Products();
            products.Show();

        }

        private void Controlbutton1_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();

            User_Profile user_Profile = new User_Profile();
            user_Profile.Show();
            */
        }

        private void Controlbutton3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Inventory inventory = new Inventory();
            inventory.Show();
        }

        private void Controlbutton4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Customer customer = new Customer();
            customer.Show();
        }

        private void Controlbutton5_Click(object sender, EventArgs e)
        {
            this.Hide();

            Invoice invoice = new Invoice();
            invoice.Show();
        }

        private void LogOut_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            string newName = Name_textBox.Text;
            string newPhone = Phone_textBox.Text;

            // Validate the inputs
            if (string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newPhone))
            {
                MessageBox.Show("Please fill in both fields.");
                return;
            }

            int staffId = 0;
            if (int.TryParse(ID_textBox.Text, out staffId)) // Get the Staff_ID from the ID_textBox
            {
                // Define the connection string
                string connString = @"Server=VULCAN\SQLEXPRESS;Database=kmart_IMS;Trusted_Connection=True;TrustServerCertificate=True;";

                // Create SQL connection
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();

                        // SQL Query to update the staff's Name and Phone Number
                        string updateQuery = "UPDATE Staff SET Name = @Name, Phone = @Phone WHERE Staff_ID = @StaffID";

                        // Create and configure the SQL command
                        using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                        {
                            // Add parameters to avoid SQL injection
                            cmd.Parameters.AddWithValue("@Name", newName);
                            cmd.Parameters.AddWithValue("@Phone", newPhone);
                            cmd.Parameters.AddWithValue("@StaffID", staffId); // Get the Staff_ID from the ID_textBox

                            // Execute the update query
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Details updated successfully!");
                                // Refresh the staff data in the grid to show updated information
                                button1_Click(sender, e);  // Re-run the button1 click to refresh UserDataGrid
                            }
                            else
                            {
                                MessageBox.Show("Error: Staff not found or unable to update.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors during the database operation
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Staff ID.");
            }

        }

        private void Name_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phone_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//ViewButton
        {
            int staffId = 0;
            if (int.TryParse(ID_textBox.Text, out staffId)) // Get the Staff_ID from the ID_textBox
            {
                // Define the connection string
                string connString = @"Server=VULCAN\SQLEXPRESS;Database=kmart_IMS;Trusted_Connection=True;TrustServerCertificate=True;";

                // Create SQL connection
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();

                        // Query to fetch the full user data by Staff_ID
                        string query = "SELECT Staff_ID, Name, Email, Phone FROM Staff WHERE Staff_ID = @StaffID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Add the Staff_ID parameter
                            cmd.Parameters.AddWithValue("@StaffID", staffId);

                            // Execute the query and fill the DataGridView with the results
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Set the DataGridView's data source to the result set
                            UserDataGrid.DataSource = dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors during the database operation
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Staff ID.");
            }
        }

        private void ID_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Logo_Panel_Click(object sender, EventArgs e)
        {
            this.Hide();

            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
