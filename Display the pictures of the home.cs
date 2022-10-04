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
    public partial class Display_the_pictures_of_the_home : Form
    {
        static string PHOTOID = "";//gloabal variable to get the photo id from the datagrade
        SqlConnection conn = new SqlConnection(@"Server=MOHSEN\SQLEXPRESS; DataBase=house_rental; Integrated Security=true;");//open connection to the database
        SqlCommand cmd;//when i add new data this will call in the show button
        public Display_the_pictures_of_the_home(string photo)// PASs the photoid form the last form to this form 
        {
            InitializeComponent();
            PHOTOID = photo; //copy of the photo
        }

        private void ViewPhotos_Click(object sender, EventArgs e)
        {
            //open connection with the database
            conn.Open();
            // search for the data related to the id in the database
            SqlCommand cmd = new SqlCommand("SELECT pic1 from appartmentinfo where appartmentid = '" + PHOTOID + "'", conn);//select the image form database
            try
            {
                SqlDataReader DR = cmd.ExecuteReader();  // to read and save the url of the picture from the database
                if (DR.Read()) 
                {
                    String images = DR[0].ToString();//convert the image to string to display it in picture box
                    if (images != null)
                    {
                        DISPLAY_photo.ImageLocation = images;//display that when there is a photo
                    }
                    else
                    {
                        MessageBox.Show(" No Image ", "RentX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    DR.Close();
                }
                else
                {
                    MessageBox.Show(" No Record", "RentX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DR.Close();
                }
                DR.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "RentX");
            }
            conn.Close();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Customer back = new Customer();
            back.Show();
            this.Hide();
        }
    }
}
