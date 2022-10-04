using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace house_managment_system_project_cs
{
    public partial class Help_Owner : Form
    {
        public Help_Owner()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)//backbutton to the registert form of the owner
        {
            register_Owner backfo = new register_Owner();
            backfo.Show();
            this.Hide();
        }

        private void Help_Owner_FormClosing(object sender, FormClosingEventArgs e)//if the customer clicks on the closing form ,it will appear the message if he want to close or not
        {
            DialogResult result = MessageBox.Show("Do You Want To Close ", "RentX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void Help_Owner_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Help_Owner_Load(object sender, EventArgs e)
        {

        }
    }
}
