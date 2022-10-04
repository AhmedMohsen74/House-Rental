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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //this button makes the user to be able to move into the login form as a owner"who could sell and rent"
        {
            Login_form_Owner newForm = new Login_form_Owner();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)//this buuton makes the user to be able to move into the login form as a customer "who could buy and rent"
        {
            login_form_for_client newForm = new login_form_for_client();
            newForm.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)// if the user clicks on the close form , message will appear if they want to close this form or not 
        {
            DialogResult result = MessageBox.Show("Do You want To Close RentX ", "RentX", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //this messagebox appears to the user when he clicks on close form
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Home_MaximumSizeChanged(object sender, EventArgs e)
        {
           
        }
    }
}
