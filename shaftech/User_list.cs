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
    public partial class User_list : Form
    {
        public User_list()
        {
            InitializeComponent();
        }

        //fill grid view method
        void Filluserlist()
        {
            /*
            SqliteConnection conn = new SqliteConnection(DbConfig.CONNECTION_STRING);
            SqliteCommand list = new SqliteCommand("select first,last,username,phone,usertype from users ", conn);
            DataTable dtlist = new DataTable();
            conn.Open();
            dtlist.Load(list.ExecuteReader());
            users_list.DataSource = dtlist;
            */
        }

        private void User_list_Load(object sender, EventArgs e)
        {
            Filluserlist();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Admin_home admin = new Admin_home();
            admin.Show();
            this.Close();
        }
    }
}
