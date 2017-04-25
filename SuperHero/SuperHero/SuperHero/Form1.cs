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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        public Form1(Int32 intHero_ID)
        {
            InitializeComponent();


            Hero temp = new Hero();
            SqlDataReader dr = temp.FindOnePerson(intHero_ID);


            while (dr.Read())
            {

                txtFName.Text = dr["FName"].ToString();
                txtLName.Text = dr["LName"].ToString();
                txtAbility1.Text = dr["Ability1"].ToString();
                txtAbility2.Text = dr["Ability2"].ToString();
                txtAbility3.Text = dr["Ability3"].ToString();
                txtOrigin.Text = dr["Origin"].ToString();
                lblHero_ID.Text = dr["Hero_ID"].ToString();
                cmbState.SelectedItem = dr["state"].ToString();


                bool blnFound = false;
                int intIndex = 0;
                while (blnFound == false)
                {
                    if (((ComboBoxItem)cmbState.Items[intIndex]).Value == intHero_ID)
                    {
                        blnFound = true;
                        cmbState.SelectedItem = intIndex;
                    }

                    intIndex++;
                }




            }




        }





        private void btnSubmit_Click(object sender, EventArgs e)
        {

            //Creating a person instance (blank)
            Hero Hero = new Hero();

            Hero.FName = txtFName.Text;
            Hero.LName = txtLName.Text;
            Hero.Ability1 = txtAbility1.Text;
            Hero.Ability2 = txtAbility2.Text;
            Hero.Ability3 = txtAbility3.Text;
            Hero.Origin = txtOrigin.Text;
            Hero.Date = dtpdate.Value;
            Hero.Email = txtEmail.Text;
            Hero.State = cmbState.Text;


            Hero.AddSuperHero();




            if (Hero.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = Hero.Feedback;
            }
            else
            {

                DisplayInfo(Hero);

            }


            if (Hero.Feedback.Contains("Error: Email"))
            {
                txtEmail.BackColor = Color.Yellow;
            }
        }


        //private void DisplayInfo(Hero temp)
        //{

        //    lblFeedback.Text = temp.FName + " " + temp.LName;


        //}

        private void DisplayInfo()
        {
            lblFeedback.Text = "Unknown Person....Lack of Data";

        }




        public void DisplayInfo(Hero temp)
        {

            lblFeedback.Text = temp.FName + "\n";
            lblFeedback.Text += temp.LName + "\n";
            lblFeedback.Text += temp.Ability1 + "\n";
            lblFeedback.Text += temp.Ability2 + "\n";
            lblFeedback.Text += temp.Ability3 + "\n";
            lblFeedback.Text += temp.Date + "\n";
            lblFeedback.Text += temp.Origin + "\n";
            lblFeedback.Text += temp.Email + "\n";
            //lblFeedback.Text += temp.State + "\n";



        }


        private void FillStates()
        {

            SqlDataReader dr = @MyUtilities.GetMyStates();

            while (dr.Read())
            {

                cmbState.Items.Add(dr["State"].ToString());

            }

            dr.Close();

        }







    }
}
