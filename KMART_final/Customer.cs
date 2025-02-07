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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Controlbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            User_Profile user_Profile = new User_Profile();
            user_Profile.Show();
        }

        private void Controlbutton2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Products products = new Products();
            products.Show();
        }

        private void Controlbutton3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Inventory inventory = new Inventory();
            inventory.Show();
        }

        private void Controlbutton4_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();

            Customer customer = new Customer();
            customer.Show();
            */
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

        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            string customerId = Search_textBox.Text;

            if (string.IsNullOrEmpty(customerId))
            {
                MessageBox.Show("Please enter a Customer ID.");
                return;
            }

            // Define the connection string
            string connString = @"Server=VULCAN\SQLEXPRESS;Database=kmart_IMS;Trusted_Connection=True;TrustServerCertificate=True;";

            // Create SQL connection
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // Query to fetch customer details by Customer_ID
                    string query = "SELECT Customer_ID, Name, Email, Phone, Address FROM Customer WHERE Customer_ID = @CustomerID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add the Customer_ID parameter
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);

                        // Execute the query and fill the DataGridView with the results
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Check if any data is returned
                        if (dataTable.Rows.Count > 0)
                        {
                            // Set the DataGridView's data source to the result set
                            CustomerDataGrid.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("No customer found with the provided ID.");
                            CustomerDataGrid.DataSource = null; // Clear DataGridView if no result
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

        private void CustomerDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
