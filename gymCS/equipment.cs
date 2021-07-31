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
    public partial class equipment : Form
    {
        public equipment()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewEquipment ve = new viewEquipment();
            ve.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = textBoxequipName.Text;
            string description = equipDescrip.Text;
        
            string cost = equipCost.Text;
            string DOD = equipDate.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database = gym; Integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into equipments (equiName, description, delivery, cost) values ('" + name + "', '" + description + "','" + DOD + "','" + cost+ "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data  Saved");
        }

        private void equiptxt_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxequipName.Clear();
            equipCost.Clear();
            equipDate.Value = DateTime.Now;
            equipDescrip.Clear();
        }
    }
}
