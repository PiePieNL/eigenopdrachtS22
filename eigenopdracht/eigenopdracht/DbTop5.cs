using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace eigenopdracht
{
    public class DbTop5
    {
        public DataSet GetTop5(string maand ,string jaar)
        {
            OracleConnection conn = new OracleConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                string sql = "SELECT g.TITEL, g.AFBURL, g.PLATFORM,to_char(g.releasedatum , 'DD/MM/YYYY')as releasedatum,tp.POSITIE FRom Game g,Top100positie tp WHERE g.GAMEID = tp.GAMEID and tp.TOP100ID in (SELECT TOP100ID FROM TOP100 WHERE  to_char(TOP100.DATUM , 'MM') =:maand and to_char(TOP100.DATUM , 'YYYY') =:jaar  ) ORDER BY tp.POSITIE ASC";
                OracleCommand oraCommand = new OracleCommand(sql, conn);
                oraCommand.Parameters.Add(new OracleParameter("maand", maand));
                oraCommand.Parameters.Add(new OracleParameter("jaar", jaar));

                OracleDataAdapter adapter = new OracleDataAdapter(oraCommand);
                adapter.Fill(ds);


            }
            catch (OracleException exc)
            {

            }
            finally
            {
                conn.Close();
            }
            return ds;

        }
    }
}