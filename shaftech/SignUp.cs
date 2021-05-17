using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace TinaliAutoLight
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void registerButtonClicked(object sender, EventArgs e)
        {
            String firstName = tfFirstName.Text.Trim();
            String lastName = tfLastName.Text.Trim();
            String username = tfUsername.Text.Trim();
            String password = Secret.MD5Hash(tfPassword.Text.Trim());
            String confirmPassword = Secret.MD5Hash(tfPasswordConfirm.Text.Trim());
            String phone = tfPhone.Text.Trim();

            if (firstName.Length != 0 && lastName.Length != 0 && username.Length != 0 && phone.Length != 0 && password.Length != 0 && confirmPassword.Length != 0)
            {
                if (password.Equals(confirmPassword))
                {
                    try
                    {
                        string query = "insert into `users`(`first`,`last`,`username`,`phone`,`password`) values('" + firstName + "','" + lastName + "','" + username + "','" + phone + "','" + password + "')";
                        SQLiteConnection conn = new SQLiteConnection(DbConfig.CONNECTION_STRING);
                        conn.Open();
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("The user \"" + username + "\" was created successfully!!");
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                    catch (SQLiteException ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields");
            }
                
            
        }


        private void closeButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginHyperlinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
