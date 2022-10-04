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
    public partial class Register_for_client : Form
    {
        SqlConnection cn = new SqlConnection(@"Server=MOHSEN\SQLEXPRESS; DataBase=house_rental; Integrated Security=true;");//open connection to the database
        SqlCommand cmd; //when i add new data this will call in the sign up button
        SqlDataReader dr;
        
        public Register_for_client()
        {
            InitializeComponent();
        }

        private void Register_for_client_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)// backbutton to back to the login form as customer
        {
            login_form_for_client backform = new login_form_for_client();
            backform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)//create new account as a customer
        {

            if (txtrepass.Text != string.Empty && txtpass.Text != string.Empty && txtname.Text != string.Empty && txtmail.Text != string.Empty && txtid.Text != string.Empty && txtphone.Text != string.Empty)//check that each textbox is full with data or not
            {

                if (txtpass.Text == txtrepass.Text)//chech that the password matches the RePassword
                {
                    cn.Open();
                    cmd = new SqlCommand("select * from client where clientusername='" + txtname.Text + "'", cn);//chech that the username is not exit brefore
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
                            MessageBox.Show("Please Enter your Correct National ID", "RentX", MessageBoxButtons.OK, MessageBoxIcon.Error);//if not valid, message will appear that incorrect ID
                                cn.Close();
                        }
                        else//if the Id is valid ,he will check the phone
                        {
                            if ((txtphone.Text).Length != 11)//check that the phone is valid"11 number"
                            {
                                MessageBox.Show("Please enter your Correct phone number", "RentX", MessageBoxButtons.OK, MessageBoxIcon.Warning);//if not valid, message will appear that incorrect phone
                                cn.Close();
                            }
                            else//check the terms is valid 
                            {
                                if (checktrems.Checked == false)//if he doesn't checked the termsbox , message will appear that he must checked the termsbox 
                                {

                                    MessageBox.Show("You must read our terms and conditions ", "RentX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cn.Close();

                                }
                                else //if checkedterms is true , he will successfully added the new customer
                                {
                                    try
                                    {
                                        dr.Close();
                                        cmd = new SqlCommand("Insert into client(clientusername, clientemailaddress, clientpassword,confirmclientpassword, clientNationalID,clientphone) values('" + txtname.Text + "','" + txtmail.Text + "','" + txtpass.Text + "','" + txtrepass.Text + "','" + txtid.Text + "', '" + txtphone.Text + "')", cn); //add this data to the customer base
                                        cmd.ExecuteNonQuery(); // added successfully
                                        MessageBox.Show("Added Successfully !", "RentX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        login_form_for_client f = new login_form_for_client();//open the login form as a valid customer
                                        f.Show();
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
                    MessageBox.Show("Please Enter both Password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//message will appear that the pass and repass are not match
                    cn.Close();

                }
            }
            else//if any box is empty ,he will ask to add info in each box
            {
                MessageBox.Show("Please Enter Value in all Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 


          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//button to open the help form for the customer
        {
            HelpCutomer form = new HelpCutomer();
            form.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)//button to open the terms form for the customer
        {
            CustomerTerms form = new CustomerTerms();
            form.Show();
            this.Hide();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_for_client_FormClosing(object sender, FormClosingEventArgs e)//if the customer clicks on the closing form ,it will appear the message if he want to close or not
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)//check if the customer want to show their password or not 
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)//check if the csutomer want to show the RePassword of not 
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
