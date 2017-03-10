using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace STAGE
{
   
        class SqlDbConnect
        {
            private SqlConnection _con;
            public SqlCommand Cmd;
            private SqlDataAdapter _da;
            private DataTable _dt;
            /***************************************************************************/
            public SqlDbConnect()
            {
                _con = new SqlConnection(@"Data Source=ADIL-PC;Initial Catalog=gestag;Integrated Security=True");
                _con.Open();
                if (_con.State == ConnectionState.Open)
                {


                }


            }
            public bool connectionstateftw()
            {
                _con = new SqlConnection(@"Data Source=ADIL-PC;Initial Catalog=gestag;Integrated Security=True");
                _con.Open();
                if (_con.State == ConnectionState.Open)
                {

                    return true;

                }
                return false;
            }
            /***************************************************************************/
            public void SqlQuery(string queryText)
            {
                Cmd = new SqlCommand(queryText, _con);
            }
            /***************************************************************************/
            public DataTable QueryEx()
            {
                _da = new SqlDataAdapter(Cmd);
                _dt = new DataTable();
                _da.Fill(_dt);
                return _dt;

            }
            /****************************************************************************/
            public void NonQueryEx()
            {
                Cmd.ExecuteNonQuery();
            }

        }
    }

