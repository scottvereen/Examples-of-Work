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

namespace SuperHero
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
            pnlAddSearchHero.Enabled = false;
            pnlAddSearchHero.Visible = false;
        }

        private void btnAddHero_Click(object sender, EventArgs e)
        {
            //Create an instance of a form
            Form1 temp = new Form1();
            //Make it visible/active
            temp.Show();
        }

        private void btnHeroSearch_Click(object sender, EventArgs e)
        {
            //Create an instance of a form
            HeroSearch temp = new HeroSearch();
            //Make it visible/active
            temp.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblfeedback.Text = "";
            int intLevel = EmployeeLogin(txtUname.Text, txtPW.Text);
            if (intLevel <= 5 && intLevel != 0)
            {
                pnlAddSearchHero.Enabled = true;
                pnlAddSearchHero.Visible = true;

                pnlLogin.Enabled = false;
                pnlLogin.Enabled = false;
            }
            else
            {
                pnlAddSearchHero.Enabled = false;
                pnlAddSearchHero.Visible = false;

                pnlLogin.Enabled = true;
                pnlLogin.Visible = true;

                lblfeedback.Text = "Incorrect Password";
            }
        }

        private int EmployeeLogin(string strUName, string strPW)
        {
            int intAdminLevel = 0;

            SqlDataReader dr;

            SqlCommand comm = new SqlCommand();
            string strSQL = "SELECT MyLevel FROM MyLogin WHERE (UName = @UName AND PW= @PW)";

            comm.Parameters.AddWithValue("@UName", strUName);
            comm.Parameters.AddWithValue("@PW", strPW);

            SqlConnection conn = new SqlConnection();

            string strConn = @MyUtilities.GetConnectionString();

            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = strSQL;

            conn.Open();
            dr = comm.ExecuteReader();

            while (dr.Read())
            {
                intAdminLevel = Convert.ToInt16(dr["MyLevel"].ToString());

            }
            conn.Close();

            return intAdminLevel;



        }


    }
}
