namespace BookOfShadows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passwordLabel.Visible = true;
            passwordBox.Visible = true;
            openButton.Visible = false;
            enterButton.Visible = true;    

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }
    }
}