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
    public partial class Inventory : Form
    {
        public Inventory()
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
            this.Hide();

            Products products = new Products();
            products.Show();
        }

        private void Controlbutton3_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();

            Inventory inventory = new Inventory();
            inventory.Show();
            */
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

        private void Name_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quantity_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Price_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void StockDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            string productName = Name_textBox.Text.Trim();
            string newQuantity = Quantity_textBox.Text.Trim();
            string newPrice = Price_textBox2.Text.Trim();


            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Please enter a Product Name.");
                return;
            }
            if (string.IsNullOrEmpty(newQuantity) && string.IsNullOrEmpty(newPrice))
            {
                MessageBox.Show("Please enter a new Quantity or Price to update.");
                return;
            }


            string connString = @"Server=VULCAN\SQLEXPRESS;Database=kmart_IMS;Trusted_Connection=True;TrustServerCertificate=True;";


            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string updateQuery = "UPDATE Product SET ";
                    if (!string.IsNullOrEmpty(newQuantity)) updateQuery += "Inventory_Quantity = @Quantity, ";
                    if (!string.IsNullOrEmpty(newPrice)) updateQuery += "Price = @Price, ";
                    updateQuery = updateQuery.TrimEnd(',', ' ') + " WHERE Product_Name = @ProductName";


                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {

                        if (!string.IsNullOrEmpty(newQuantity)) cmd.Parameters.AddWithValue("@Quantity", newQuantity);
                        if (!string.IsNullOrEmpty(newPrice)) cmd.Parameters.AddWithValue("@Price", newPrice);
                        cmd.Parameters.AddWithValue("@ProductName", productName);


                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product details updated successfully!");
                            View_Button_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Error: Product not found or unable to update.");
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void View_Button_Click(object sender, EventArgs e)
        {
            string productName = Name_textBox.Text.Trim();

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

                    string query = "SELECT Product_ID, Product_Name, Order_Quantity, Inventory_Quantity, Price FROM Product WHERE Product_Name = @ProductName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", productName);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        StockDataGrid.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Logo_Panel_Click(object sender, EventArgs e)
        {

            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
