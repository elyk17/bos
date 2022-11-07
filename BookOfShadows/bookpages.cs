using System.Data.SqlClient;

namespace BookOfShadows
{
    public partial class insideBook : Form
    {
        public insideBook()
        {
            InitializeComponent();
            Form1 form = new Form1();
            form.Close();
         
        }

        private void bookpages_Load(object sender, EventArgs e)
        {
            Form1 book = new Form1();
            book.Close();
            CreateConnection();
            string cmd = "Select id,title from [dbo].[page] ";
            SqlCommand command = new SqlCommand(cmd, con);
            try
            {
                con.Open(); 
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string results = reader.GetValue(1).ToString();
                    richTextBox1.Text = results;
                }
                con.Close();
              


            }
            catch (SqlException se)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        private void Link_Clicked(object sender, System.Windows.Forms.LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(richTextBox1.Text);
        }

        private void title_Click(object sender, EventArgs e)
        {

        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            reset_password reset = new reset_password();
            reset.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputTitle.Clear();
            textBody.Clear();

        }
        private SqlConnection con;
        private void CreateConnection()
        {
            string ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=BOS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con = new SqlConnection(ConnStr);
        }
        public void getReader()
        {
            CreateConnection();
            string cmd = "INSERT INTO [dbo].[page] (title, book_page) Values (@header, @insert_page)";
            SqlCommand command = new SqlCommand(cmd, con);
            command.Parameters.AddWithValue("@header", inputTitle.Text);
            command.Parameters.AddWithValue("@insert_page", textBody.Text);
            try
            {
                con.Open();
                int result = command.ExecuteNonQuery();
                if (result < 0)
                    MessageBox.Show("Error inserting data into Database!");
                else
                {
                    MessageBox.Show("Page Saved");
                }


            }
            catch (SqlException se)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                con.Close();
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            getReader();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            CreateConnection();
            string cmd = "SELECT title, book_page FROM [dbo].[page] WHERE title = '" + titleTextBox + "'";
            SqlCommand command = new SqlCommand(cmd, con);
            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string results = reader.GetValue(1).ToString();
                    inputTitle.Text = results;
                    string page = reader.GetValue(2).ToString();
                    textBody.Text = page;
                }
                con.Close();



            }
            catch (SqlException se)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
           
        }
    }
}
