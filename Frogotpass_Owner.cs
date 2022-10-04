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
    public partial class Frogotpass_Owner : Form
    {
        static string ownernationalid = "";//to save the national id in this variable and send this to another form to change the password only for this national id
        SqlConnection cn = new SqlConnection(@"Server=MOHSEN\SQLEXPRESS; DataBase=house_rental; Integrated Security=true;");//open connection to the database
        SqlCommand cmd;//when i add new data this will call in the sign in button
        
        public Frogotpass_Owner()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Login_form_Owner bck = new Login_form_Owner();// back button , if the owner clicks on this button he will back to the login form 
            bck.Show();
            this.Hide();
        }

        private void Frogotpass_Owner_FormClosing(object sender, FormClosingEventArgs e)
            //ask the owner if he want to close this form when he clicks in the close form
        {
            DialogResult result = MessageBox.Show("Do you Want to Close RentX", "RentX", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result==DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select ownerNationalID from holder where ownerNationalID = '" + txtNational_IDowner.Text + "'", cn);//to get the data from database and save it in dataAdaptar
            DataTable datable = new DataTable();//create an object form datatable to save the data came form dataAdapter and to check if national id exect or not
            sda.Fill(datable);//to get the data from database and save it in datatable
            if (datable.Rows.Count == 1) // if we check nationalID is valid  
            {
                cn.Open();
                SqlCommand username = new SqlCommand("select owneremailaddress from holder where ownerNationalID = '" + txtNational_IDowner.Text + "'", cn);//appear username when the correct nationalid is correct

                MessageBox.Show(username.ExecuteScalar().ToString(), "RentX     Your username is", MessageBoxButtons.OK, MessageBoxIcon.Information);//بترجع قيمة عددية وحيده علشان كده حولناها ل سترنج
                ownernationalid = txtNational_IDowner.Text;
                Resetpass_owner passwordforOwner = new Resetpass_owner(ownernationalid); //to send the value of national id to another form to change password only for this national id
                passwordforOwner.Show();
                this.Hide();
                cn.Close();
            }
            else
            {
                MessageBox.Show("Wrong National ID please try again..", "RentX"); // if the national id wrong
            }
        }
    }
}
