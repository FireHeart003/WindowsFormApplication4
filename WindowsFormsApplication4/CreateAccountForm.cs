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

namespace WindowsFormsApplication4
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            SqlConnection _con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\guar0\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            _con.Open();
           
            try
            {
                if (textBox2.Text.Equals(textBox3.Text))
                {
                    SqlCommand _cmd = new SqlCommand("INSERT INTO Login (USERNAME, PASSWORD) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "')", _con);// SET Message='" + textBox1.Text + "', Date='" + DateTime.Now.ToString("MMM dd yyyy") + "' WHERE USERNAME='" + userName + "';", _con);
                    _cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Successfully Created");
                }
                else
                {
                    MessageBox.Show("Please make sure your password is correct.");
                }
                _con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Usernanme already taken.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
