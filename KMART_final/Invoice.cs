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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void Controlbutton5_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();

            Invoice invoice = new Invoice();
            invoice.Show();
            */
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
            this.Hide();

            Customer customer = new Customer();
            customer.Show();
        }

        private void LogOut_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void Logo_Panel_Click(object sender, EventArgs e)
        {

            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
