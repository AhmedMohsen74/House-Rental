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

namespace house_managment_system_project_cs
{
    public partial class Frogotpass_customer : Form
    {
        static string clientnationalID = ""; //to save the national id in this variable and send this to another form to change the password only for this national id 
        SqlConnection cn = new SqlConnection(@"Server=MOHSEN\SQLEXPRESS; DataBase=house_rental; Integrated Security=true;");//open connection to the database
        SqlCommand cmd;//when i add new data this will call in the sign in button
        public Frogotpass_customer()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)// back button , if the customer clicks on this button he will back to the login form
        {
            login_form_for_client back = new login_form_for_client();
            back.Show();
            this.Hide();
        }

        private void Frogotpass_customer_FormClosing(object sender, FormClosingEventArgs e)//ask the customer if he want to close this form when he clicks in the close form
        {
            DialogResult result = MessageBox.Show("Do you Want to Close RentX", "RentX", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void robotcheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void getpasswordbtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select clientNationalID from client where clientNationalID = '" + txtNational_IDowner.Text + "'", cn);//to get the data from database and save it in dataAdaptar
            DataTable datable = new DataTable();
            sda.Fill(datable);//to get the data from database and save it in dataTable
            if (datable.Rows.Count == 1) //to check if its correct national id or not
            {
                cn.Open();
                SqlCommand username = new SqlCommand("select clientemailaddress from client where clientNationalID = '" + txtNational_IDowner.Text + "'", cn);//appear username when the correct nationalid is correct
                MessageBox.Show(username.ExecuteScalar().ToString(), "RentX     Your username is", MessageBoxButtons.OK, MessageBoxIcon.Information);//بترجع قيمة عددية وحيده علشان كده حولناها ل سترنج
                clientnationalID = txtNational_IDowner.Text; // to get a copy of the result called in txtpassword
                Resetpass_customer passwordfocustomer = new Resetpass_customer(clientnationalID); //to send the value of national id to another form to change password only for this national id
                passwordfocustomer.Show();
                this.Hide();
                cn.Close();
            }
            else
            {
                MessageBox.Show("Wrong National ID please try again..", "RentX"); // if the password or username is incorrecr , message appear that the password or username is Wrong
            }
        }
    }
}
