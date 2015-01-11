using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace eigenopdracht
{
    public class DbTop5: DatabaseConnectie
    {

        public DbTop5()
        {

        }
        public DataSet GetTop5(string maand ,string jaar)
        {
            
            DataSet ds = new DataSet();
            try
            {
                Openconnectie();
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



        public bool Checktop5(string maand )
        {
            bool top5bestaat = false;
            int top5check;
            try
            {
                Openconnectie();
                OracleCommand oraCommand = new OracleCommand("SELECT count(*) as top5check from TOP100 WHERE  to_char(TOP100.DATUM , 'MM') =:maand and to_char(TOP100.DATUM , 'YYYY') =:jaar", conn);
                oraCommand.Parameters.Add(new OracleParameter("maand", maand));
                oraCommand.Parameters.Add(new OracleParameter("jaar", DateTime.Now.Year.ToString()));
                top5check = int.Parse(oraCommand.ExecuteScalar().ToString());
                if (top5check == 1)
                {
                    top5bestaat = true;
                }

            }
            catch { }
            finally
            {
                conn.Close();
            }
            return top5bestaat;
        }


        public string top5hoogsteid()
        {
            
            string maxidstring = null;
            try
            {

                Openconnectie();
                OracleCommand oraCommand = new OracleCommand("SELECT MAX(TOP100ID) From TOP100 ", conn);
                
                 int maxid = int.Parse(oraCommand.ExecuteScalar().ToString());
                 maxid++;
                 maxidstring = maxid.ToString();
                

            }
            catch { }
            finally
            {
                conn.Close();
            }
            return maxidstring;
        }

        public string PlaatsTop5(string maand)
        {
            

            string datum = "01-" + maand + "-" + DateTime.Now.Year.ToString();
            string maxid = top5hoogsteid();
            try
            {
                Openconnectie();


                OracleCommand oraCommandins = new OracleCommand("INSERT INTO top100(TOP100ID,DATUM) values(:ID, TO_DATE(:datum,'DD-MM-YYYY')) ", conn);
                oraCommandins.Parameters.Add("ID", maxid );
                oraCommandins.Parameters.Add("datum", datum);
               
                oraCommandins.ExecuteNonQuery();



            }
            catch (OracleException exc)
            {

            }
            finally
            {
                conn.Close();
            }

            return maxid;
        }

        public string idgame( string titel)
        {
            
            string idgamestring = null;
            try
            {

                Openconnectie();
                OracleCommand oraCommand = new OracleCommand("SELECT GAMEID From GAME WHERE TITEL = : titel ", conn);
                oraCommand.Parameters.Add("titel", titel);
                int gameid = int.Parse(oraCommand.ExecuteScalar().ToString());
                
                idgamestring = gameid.ToString();


            }
            catch { }
            finally
            {
                conn.Close();
            }
            return idgamestring;
        }

        public void PlaatsTop5Postitie(string gameid,string top5id, string positie)
        {
            

            try
            {
                Openconnectie();
                OracleCommand oraCommand = new OracleCommand("SELECT MAX(TOP100POSITIEID) from TOP100POSITIE ", conn);

                int maxid = int.Parse(oraCommand.ExecuteScalar().ToString());

                OracleCommand oraCommandins = new OracleCommand(" INSERT INTO TOP100POSITIE(Top100PositieID ,GAMEID,TOP100ID,POSITIE) VALUES(:maxid,:gameid,:top5id,:positie) ", conn);
                oraCommandins.Parameters.Add("maxid", maxid + 1);
                oraCommandins.Parameters.Add("gameid", gameid);
                oraCommandins.Parameters.Add("top5id", top5id);
                oraCommandins.Parameters.Add("positie", positie);
                oraCommandins.ExecuteNonQuery();



            }
            catch (OracleException exc)
            {

            }
            finally
            {
                conn.Close();
            }


        }

    }
}