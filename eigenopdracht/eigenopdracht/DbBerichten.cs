using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;



namespace eigenopdracht
{
    public class DbBerichten
    {

        public Nbericht GetNieuwsBericht(string titelNieuwsBericht)
        {
            OracleConnection conn = new OracleConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            Nbericht nieuwsbericht = null;
            try
            {
                conn.Open();
                OracleCommand oraCommand = new OracleCommand("SELECT bericht.berichtid,titel,berichttekst,postdatum,laatstgewijzigd,platform,bron FROM nieuws,bericht WHERE nieuws.BERICHTID = bericht.BERICHTID and bericht.TITEL = :Titel", conn);
                oraCommand.Parameters.Add(new OracleParameter("Titel", titelNieuwsBericht));
                OracleDataReader oraReader = oraCommand.ExecuteReader();
                while (oraReader.Read())
                {
                    int berichtid;
                    string titel;
                    string tekst;
                    DateTime postdatum;
                    DateTime laatstgewijzigd;
                    string platform;
                    string bron;
                    berichtid = Convert.ToInt32(oraReader["berichtid"]);
                    titel = Convert.ToString(oraReader["titel"]);
                    tekst = Convert.ToString(oraReader["berichttekst"]);
                    postdatum = Convert.ToDateTime(oraReader["postdatum"]);
                    laatstgewijzigd = Convert.ToDateTime(oraReader["laatstgewijzigd"]);
                    platform = Convert.ToString(oraReader["platform"]);
                    bron = Convert.ToString(oraReader["bron"]);
                    nieuwsbericht = new Nbericht(berichtid,titel, tekst, postdatum, laatstgewijzigd, bron);


                }
            }
            
            catch (OracleException exc)
            {
            
                
            }
            finally
            {
                conn.Close();
                
            }


            return nieuwsbericht;

                
                


            }


        public List<Reactie> getReactiesBericht(int berichtid)
        {
            OracleConnection conn = new OracleConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            List<Reactie> reacties = new List<Reactie>();
            try
            {
                conn.Open();
                OracleCommand oraCommand = new OracleCommand("SELECT UserName,GeplaatstOP,Tekst FROM reactie WHERE BERICHTID = :berichtid", conn);
                oraCommand.Parameters.Add(new OracleParameter("berichtid", berichtid));
                OracleDataReader oraReader = oraCommand.ExecuteReader();
                while (oraReader.Read())
                {
                    string username;
                    DateTime geplaatstOp;
                    string tekst;

                    username = Convert.ToString(oraReader["UserName"]);
                    geplaatstOp = Convert.ToDateTime(oraReader["GeplaatstOp"]);
                    tekst = Convert.ToString(oraReader["Tekst"]);
                    reacties.Add(new Reactie(username, tekst, geplaatstOp));
                }
            }
            catch (OracleException exc)
            {
                
            }
            finally
            {
                conn.Close();
            }
            return reacties;

        }

        }
    
}