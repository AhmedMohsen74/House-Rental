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
    public partial class register_Owner : Form
    {
        SqlConnection cn = new SqlConnection(@"Server=MOHSEN\SQLEXPRESS; DataBase=house_rental; Integrated Security=true;");//open connection to the database
        SqlCommand cmd;//when i add new data this will call in the sign up button
        SqlDataReader dr;

        public register_Owner()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)// backbutton to back to the login form as owner
        {
            Login_form_Owner newForm = new Login_form_Owner();
            newForm.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)// backbutton to back to the login form as owner
        {
            Login_form_Owner newForm = new Login_form_Owner();
            newForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)//create new account as a owner
        {

            if (txtrepass.Text != string.Empty && txtpass.Text != string.Empty && txtname.Text != string.Empty && txtmail.Text != string.Empty && txtid.Text != string.Empty && txtphone.Text != string.Empty)//check that each textbox is full with data
            {

                if (txtpass.Text == txtrepass.Text)//chech that the password matches the RePassword
                {
                    cn.Open();
                    cmd = new SqlCommand("select * from holder where ownerusername='" + txtname.Text + "'", cn);//chech that the username is not exit brefore
                    dr = cmd.ExecuteReader();

                    if (dr.Read())//if it exist ,message will appear that the name is already exsit
                    {
                        dr.Close();
                        MessageBox.Show("Name Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cn.Close();
                    }
                    else//if the name is not exist before,he will check the Id
                    {
                        if ((txtid.Text).Length != 14)//check that the Id if valid "14 number"
                        {
                            MessageBox.Show("Please enter your Correct National ID", "RentX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cn.Close();
                        }
                        else
                        {
                            if ((txtphone.Text).Length != 11)//if the Id is valid ,he will check the phone
                            {
                                MessageBox.Show("Please enter your Correct phone number", "RentX", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                cn.Close();
                            }
                            else//check the terms 
                            {
                                if (checkterms.Checked == false)//if he doesn't checked the termsbox , message will appear that he must checked the termsbox 
                                {

                                    MessageBox.Show("You must read our terms and conditions ", "RentX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cn.Close();

                                }
                                else//if checkedterms is true , he will successfully added the new customer
                                {
                                    try
                                    {
                                        dr.Close();
                                        //INSERT ORDER TO SAVE THIS DATA IN DATABASE
                                        cmd = new SqlCommand("Insert into holder(ownerusername, owneremailaddress, ownerpassword,confirmownerpassword, ownerNationalID,onwerphone) values('" + txtname.Text + "','" + txtmail.Text + "','" + txtpass.Text + "','" + txtrepass.Text + "','" + txtid.Text + "', '" + txtphone.Text + "')", cn); 
                                        cmd.ExecuteNonQuery(); //added successfully
                                        MessageBox.Show("Added Successfully !", "RentX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Login_form_Owner LOGINFORM = new Login_form_Owner();//open the login form as a valid Owner
                                        LOGINFORM.Show();
                                        this.Hide();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message, "RentX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    finally
                                    {
                                        cn.Close();
                                    }
                                }
                            }
                        }
                    }
                }
                else//if the password and RePassword are not matches
                {
                    cn.Open();
                    MessageBox.Show("Please Enter both Password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cn.Close();

                }
            }
            else//if any box is empty ,he will ask to add info in each box
            {
                MessageBox.Show("Please Enter Value in all Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }
            

        private void button2_Click(object sender, EventArgs e)//button to open the Help form for the Owner
        {
            Help_Owner form = new Help_Owner();
            form.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)//button to open the terms form for the Owner
        {
            OwnerTerms form = new OwnerTerms();
            form.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_Owner_FormClosing(object sender, FormClosingEventArgs e)//if the Owner clicks on the closing form ,it will appear the message if he want to close or not
        {
           DialogResult result= MessageBox.Show("Do you want to close ", "RentX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.No)
            {
                e.Cancel = true;
            }else
            {
                e.Cancel = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)//check if the customer want to show their password or not 
        {
            if (checkpass.Checked)
            {
                txtpass.UseSystemPasswordChar = true;
            }
            else
            {
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void checkrepass_CheckedChanged(object sender, EventArgs e)//check if the customer want to show their RePassword or not 
        {
            if (checkrepass.Checked)
            {
                txtrepass.UseSystemPasswordChar = true;
            }
            else
            {
                txtrepass.UseSystemPasswordChar = false;
            }
        }
    }
}
