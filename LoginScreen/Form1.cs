namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;

            MessageBox.Show($"Username: {username}\nPassword: {password}", "Login Info");
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            string username = Username.Text;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string password = Password.Text;
        }
    }
}
