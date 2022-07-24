using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Budce
{
    public partial class Product : Form
    {
        LoginForm f;
        public Product(LoginForm frm)
        {


            InitializeComponent();
            this.f = frm;
        }
        SqlConnection conn = new SqlConnection("Data Source=WIN-6Q9786A8ST6\\SQLEXPRESS;Initial Catalog=budce;Integrated Security=true");
        private void showProduct(string data)
        {
            SqlDataAdapter da = new SqlDataAdapter(data, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void showSelledProduct(string data)
        {
            SqlDataAdapter sda = new SqlDataAdapter(data, conn);
            DataSet dss = new DataSet();
            sda.Fill(dss);
            dataGridView2.DataSource = dss.Tables[0];
        }

        private void Product_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            showProduct("select * from Products");
            showSelledProduct("select *from SelledProducts");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
        }

        private void BuyProduct_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Products(ProductName,ProductCount,ProductValue,TotalAmount) values (@p1,@p2,@p3,@p4)", conn);
                int say = Convert.ToInt32(ProductCount.Text);
                double qiymet = Convert.ToDouble(Price.Text);
                double deyer = say * qiymet;
                cmd.Parameters.AddWithValue("@p1", ProductName.Text);
                cmd.Parameters.AddWithValue("@p2", int.Parse(ProductCount.Text));
                cmd.Parameters.AddWithValue("@p3", double.Parse(Price.Text));
                cmd.Parameters.AddWithValue("@p4", deyer);
                //  cmd.Parameters.AddWithValue("@idsii", Convert.ToInt32(textBox12.Text));
                cmd.ExecuteNonQuery();
                showProduct("select * from Products");

                ProductName.Clear();
                ProductCount.Clear();
                Price.Clear();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from Products where ProductId=@p", conn);
                cmd.Parameters.AddWithValue("@p", Convert.ToInt32(NumberofProduct.Text));
                cmd.ExecuteNonQuery();
                showProduct("select * from Products");

                NumberofProduct.Clear();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void SellProduct_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into SelledProducts(ProductName,ProductCount,ProductValue,TotalAmount) values (@p1,@p2,@p3,@p4)", conn);
                int sayı = Convert.ToInt32(S_ProductCount.Text);
                double qiymeti = Convert.ToDouble(S_Price.Text);
                double deyeri = sayı * qiymeti;
                cmd.Parameters.AddWithValue("@p1", S_ProductName.Text);
                cmd.Parameters.AddWithValue("@p2", int.Parse(S_ProductCount.Text));
                cmd.Parameters.AddWithValue("@p3", double.Parse(S_Price.Text));
                cmd.Parameters.AddWithValue("@p4", deyeri);
                cmd.ExecuteNonQuery();
                showSelledProduct("select * from SelledProducts");

                S_ProductName.Clear();
                S_ProductCount.Clear();
                S_Price.Clear();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void DeleteSelledProduct_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from SelledProducts where ProductId=@p1", conn);
            cmd.Parameters.AddWithValue("@p1", Convert.ToInt32(S_NumberofProduct.Text));
            cmd.ExecuteNonQuery();
            showSelledProduct("select * from SelledProducts");
            S_NumberofProduct.Clear();
            conn.Close();
        }

        private void FindProfit_Click(object sender, EventArgs e)
        {
            double cem = 0;
            int b = dataGridView2.Rows.Count;
            // int a = dataGridView1.ColumnCount;
            for (int i = 0; i < b; i++)
            {

                cem = cem + Convert.ToDouble(dataGridView2.Rows[i].Cells[4].Value.ToString());


            }
            Profit.Text = cem.ToString();
        }

        private void FindExpense_Click(object sender, EventArgs e)
        {
            double cem = 0;
            int b = dataGridView1.Rows.Count;
            // int a = dataGridView1.ColumnCount;
            for (int i = 0; i < b; i++)
            {

                cem = cem + Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value.ToString());


            }
            Profit.Text = cem.ToString();
        }

        private void Residue_Click(object sender, EventArgs e)
        {
            double cem1 = 0;
            int a = dataGridView2.Rows.Count;
            for (int i = 0; i < a; i++)
            {

                cem1 = cem1 + Convert.ToDouble(dataGridView2.Rows[i].Cells[4].Value.ToString());


            }
            double cem = 0;
            int b = dataGridView1.Rows.Count;
            // int a = dataGridView1.ColumnCount;
            for (int i = 0; i < b; i++)
            {

                cem = cem + Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value.ToString());


            }
            double gelir = cem1 - cem;
            Residue.Text = gelir.ToString();
        }

       
    }
}