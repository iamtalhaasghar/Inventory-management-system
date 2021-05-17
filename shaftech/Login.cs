using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TinaliAutoLight
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void registerHereLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }

        private void loginButtonClicked(object sender, EventArgs e)
        {
            try
            {

                String username = tfUsername.Text.Trim();
                String password = Secret.MD5Hash(tfPassword.Text.Trim());

                SQLiteConnection conn = new SQLiteConnection(DbConfig.CONNECTION_STRING);
                conn.Open();
                string query = "select usertype from users where username='" + username + "'and password='" + password + "'";
                
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    String userType = reader.GetString(0);
                    Console.WriteLine(userType);
                    conn.Close();

                    userdetail userdetail = new userdetail();
                    userdetail.setUname(username);

                    if (userType.Equals("member"))
                    {
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                    }
                    else if (userType.Equals("manager"))
                    {
                        Manager_home manager = new Manager_home();
                        manager.Show();
                        this.Hide();
                    }
                    else if (userType.Equals("admin"))
                    {
                        Admin_home admin = new Admin_home();
                        admin.Show();
                        this.Hide();
                         
                    }
                }   
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
               
        }

        

        private void closeButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
