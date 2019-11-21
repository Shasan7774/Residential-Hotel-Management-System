using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HM
{
    class Connection
    {

        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter sda;
        public string stg;

        public void connection()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-8CI1OK7\REN;Initial Catalog=HM;Integrated Security=True");
            con.Open();
        }

        public void DataSend (string SQL)
        {
            try
            {
                connection();
                cmd = new SqlCommand(SQL, con);
                cmd.ExecuteNonQuery();
                stg = "";

            }
            catch (Exception)
            {
                stg = "Please Check Your Data.";
            }
            con.Close();
        }

        public void DataGet(String SQL)
        {
            try
            {
                connection();
                sda = new SqlDataAdapter(SQL,con);

            }
            catch (Exception)
            {

            }
        }
    }
}
