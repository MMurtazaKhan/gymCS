using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gymCS
{
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string contact = textBoxContact.Text;
            string email = textBoxEmail.Text;
            string address = textBoxAddress.Text;
            string DOB = dateTimePicker1.Text;
            string JD = dateTimeJD.Text;
            string gender;
            bool isCheck = radioButton2.Checked;
            if (isCheck)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            string post = comboBoxExp.Text; 

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database = gym; Integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into staffTable (Name,Address, Contact, Email,Post, Gender) values ('" + name + "', '" + address + "','" + contact + "','" + email + "','" + post + "','" + gender + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data  Saved");
        }
    }
}
