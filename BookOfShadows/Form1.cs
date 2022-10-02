
using Microsoft.Data.SqlClient;

namespace BookOfShadows
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private SqlConnection con;
        private SqlCommand password;
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

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kylem\OneDrive\Documents\bos\BookOfShadows\bookofshadows.mdf;Integrated Security=True";
                con.Open();

                password = new SqlCommand("Select password from admin", con);
                SqlDataReader da = password.ExecuteReader();
                while(da.Read())
                {
                    if (da.GetValue(0).ToString() == null)
                    {
                        setpassword password = new setpassword();
                        password.ShowDialog();
                    }
                    else if (passwordBox.Text == da.GetValue(0).ToString())
                    {

                    }
                }
               
    
            }
            catch (Exception ex)
            {
                con = null;
                
            }

        }
    }
}