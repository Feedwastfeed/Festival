using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Festival
{
    public partial class regesterationForm : Form
    {   

        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;persistsecurityinfo=True;database=festivalmanagement;password=27439510");
        
        public regesterationForm()
        {
       
            InitializeComponent();
        }

        private void btnregisterf_Click(object sender, EventArgs e)
        {
            try
            {
               
                MySqlCommand cmd = new MySqlCommand("regisitration", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("username", txtboxusername.Text));
                cmd.Parameters.Add(new MySqlParameter("firstname", txtboxfirstname.Text));
                cmd.Parameters.Add(new MySqlParameter("lastname", txtboxlastname.Text));
                cmd.Parameters.Add(new MySqlParameter("userpass", txtboxpassword.Text));
                cmd.Parameters.Add(new MySqlParameter("email", txtboxemail.Text));
                cmd.Parameters.Add(new MySqlParameter("city", comboxcity.Text));
                cmd.Parameters.Add(new MySqlParameter("country", comboxcountry.Text));
                cmd.Parameters.Add(new MySqlParameter("address", txtboxaddress.Text));
                cmd.Parameters.Add(new MySqlParameter("gender", comboxgender.Text));
                cmd.Parameters.Add(new MySqlParameter("birth", txtboxdatebirth.Text));
                cmd.Parameters.Add(new MySqlParameter("mobile", txtboxphone.Text));
                cmd.Parameters.Add(new MySqlParameter("title", comboxtitle.Text));
                cmd.Parameters.Add(new MySqlParameter("creditnumber", txtboxcard.Text));
                cmd.Parameters.Add(new MySqlParameter("balance", 1000.0));
                con.Open();
                cmd.ExecuteNonQuery();
                this.Hide();
                loginForm logform = new loginForm();
                logform.Show();

            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void regesterationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
