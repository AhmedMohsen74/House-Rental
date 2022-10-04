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

    public partial class Resetpass_owner : Form
    {
        static string owner_id="";
        SqlConnection cn = new SqlConnection(@"Server=MOHSEN\SQLEXPRESS; DataBase=house_rental; Integrated Security=true;");//open connection to the Database
        SqlCommand cmd;//when i add new data this will call in the sign ip button
        public Resetpass_owner(string ownernationalid)
        {
            owner_id = ownernationalid;

            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Frogotpass_Owner back = new Frogotpass_Owner();
            back.Show();
            this.Hide();
        }

        private void showpasscheck_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasscheck.Checked)
            {
                txtnewpass.UseSystemPasswordChar = true;
            }
            else
            {
                txtnewpass.UseSystemPasswordChar = false;
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (txtnewpass.Text!= string.Empty && txtrepass.Text != string.Empty) //to check if the there is data in text or not
            {
                try//to avoid any errors occurd and know errors if it happens
                {
                    if (txtnewpass.Text == txtrepass.Text)
                    {
                        cn.Open(); // OPEN CONNECTION
                        //order to update the old data to new data in database
                        cmd = new SqlCommand("UPDATE holder SET ownerpassword ='" + txtnewpass.Text + "' , confirmownerpassword = '" + txtrepass.Text + "' where ownerNationalID= '" + owner_id + "'", cn); 
                        cmd.ExecuteNonQuery(); // TO EXECUTE THE ORDER OF QUERY
                        cn.Close();// CLOSE CONNECTION
                        MessageBox.Show("Updated Successfully!", "RentX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Login_form_Owner ownerform = new Login_form_Owner(); //CHANGE TO THE NEXT FORM
                        ownerform.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter same password", "RentX", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show( ex.Message, "RentX", MessageBoxButtons.OK, MessageBoxIcon.Error);//ex message to know the error occurd
                }
            }
            else
            {
                MessageBox.Show("Please Enter your password!", "RentX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
