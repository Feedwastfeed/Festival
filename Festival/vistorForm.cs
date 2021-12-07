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
    public partial class vistorForm : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;persistsecurityinfo=True;database=festivalmanagement;password=27439510");


        public vistorForm()
        {
            InitializeComponent();
            refreshdata();
        }

        private void refreshdata()
        {


            MySqlCommand cmd = new MySqlCommand("view_events", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.datagridviewevt.DataSource = dt;
        }

        private void btnfeedback_Click(object sender, EventArgs e)
        {

            feedbackForm feedform = new feedbackForm();
            feedform.Show();
            this.Hide();
        }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlCommand cmd = new MySqlCommand("buy_ticket", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("p_username", txtboxusername.Text));
                cmd.Parameters.Add(new MySqlParameter("EventName", this.datagridviewevt.CurrentRow.Cells[0].Value.ToString()));

                con.Open();
                cmd.ExecuteNonQuery();
               

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
