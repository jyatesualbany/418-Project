using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameText.Text) || string.IsNullOrWhiteSpace(passwordText.Text))   //if username or password is left blank show error message
            {
                MessageBox.Show("Please enter username and password");
            }
            else {

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                /*
                builder.DataSource = "<server>.database.windows.net";
                builder.UserID = "<username>";
                builder.Password = "<password>";
                builder.InitialCatalog = "<database>";
                */
                builder.DataSource = "testtaker.database.windows.net";
                builder.UserID = "williamtdickinson";
                builder.Password = "Ez5zgzwdw";
                builder.InitialCatalog = "TestTaker";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * FROM dbo.Users;");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                               if ((reader.GetString(0) == usernameText.Text)){
                                    MessageBox.Show("User already exists");
                                    break;
                                }
                        }
                        MessageBox.Show("User created");

                        this.Hide();    //takes user back to login screen 
                        Login l = new Login();
                        l.Show();

                    }
                }              
            }
        }

       
    }
}
