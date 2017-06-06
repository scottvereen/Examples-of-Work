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
    public partial class HeroSearch : Form
    {
        public HeroSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Hero temp = new Hero();
            //Perform the search
            DataSet ds = temp.HeroSearch(txtfName.Text, txtlName.Text);

            //Display data (dataset)
            gvResults.DataSource = ds;                                  
            gvResults.DataMember = ds.Tables["Hero"].ToString();     
        }

        private void gvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string strHero_ID = gvResults.Rows[e.RowIndex].Cells[0].Value.ToString();

        
           
            int intHero_ID = Convert.ToInt32(strHero_ID);

            
            Form1 Editor = new Form1(intHero_ID);
            Editor.ShowDialog();
        }

        










    }
}
