using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;


namespace eigenopdracht
{
    public class DatabaseConnectie
    {
        protected OracleConnection conn;
       
        public DatabaseConnectie()
        {
            conn = new OracleConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }
        public void Openconnectie()
        {
           
            conn.Open();
        }


    }
}