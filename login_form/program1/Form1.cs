namespace program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string username=textBox1.Text;
            string password=textBox2.Text;
            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Login successful!");
                home f2 = new home();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
