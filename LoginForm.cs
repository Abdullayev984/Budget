using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Budce
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {

            InitializeComponent();
        }
       SqlConnection conn = new SqlConnection("Data Source=WIN-6Q9786A8ST6\\SQLEXPRESS;Initial Catalog=budce; Integrated Security=true");
      

       

      
        private void LoginForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            textBox3.Visible = false;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string username = UserName.Text;
                string password = Password.Text;
                SqlCommand cmd = new SqlCommand("Select Id, Username, Password from Users where Username = @username and Password = @password ", conn);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader r_admin_id = cmd.ExecuteReader();
                while (r_admin_id.Read())
                {
                    textBox3.Text = r_admin_id.GetValue(0).ToString();


                }
                UserName.Clear();
                Password.Clear();
                if (r_admin_id.HasRows)
                {

                    Product p = new Product(this);
                    p.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Username or password incorrect!!!");


                conn.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message.ToString());
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            Password.PasswordChar = '*';
        }

       
    }
}