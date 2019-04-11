using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp9
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void newuserButton_Click(object sender, EventArgs e)    //if user hits create user button the create user screen appears
        {
            this.Hide();
            CreateUser ss = new CreateUser();
            ss.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)   //exit button closes program
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
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
                            if ((reader.GetString(0) == usernameText.Text) && (reader.GetString(1) == passwordText.Text))
                            {
                                this.Hide();    //if username and password exist in database go to main page
                                Main m = new Main();
                                m.Show();
                            }
                            else { MessageBox.Show("Incorrect username or password"); }    //if username or password doesnt exist in database dispaly error message
                        }   //need to fix this, gives error message for every incorrect row it checks
                        connection.Close();
                    }
                }
            }
           
        }
    }

