namespace KMART_final
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            LogIn form2 = new LogIn();
            form2.Show();
        }
    }
}
