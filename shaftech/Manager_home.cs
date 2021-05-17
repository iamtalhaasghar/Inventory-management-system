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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using CsvHelper;



namespace TinaliAutoLight
{
    public partial class Manager_home : Form
    {
        public Manager_home()
        {
            InitializeComponent();
            slide_panel.Height = add.Height;
            slide_panel.Top = add.Top;
            additem_panel.BringToFront();
        }

        //form load events
        private void Manager_home_Load(object sender, EventArgs e)
        {
            //ManagerDetails manager = new ManagerDetails();
            //manager_name.Text = manager.getMname();


            

            u_itemcodeTxt.Enabled = false;
            u_itemcodeTxt.Text = "Id Auto Number";

            d_itemcodeTxt.Enabled = false;
            d_itemcodeTxt.Text = "Id Auto Number";

            p_order_idTxt.Enabled = false;
            p_order_idTxt.Text = "Id Auto Number";

            unp_orderidTxt.Enabled = false;
            unp_orderidTxt.Text = "Id Auto Number";

            itemcode.Enabled = false;
            itemcode.Text = DbConfig.getNextItemId().ToString();

        }

        //close button
        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //logout button
        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        //------------------------------------navigation pane button events
        //add-item button
        private void add_Click(object sender, EventArgs e)
        {
            slide_panel.Height = add.Height;
            slide_panel.Top = add.Top;
            additem_panel.BringToFront();
            name.Clear();
            model.Clear();
            price.Clear();
            quantity.Clear();
            type.SelectedIndex = -1;
            itemcode.Enabled = false;
            itemcode.Text = DbConfig.getNextItemId().ToString();
        }
        //update item button
        private void update_Click(object sender, EventArgs e)
        {
            slide_panel.Height = update.Height;
            slide_panel.Top = update.Top;
            updateitems_panel.BringToFront();
            u_nameTxt.Clear();
            u_modelTxt.Clear();
            u_priceTxt.Clear();
            u_stockTxt.Clear();
            u_typeCombo.SelectedIndex = -1;
            u_itemcodeTxt.Enabled = true;
            u_itemcodeTxt.Text = "";
        }
        //delete item button
        private void delete_Click(object sender, EventArgs e)
        {
            slide_panel.Height = delete.Height;
            slide_panel.Top = delete.Top;
            deleteitem_panel.BringToFront();
            d_nameTxt.Clear();
            d_modelTxt.Clear();
            d_priceTxt.Clear();
            d_instockTxt.Clear();
            d_typeCombo.SelectedIndex = -1;
            d_itemcodeTxt.Enabled = true;
            d_itemcodeTxt.Text = "";
        }
      
     

        ////////////////////////////////////---------------INPUT ITEMS PANEL FUNCTIONS----------///////////////////////////////////////

        //The method executes when the add item button clicks
        private void additem_Click(object sender, EventArgs e)
        {
            if(name.Text!="" && model.Text!="" && type.Text!="" && price.Text!="" && quantity.Text != "")
            {
                try
                {
                    SQLiteConnection conn = new SQLiteConnection(DbConfig.CONNECTION_STRING);
                    string query = "insert into `items`(`name`,`model`,`type`,`price`,`instock`) values('" + name.Text.Trim() + "','" + model.Text.Trim() + "','" + type.Text.Trim() + "','" + price.Text.Trim() + "','" + quantity.Text.Trim() + "')";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("The item is successfully added !");
                    name.Clear();
                    model.Clear();
                    price.Clear();
                    quantity.Clear();
                    type.SelectedIndex = -1;
                    itemcode.Enabled = false;
                    itemcode.Text = DbConfig.getNextItemId().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("u should fill the all fields");
            }
        }//add item method end

       
      

        ////////////////////////////////////---------------UPDATE ITEMS PANEL FUNCTIONS----------///////////////////////////////////////
        
        //The function executes when the update-the item button clicks
        private void u_itemBtn_Click(object sender, EventArgs e)
        {
            if (u_nameTxt.Text != "" && u_modelTxt.Text != "" && u_typeCombo.Text != "" && u_priceTxt.Text != "" && u_stockTxt.Text != "")
            {
                try
                {
                    SQLiteConnection conn = new SQLiteConnection(DbConfig.CONNECTION_STRING);
                    string query = "update `items` set `model`= '" + u_modelTxt.Text + "',`name`= '" + u_nameTxt.Text + "',`type`= '" + u_typeCombo.Text + "',`price`='" + u_priceTxt.Text + "', `instock`= '" + u_stockTxt.Text + "'where `id`= '" + u_itemcodeTxt.Text + "' ";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("The item details are successfully updated !");
                    u_itemcodeTxt.Clear();
                    u_itemcodeTxt.Enabled = true;
                    u_itemcodeTxt.Text = "";
                    u_modelTxt.Clear();
                    u_nameTxt.Clear();
                    u_priceTxt.Clear();
                    u_stockTxt.Clear();
                    u_typeCombo.SelectedIndex = -1;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please type correct Id of the item you want to update.");
            }

        }//u_itemBtn method end

       

     
        ////////////////////////////////////---------------DELETE ITEMS PANEL FUNCTIONS----------///////////////////////////////////////

        //The function tht executes when the delete items button clicks
        private void del_item_btn_Click(object sender, EventArgs e)
        {
            if (d_nameTxt.Text != "" && d_modelTxt.Text != "" && d_typeCombo.Text != "" && d_priceTxt.Text != "" && d_instockTxt.Text != "")
            {
                try
                {
                    SQLiteConnection conn = new SQLiteConnection(DbConfig.CONNECTION_STRING);
                    conn.Open();
                    string query = "delete from `items` where `id`= '" + d_itemcodeTxt.Text + "' ";
                    Console.WriteLine(query);
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("The item is successfully deleted from the db !");
                    d_itemcodeTxt.Clear();
                    d_itemcodeTxt.Enabled = true;
                    d_itemcodeTxt.Text = "";
                    d_modelTxt.Clear();
                    d_nameTxt.Clear();
                    d_priceTxt.Clear();
                    d_instockTxt.Clear();
                    d_typeCombo.SelectedIndex = -1;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please type correct Id of the item you want to delete.");
            }
        }

       
       
      
        //export pdf function
        public void exportgridtopdf()
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


            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(6);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.NORMAL);

            PdfPCell cell = new PdfPCell(new Phrase("ID", text));
            cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
            pdftable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Name", text));
            cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
            pdftable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Model", text));
            cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
            pdftable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Type", text));
            cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
            pdftable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Price", text));
            cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
            pdftable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Stock", text));
            cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
            pdftable.AddCell(cell);

            foreach (var item in items)
            {
                pdftable.AddCell(new Phrase(item.Id.ToString(), text));
                pdftable.AddCell(new Phrase(item.Name, text));
                pdftable.AddCell(new Phrase(item.Model, text));
                pdftable.AddCell(new Phrase(item.Type, text));
                pdftable.AddCell(new Phrase(item.Price, text));
                pdftable.AddCell(new Phrase(item.Stock, text));
            }

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = "all_items";
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
      

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void printBarCodeButtonPressed(object sender, EventArgs e)
        {

        }

        private void updateItemIdTextChanged(object sender, EventArgs e)
        {
            String searchId = u_itemcodeTxt.Text.Trim();
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
                    u_nameTxt.Text = reader.GetString(1);
                    u_modelTxt.Text = reader.GetString(2);
                    u_typeCombo.Text = reader.GetString(3);
                    u_priceTxt.Text = reader.GetString(4);
                    u_stockTxt.Text = reader.GetString(5);
                }
                else
                {
                    String notFound = "Not Found";
                    u_nameTxt.Text = notFound;
                    u_modelTxt.Text = notFound;
                    u_typeCombo.Text = notFound;
                    u_priceTxt.Text = notFound;
                    u_stockTxt.Text = notFound;
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception x)
            {
                Console.WriteLine(x.ToString());
            }

        }

        private void deleteItemIdTextChanged(object sender, EventArgs e)
        {
            String searchId = d_itemcodeTxt.Text.Trim();
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
                    d_nameTxt.Text = reader.GetString(1);
                    d_modelTxt.Text = reader.GetString(2);
                    d_typeCombo.Text = reader.GetString(3);
                    d_priceTxt.Text = reader.GetString(4);
                    d_instockTxt.Text = reader.GetString(5);
                }
                else
                {
                    String notFound = "Not Found";
                    d_nameTxt.Text = notFound;
                    d_modelTxt.Text = notFound;
                    d_typeCombo.Text = notFound;
                    d_priceTxt.Text = notFound;
                    d_instockTxt.Text = notFound;
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception x)
            {
                Console.WriteLine(x.ToString());
            }
        }

        private void generatePdfOfAllItems(object sender, EventArgs e)
        {
            exportgridtopdf();
        }

        private void generateAllItemsCsv(object sender, EventArgs e)
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
