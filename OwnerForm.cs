using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace house_managment_system_project_cs
{
    public partial class OwnerForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=MOHSEN\SQLEXPRESS; DataBase=house_rental; Integrated Security=true;");//open connection to the database
        SqlCommand cmd;////when i add new data this will call in the Confirm button
        String PICTUREUrl = "";

        public OwnerForm()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OwnerForm_FormClosing(object sender, FormClosingEventArgs e)//if the owner clicks on the close form ,message will appear if he want to close tihs form or not
        {
            DialogResult result = MessageBox.Show("Do You Want To Close RentX", "RentX", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //this messagebox appears to the user when he clicks on close button
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)//log out button , if the owner clicks on this button, it will move into the login form as owner
        {
            Login_form_Owner form = new Login_form_Owner();
            this.Hide();
            form.Show();
        }

        private void txtboxarea_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxloc_TextChanged(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
       //to get photo from the memory of your computer (browse)
            OpenFileDialog opendatilg = new OpenFileDialog();
            if (opendatilg.ShowDialog() == DialogResult.OK) //if user did browse order 
            {
                PICTUREUrl = opendatilg.FileName.ToString();//the url of the photo will store in the picture url
                pictureBox2_choicephoto.ImageLocation = PICTUREUrl; //display the photo in picture box
                MessageBox.Show("Please enter the description of the picture"); //to make the user to write a description about the picture

            }
        }

        private void txtboxarea_Enter(object sender, EventArgs e)
        {
            //to make textbox disapper when i click on this and apper when i click to another
            if (txtboxarea.Text == "Area")
            {
                txtboxarea.Text = "";
                txtboxarea.ForeColor = Color.Black;
            }
        }

        private void txtboxarea_Leave(object sender, EventArgs e)
        {
            //to make textbox disapper when i click on this and apper when i click to another

            if (txtboxarea.Text == "")
            {
                txtboxarea.Text = "Area";
                txtboxarea.ForeColor = Color.Silver;
            }
        }

        private void txtboxloc_Enter(object sender, EventArgs e)
        {
            //to make textbox disapper when i click on this and apper when i click to another

            if (txtboxloc.Text == "Location")
            {
                txtboxloc.Text = "";
                txtboxloc.ForeColor = Color.Black;
            }
        }

        private void txtboxloc_Leave(object sender, EventArgs e)
        {
            //to make textbox disapper when i click on this and apper when i click to another

            if (txtboxloc.Text == "")
            {
                txtboxloc.Text = "Location";
                txtboxloc.ForeColor = Color.Silver;
            }
        }

        private void txtboxprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxprice_Enter(object sender, EventArgs e)
        {
            //to make textbox disapper when i click on this and apper when i click to another

            if (txtboxprice.Text == "Price")
            {
                txtboxprice.Text = "";
                txtboxprice.ForeColor = Color.Black;
            }
        }

        private void txtboxprice_Leave(object sender, EventArgs e)
        {
            //to make textbox disapper when i click on this and apper when i click to another

            if (txtboxprice.Text == "")
            {
                txtboxprice.Text = "Price";
                txtboxprice.ForeColor = Color.Silver;
            }
        }

        private void txtboxroms_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxroms_Enter(object sender, EventArgs e)
        {
            //to make textbox disapper when i click on this and apper when i click to another

            if (txtboxroms.Text == "Rooms")
            {
                txtboxroms.Text = "";
                txtboxroms.ForeColor = Color.Black;
            }
        }

        private void txtboxroms_Leave(object sender, EventArgs e)
        {
            //to make textbox disapper when i click on this and apper when i click to another


            if (txtboxroms.Text == "")
            {
                txtboxroms.Text = "Rooms";
                txtboxroms.ForeColor = Color.Silver;
            }
        }

        private void button5_Click(object sender, EventArgs e) // button5 = upload button
        {
            //insert number of pictuers
            conn.Open(); // connection opened

            //insert the picture in database and the name of the picture by using its URL 
            cmd = new SqlCommand("insert into appartmentinfo (imagename,pic1)Values('" + txt_nameOFpicture_description.Text + "','" + PICTUREUrl + "')", conn); // pictuers

            if (PICTUREUrl == "")//to check if there is photo or not
            {
                MessageBox.Show("Please Enter picture", "RentX", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try // to avoid ExecuteNonQuery ex made in DB
                {
                    cmd.ExecuteNonQuery(); //order of the query
                    conn.Close();
                    MessageBox.Show(" Picture Saved", "RendX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "RentX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // To save radio button in database
            string state = "";
            string notchecked = "";

            if (SellRadio.Checked)//if he choose sell it will save home for sell in database
            {
                state = "sell";
            }
            else
            {
                notchecked = "not Checked";
            }

            if (RentRadio.Checked)//if he choose sell it will save home for rent in database
            {
                state = "Rent";
            }
            else
            {
                notchecked = "not Checked";
            }

            conn.Open(); // connection open

            //order of inserting the data in database
            cmd = new SqlCommand("INSERT INTO home(homeaddress, HomeState, Area, rooms, [description], Price) VALUES ('" + txtboxloc.Text + "', '" + state + "','" + txtboxarea.Text + "','" + txtboxroms.Text + "','" + Description.Text + "','" + txtboxprice.Text + "')", conn);
            try// to avoid ExecuteNonQuery ex made in DB that made cause wrong relation
            {
                cmd.ExecuteNonQuery(); // order of insert the data 
                MessageBox.Show("Saved Successfuly", "RentX", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //to make texrboxes empty after the user confirmed
                txtboxarea.Text = "";
                txtboxloc.Text = "";
                txtboxprice.Text = "";
                txtboxroms.Text = "";
                PICTUREUrl = "";
                txt_nameOFpicture_description.Text = "";
                Description.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Not Saved", "RentX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            OwnerTerms form = new OwnerTerms();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Help_Owner form = new Help_Owner();
            form.Show();
            this.Hide();
        }

        private void OwnerForm_Load(object sender, EventArgs e)
        {

        }

       
    }
}

