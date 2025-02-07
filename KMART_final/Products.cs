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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Controlbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            User_Profile user_Profile = new User_Profile();
            user_Profile.Show();
        }

        private void LogOut_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void Controlbutton2_Click(object sender, EventArgs e)
        {
            /*
             * this.Hide();

            Products products = new Products();
            products.Show();
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

        private void C_ID_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductName_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuantityUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            string productName = ProductName_textBox2.Text.Trim();

            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Please enter a Product Name.");
                return;
            }

            string connString = @"Server=VULCAN\SQLEXPRESS;Database=kmart_IMS;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT Product_ID, Product_Name, Price FROM Product WHERE Product_Name = @ProductName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", productName);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        ProductDataGrid.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (ProductDataGrid.SelectedRows.Count > 0)
            {
                ProductDataGrid.Rows.RemoveAt(ProductDataGrid.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Please select an item from the cart to remove.");
            }
        }

        private void Invoice_Button_Click(object sender, EventArgs e)
        {

        }

        private void Logo_Panel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void ProductDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Addto_Cart_Button_Click(object sender, EventArgs e)
        {
            if (ProductDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ProductDataGrid.SelectedRows[0];

                // Get product details from selected row
                string productName = selectedRow.Cells["Product_Name"].Value.ToString();
                decimal price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);
                int quantity = (int)QuantityUpDown1.Value;
                string customerID = C_ID_textBox.Text.Trim();

                if (string.IsNullOrEmpty(customerID))
                {
                    MessageBox.Show("Please enter a Customer ID.");
                    return;
                }

                if (quantity <= 0)
                {
                    MessageBox.Show("Please select a valid quantity.");
                    return;
                }

                // Add selected product details to the ProductDataGrid
                ProductDataGrid.Rows.Add(customerID, productName, price, quantity, price * quantity);
            }
            else
            {
                MessageBox.Show("Please select a product from the search results.");
            }
        }

        private void Base_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
