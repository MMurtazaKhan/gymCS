using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addMemberToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Member f1 = new Member();
            f1.Show();
        }

        private void addStaffMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff s1 = new staff();
            s1.Show();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            equipment e1 = new equipment();
            e1.Show();
        }

        private void seachMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchView SE = new searchView();
            SE.Show();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete dl = new delete();
            dl.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to exit?","Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Welcome back", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you confirm", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                login log = new login();
                log.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wecome back", "welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
