using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace house_managment_system_project_cs
{
    public partial class login_form_for_client : Form
    {
        SqlConnection cn = new SqlConnection(@"Server=MOHSEN\SQLEXPRESS; DataBase=house_rental; Integrated Security=true;");//open connection to the database
        SqlCommand cmd;//when i add new data this will call in the sign in button
        public login_form_for_client()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)//if the user doesn't have an account , they click on the create button to move into the register form 
        {
            Register_for_client newForm = new Register_for_client();
            newForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)// backbutton to back to the Home Form 
        {
            Home newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void login_form_for_client_FormClosing(object sender, FormClosingEventArgs e)// if the user clicks on the close form , message will appear if they want to close this form
        {
            DialogResult result = MessageBox.Show("Do You want To Close RentX ", "RentX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer f = new Customer();
            f.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//checkbox if it checked the password will appear , if not it doesn't appear
        {
            if (showpasscheck.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void signbut_Click(object sender, EventArgs e)//login form of the customer
        {
            try
            {
                if (txtname.Text == "" && txtpassword.Text == "")// if the customer didn't input their username ,we ask them to input their username
                {
                    MessageBox.Show("Please Enter value in all field", "RentX");
                }
                else
                {
                    string query = "select clientemailaddress,clientpassword from client where clientemailaddress = '" + txtname.Text + "' and clientpassword = '" + txtpassword.Text + "'";//search in the database about the input usrename and password
                    SqlDataAdapter sda = new SqlDataAdapter(query, cn);//save the data in data adapter
                    DataTable datable = new DataTable();//to get the data from dataadapter
                    sda.Fill(datable);//fill datatable to check if there is data or not
                    if (datable.Rows.Count == 1) //// if there is data in this data table and = to the data in database then continue to the next form
                    {
                        Customer newForm = new Customer();
                        newForm.Show();
                        this.Hide();
                    }
                    else// if the password or username is Invalid , message appear that the password or username is Wrong
                    {
                        MessageBox.Show("Invalid UserName or Password", "RentX");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "RentX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createbut_Click(object sender, EventArgs e)//if the customer doesn't have an account he could create an account 
        {
            Register_for_client signup = new Register_for_client();
            signup.Show();
            this.Hide();
        }

        private void loginpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void forgotpass_Click(object sender, EventArgs e)//when the customer forgot theri password clicks on the forgotpassword
        {
            Frogotpass_customer forgotpass = new Frogotpass_customer();
            forgotpass.Show();
            this.Hide();
        }

        private void showpasscheck_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasscheck.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }
    }
}
