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
    public partial class searchView : Form
    {
        public searchView()
        {
            InitializeComponent();
        }

        private void searchView_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (searchTxt.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database = gym; Integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from gymTable where ID = " + searchTxt.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                MessageBox.Show("Please enter valid data", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
