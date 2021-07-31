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
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Member_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameText.Text;
            string contact = contactTextbox.Text;
            string email = emailtext.Text;
            string address = addressText.Text;
            string age = ageText.Text;
            string DOB = dateTimeDOB.Text;
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
            string membership = comboMember.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database = gym; Integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into gymTable (Name,Address, Contact, Email,Membership, Gender) values ('"+name + "', '"+ address+"','"+contact+"','"+email+"','"+membership+"','"+gender+"')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data  Saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameText.Clear();
            contactTextbox.Clear();
            addressText.Clear();
            emailtext.Clear();
            dateTimeDOB.Value = DateTime.Now;
            dateTimeJD.Value = DateTime.Now;
            comboMember.ResetText();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            ageText.Clear();
        }
    }
}
