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
    public partial class Login_form_Owner : Form
    {
        SqlConnection cn = new SqlConnection(@"Server=MOHSEN\SQLEXPRESS; DataBase=house_rental; Integrated Security=true;");//open connection to the Database
        SqlCommand cmd;//when i add new data this will call in the sign ip button
        public Login_form_Owner()
        {
            InitializeComponent();
        }

        private void Login_form_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void button6_Click(object sender, EventArgs e)//if the user doesn't have an account , they click on the create button to move into the register form 
        {
            register_Owner newForm = new register_Owner();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) //login form of the owner
        {
            if (txtname.Text!= string.Empty && txtpassword.Text!= string.Empty) // if the owner didn't input their username ,we ask them to input their username
            {
                string checkquery = "select owneremailaddress,ownerpassword from holder where owneremailaddress = '" + txtname.Text + "' and ownerpassword = '" + txtpassword.Text + "'";//search in the database about the input usrename and password
                SqlDataAdapter sda = new SqlDataAdapter(checkquery, cn);//save the data in dataadapter 
                DataTable datable = new DataTable();//to get the data from dataadapter
                sda.Fill(datable);//fill to get a copy of data from dataAdaptar 
                if (datable.Rows.Count == 1) // if there is data in this data table and = to the data in database then continue to the next form
                {
                    OwnerForm newForm = new OwnerForm();
                    newForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "RentX"); // if the password or username is incorrecr , message appear that the password or username is Wrong
                }
            }
            else
            {
                MessageBox.Show("Please Enter value in all field", "RentX",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void button5_Click_1(object sender, EventArgs e) // backbutton to back to the Home Form 
        {
            Home newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Login_form_Owner_FormClosing(object sender, FormClosingEventArgs e) // if the user clicks on the close form , message will appear if they want to close this form
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

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            /*
            if (textBox2.PasswordChar == '\0')
            {
                button3.BringToFront();
                textBox2.PasswordChar = '*';
            }
            */
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
          /*  if (textBox2.PasswordChar == '*')
            {
                button3.BringToFront();
                textBox2.PasswordChar = '\0';
                this.button4.Hide();
            }
          */
        }

        private void ShowHide_CheckedChanged(object sender, EventArgs e)//checkbox if it checked the password will appear , if not it doesn't appear
        {
            if(ShowPasschek.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }   
        }

        private void forgotpass_Click(object sender, EventArgs e)//when the owner forgot theri password clicks on the forgotpassword
        {
            Frogotpass_Owner forgotpass = new Frogotpass_Owner();
            forgotpass.Show();
            this.Hide();
        }
    }
}
