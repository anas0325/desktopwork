using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DesktopCrud
{
    public partial class Form1 : Form
    {
        SqlConnection connectiondb = new SqlConnection("Data Source=.;Initial Catalog=crud;User ID=sa;Password=aptech");
        public Form1()
        {
            InitializeComponent();
            try
            {

                connectiondb.Open();

               
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

            login lonin = new login();
            lonin.Show();


            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
        }

        private void useremail_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void userpassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user_Enter_Name =username.Text;
            string user_Enter_Email = useremail.Text;
            string user_Enter_Password = userpassword.Text;

            
           
                string insertQuery = "insert into aptechregistration values('"+user_Enter_Name+"','" +user_Enter_Email+"','"+user_Enter_Password+"') ";


                SqlCommand dlveryboy = new SqlCommand(insertQuery, connectiondb);

                dlveryboy.ExecuteNonQuery();
                  
                MessageBox.Show("Data Insert Sucessdully");

            username.Text = "";
            useremail.Text = "";
            userpassword.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }
    }
}