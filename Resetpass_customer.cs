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
    public partial class Resetpass_customer : Form
    {
        static string client_id = "";
        SqlConnection cn = new SqlConnection(@"Server=MOHSEN\SQLEXPRESS; DataBase=house_rental; Integrated Security=true;");//open connection to the Database
        SqlCommand cmd;//when i add new data this will call in the sign ip button
        public Resetpass_customer(string clientnationalID) // to pass the clientnational id from the last form to this form 
        {
            client_id = clientnationalID;
            InitializeComponent();

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Frogotpass_customer back = new Frogotpass_customer();
            this.Hide();
            back.Show();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (txtnewpass.Text != string.Empty && txtrepass.Text != string.Empty) //to check if the there is data in text or not
            {
                try//to avoid any errors occurd
                {
                    if (txtnewpass.Text == txtrepass.Text)
                    {
                        cn.Open(); // OPEN CONNECTION
                        cmd = new SqlCommand("UPDATE client SET clientpassword ='" + txtnewpass.Text + "' , confirmclientpassword = '" + txtrepass.Text + "' where clientNationalID= '" + client_id + "'", cn); // that order to update the data IN database
                        cmd.ExecuteNonQuery(); // TO EXECUTE THE ORDER OF QUERY
                        cn.Close();// CLOSE CONNECTION
                        MessageBox.Show("Updated Successfully!", "RentX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        login_form_for_client clientform = new login_form_for_client(); //CHANGE TO THE NEXT FORM
                        clientform.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter same password", "RentX", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "RentX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Enter your password!", "RentX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showpasscheck_CheckedChanged(object sender, EventArgs e)
        {
            //to show password
            if (showpasscheck.Checked)
            {
                txtnewpass.UseSystemPasswordChar = true;
            }
            else
            {
                txtnewpass.UseSystemPasswordChar = false;
            }
        }
    }
}
