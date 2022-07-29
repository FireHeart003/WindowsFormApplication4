using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    public partial class Main : Form
    {
        private string userName;
        public static string EnteredVal = "";
        private String saveDate;

        public Main(string activeUserName)
        {
            InitializeComponent();
            userName = activeUserName;
        }

        //save button
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection _con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\guar0\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            String currentDate = DateTime.Now.ToString("MMM dd yyyy"); 
            SqlCommand _cmd = new SqlCommand("UPDATE Login SET Message='" + textBox1.Text +"', Date='" + currentDate +"' WHERE USERNAME='" + userName +"';",_con);
            SqlDataReader myReader; 
            try
            {
                _con.Open();
               myReader = _cmd.ExecuteReader();
                MessageBox.Show("Saved");
                lastSavedDate.Text = currentDate;               
            }
            catch(Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
            _con.Close();
            //_cmd = new SqlCommand("UPDATE Login SET Message=@a1 , Date=@a2 WHERE USER=@a3", _con);
            //_cmd.Parameters.AddWithValue("@a1", textBox1.Text);
            //_cmd.Parameters.AddWithValue("@a2", DateTime.Now.ToString("MMM dd yyyy"));
            //_cmd.Parameters.AddWithValue("@a3", userName);
            //_cmd.ExecuteNonQuery();

            

        }

     

        //load button
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection _conLoad = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\guar0\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            _conLoad.Open();
            SqlCommand cmdLoad = new SqlCommand("Select Message, DATE from Login WHERE USERNAME = '" + userName + "';",_conLoad);
            SqlDataReader da = cmdLoad.ExecuteReader();
            while (da.Read())//why a while loop
            {
                textBox1.Text = da.GetValue(0).ToString();
                saveDate = da.GetValue(1).ToString();
                lastSavedDate.Text = saveDate;
            }
            _conLoad.Close();
        }

        //textbox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

 
        //main form - activate time and date
        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Time.Text = DateTime.Now.ToString("hh:mm:ss");
            Date.Text = DateTime.Now.ToString("MMM dd yyyy");
            lastSavedDate.Text = saveDate;
        }

        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void lastSavedDate_Click(object sender, EventArgs e)
        {

        }
    }
}
