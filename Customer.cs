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
    public partial class Customer : Form
    {
        string photo = "";
        SqlConnection conn = new SqlConnection(@"Server=MOHSEN\SQLEXPRESS; DataBase=house_rental; Integrated Security=true;");//open connection to the database
        SqlCommand cmd;//when i add new data this will call in the show button
        SqlDataAdapter Da;
        DataSet Ds = new DataSet();

        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//log out button if the customer click on this button will move into the login form as customer
        {
            login_form_for_client form = new login_form_for_client();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)//check if the customer want to sell or rent
        {
            string state = "";

            if (buyRadio.Checked)//if he check sell
            {
                conn.Open();

                state = "sell";
                cmd = new SqlCommand("select * from home where HomeState = '"+ state +"'", conn);//will search in the "buy" database tables
                cmd.ExecuteNonQuery();


             
                conn.Close();
            }

        }

        private void SellRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//check if the customer want to buy or rent 
        {
            string state = "";
            if(buyRadio.Checked)// if the customer want to buy 
            {
                state = "sell";//search in the "buy" database tables
            }
            if(RentRadio.Checked)//if the customer want to rent
            {
                state = "rent";//search in the "rent"database tables
            }
            try
            {   
                conn.Open();
                //select query to get the information about home for the client
                Da = new SqlDataAdapter("SELECT appart.appartmentid, h.homeaddress, h.HomeState, h.Area, h.rooms, h.[description], h.Price ,hold.onwerphone FROM home as h cross join holder as hold cross join appartmentinfo as appart where homeaddress = '" + txtsearch.Text + "' and HomeState = '" + state + "'", conn);
                Da.Fill(Ds, "homeaddress");//the data will appear when the user enter the home address
                ViewData.DataSource = Ds.Tables["homeaddress"];//represent the selected data "buy" or "rent" in the dataview 
            }
            catch (Exception ex)
            {
                MessageBox.Show("some errors occured !", "RentX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)//if click on search box the user can write the location 
        {
            if (txtsearch.Text == "Location")
            {
                txtsearch.Text = "";
                txtsearch.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)//if the user leave the search box it will return the word"location"
        {
            if (txtsearch.Text == "")
            {
                txtsearch.Text = "Location";
                txtsearch.ForeColor = Color.Silver;
            }
        }

        private void Customer_FormClosing(object sender, FormClosingEventArgs e)//if the user click on the close form the message will appear if he want to close or not 
        {
            DialogResult result = MessageBox.Show("Do You Want To Close RentX", "RentX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void logoutbut_Click(object sender, EventArgs e)//log out button to back to the login form 
        {
            login_form_for_client logout = new login_form_for_client();
            this.Hide();
            logout.Show();
        }

        private void ViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ViewData.SelectedRows.Count != 0) //check if datagraid view have data or not
                {

                    photo = ViewData.SelectedRows[0].Cells[0].Value.ToString(); //photo - first row and first cell

                    Display_the_pictures_of_the_home photos = new Display_the_pictures_of_the_home(photo);//pass the photo to the next form 
                    photos.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Please Select the valid row");

                }
            }
            catch
            {
                MessageBox.Show("Please Select valid row");
            }
        }
    }
}
