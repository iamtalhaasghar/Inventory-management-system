using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using CsvHelper;

namespace TinaliAutoLight
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
        
            userdetail user = new userdetail();
            lblUsername.Text = user.getUname();
        }
      

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButtonClicked(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void findItemByIdButtonClicked(object sender, EventArgs e)
        {
            searchItem();
        }

        private void searchItem()
        {
            String searchId = tfSearchId.Text.Trim();
            try
            {

                SQLiteConnection conn = new SQLiteConnection(DbConfig.CONNECTION_STRING);
                conn.Open();
                String query = "select * from items where id='" + searchId + "'";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                Console.WriteLine(query);
                

                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tfItemId.Text = reader.GetInt32(0).ToString();
                    tfItemName.Text = reader.GetString(1);
                    tfItemModel.Text = reader.GetString(2);
                    tfItemType.Text = reader.GetString(3);
                    tfItemPrice.Text = reader.GetString(4);
                    tfItemStock.Text = reader.GetString(5);
                }
                else
                {
                    String notFound = "Not Found";
                    tfItemId.Text = notFound;
                    tfItemName.Text = notFound;
                    tfItemModel.Text = notFound;
                    tfItemType.Text = notFound;
                    tfItemPrice.Text = notFound;
                    tfItemStock.Text = notFound;
                }
                
                
                conn.Close();
            }
            catch (Exception x)
            {
                Console.WriteLine(x.ToString());
            }

        }

        private void tfSearchId_TextChanged(object sender, EventArgs e)
        {
            searchItem();
        }

      
        private void exportToPdf(object sender, EventArgs e)
        {
            String[,] data = new String[6, 2] {
                {"ID:", tfItemId.Text},
                {"Name:", tfItemName.Text},
                {"Model:", tfItemModel.Text},
                {"Type:", tfItemType.Text},
                {"Price:", tfItemName.Text},
                {"Stock:", tfItemStock.Text}
            };

            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(data.GetLength(1));
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.NORMAL);
           
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    pdftable.AddCell(new Phrase(data[i,j], text));
                }
                
            }
            

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = "report_" + tfItemId.Text;
            savefiledialoge.DefaultExt = ".pdf";
            
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }


        private void exportAllItemsToCsvFile(object sender, EventArgs e)
        {
            List<ProductItem> items = new List<ProductItem>();

            SQLiteConnection conn = new SQLiteConnection(DbConfig.CONNECTION_STRING);
            conn.Open();
            String query = "select * from items";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ProductItem item = new ProductItem();
                item.Id = reader.GetInt32(0);
                item.Name = reader.GetString(1);
                item.Model = reader.GetString(2);
                item.Type = reader.GetString(3);
                item.Price = reader.GetString(4);
                item.Stock = reader.GetString(5);
                items.Add(item);
            }

            reader.Close();
            conn.Close();


            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = "all_items";
            savefiledialoge.DefaultExt = ".csv";

            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter(savefiledialoge.FileName))
                {
                    using (CsvWriter csv = new CsvWriter(streamWriter))
                    {
                        csv.WriteRecords(items);
                    }
                }
            }
        }

       

    }
}
