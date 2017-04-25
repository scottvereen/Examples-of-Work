using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;    

namespace SuperHero
{
    public class Hero
    {

        private string fName;
        private string lName;
        private string ability1;
        private string ability2;
        private string ability3;
        private DateTime date;
        private string feedback = "";
        private string origin;
        private string state;
        private string email;

        public Int32 Hero_ID;

        //public Validation valid = new Validation();



        public string Feedback
        {
            get { return feedback; }
        }


        public string FName
        {
            get
            {

                return fName;
            }

            set
            {
                if (Validation.IsStringClean(value) == true)
                {

                    feedback += "ERROR: Invalade first Name clean error.\n";
                }

                else if (Validation.IsItFilledIn(value, 1) == false)
                {

                    feedback += "ERROR: Invalad First Name filled in error.\n";
                }

                else
                {

                    fName = value;
                }

            }



        }

        public string LName
        {

            get
            {

                return lName;
            }

            set
            {
                if (Validation.IsStringClean(value) == true)
                {

                    feedback += "ERROR: Invalade first Name clean error.\n";
                }

                else if (Validation.IsItFilledIn(value, 1) == false)
                {

                    feedback += "ERROR: Invalad First Name filled in error.\n";
                }

                else
                {

                    lName = value;
                }


            }
        }


        public string Ability1
        {

            get
            {

                return ability1;
            }

            set
            {

                ability1 = value;
            }



        }


        public string Ability2
        {

            get
            {

                return ability2;
            }

            set
            {

                ability2 = value;
            }



        }


        public string Ability3
        {

            get
            {

                return ability3;
            }

            set
            {

                ability3 = value;
            }



        }


        public string State
        {

            get
            {

                return state;
            }

            set
            {

                state = value;
            }
        }

        public string Origin
        {

            get
            {

                return origin;
            }

            set
            {

                origin = value;
            }



        }


        public string Email
        {

            get
            {

                return email;
            }

            set
            {
                if (Validation.IsValidEmail(value) == false)
                {
                    feedback += "Error: Your Email entery is invalad";
                }
                else
                {
                    email = value;
                }
            }
        }


        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }


        public string GetConnectionString()
        {
            return "Server=sql.neit.edu,4500; Database=SE255_SVereen; User Id=SE255_SVereen; Password=001391252;";
        }


        public string AddSuperHero()
        {
            string strFeedback = "";


            //Sql Adds following
            string strSQL = "INSERT INTO Hero (fName,lName,Ability1,Ability2,Ability3,Origin,email,Date,state) VALUES (@FName, @LName,@Ability1,@Ability2,@Ability3,@Origin,@Email,@Date,@State)";
            //Creates a connection
            SqlCommand comm = new SqlCommand();
            SqlConnection conn = new SqlConnection();

            //Who What were of a Database
            string strConn = @GetConnectionString();
            conn.ConnectionString = strConn;

            // Bark out our command
            comm.CommandText = strSQL;
            comm.Connection = conn;


            //state = "MA";
            //Fill in the paramters (Has to be created in same sequence as they are used in SQL Statement)
            comm.Parameters.AddWithValue("@FName", fName);
            comm.Parameters.AddWithValue("@LName", lName);
            comm.Parameters.AddWithValue("@Ability1", ability1);
            comm.Parameters.AddWithValue("@Ability2", ability2);
            comm.Parameters.AddWithValue("@Ability3", ability3);
            comm.Parameters.AddWithValue("@Origin", origin);
            comm.Parameters.AddWithValue("@Email", email);
            comm.Parameters.AddWithValue("@Date", date);
            comm.Parameters.AddWithValue("@State", state);

            try
            {
                //Open the connection
                conn.Open();

                //Bark command and Hangup
                strFeedback = comm.ExecuteNonQuery().ToString() + " Records Added";
                conn.Close();            //Disconnect
            }
            catch (Exception err)
            {
                strFeedback = "ERROR: " + err.Message;
                conn.Close();
            }

            return strFeedback;


        }


        public Hero()
        {

            feedback = "";



        }

        public DataSet HeroSearch(String fName, String lName)
        {
            DataSet ds = new DataSet();
            SqlCommand comm = new SqlCommand();
            String strSQL = "SELECT Hero_ID, FName, LName,Ability1,Ability2,Ability3,email,Origin,Date FROM Hero WHERE 0=0";

            if (fName.Length > 0)
            {
                strSQL += " AND fName LIKE @FName";
                comm.Parameters.AddWithValue("@FName", "%" + fName + "%");
            }
            if (lName.Length > 0)
            {
                strSQL += " AND lName LIKE @LName";
                comm.Parameters.AddWithValue("@LName", "%" + lName + "%");
            }



            SqlConnection conn = new SqlConnection();

            string strConn = @MyUtilities.GetConnectionString();
            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = strSQL;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm; 


            conn.Open();
            da.Fill(ds, "Hero");
            conn.Close();


            return ds;

        }

        public SqlDataReader FindOnePerson(int intHero_ID)
        {
            //Create and Initialize the DB Tools we need
            SqlCommand comm = new SqlCommand();
            SqlConnection conn = new SqlConnection();

            //My Connection String
            string strConn = @MyUtilities.GetConnectionString();
            conn.ConnectionString = strConn;


            //My SQL command string to pull up one person's data
            string sqlString =
           "SELECT Hero_ID, fName,lName FROM Hero WHERE Hero_ID = @Hero_ID;";

            //Tell the connection object the who, what, where, how
            conn.ConnectionString = strConn;

            //Give the command object info it needs
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@Hero_ID", intHero_ID);

            //Open the DataBase Connection and Yell our SQL Command
            conn.Open();

            //Return some form of feedback
            return comm.ExecuteReader();   //Return the dataset to be used by others (the calling form)

        }




        //FUNCTION OVERLOADING - 2 or More functions with the same name
        // but with different # of params, types of params, or sequence 

        public Hero(string fName, string lName, string origin, string ability1, string ability2, string ability3, string email)
        {
            this.FName = fName;
            this.LName = lName;
            this.Origin = origin;
            this.Ability1 = ability1;
            this.Ability2 = ability2;
            this.Ability3 = ability3;
            this.Email = email;


            feedback = "";

        }




    }
}
