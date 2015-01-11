using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace eigenopdracht
{
    public class Dblogin
    {


        public bool checkusename(string username)
        {
            bool userbestaat = false;
            OracleConnection conn = new OracleConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            int usernamecheck;
            try
            {
                conn.Open();
                OracleCommand oraCommand = new OracleCommand("SELECT count(*) as usercheck from ACCOUNT where username = :username", conn);
                oraCommand.Parameters.Add(new OracleParameter("username", username));
                usernamecheck = int.Parse(oraCommand.ExecuteScalar().ToString());
                if (usernamecheck == 1)
                {
                    userbestaat = true;
                }

            }
            catch { }
            finally
            {
                conn.Close();
            }
            return userbestaat;
        }

        public bool checkpass(string username, string pass)
        {
            bool passcorrect = false;
            OracleConnection conn = new OracleConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            try
            {
                conn.Open();
                OracleCommand oraCommand = new OracleCommand("SELECT wachtwoord  from ACCOUNT where username = :username", conn);
                oraCommand.Parameters.Add(new OracleParameter("username", username));
                string password = oraCommand.ExecuteScalar().ToString();
                if (password == pass)
                {
                    passcorrect = true;
                }

            }
            catch { }
            finally
            {
                conn.Close();
            }
            return passcorrect;

        }
    }
}