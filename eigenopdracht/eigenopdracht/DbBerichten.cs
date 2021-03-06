﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;



namespace eigenopdracht
{
    public class DbBerichten :DatabaseConnectie
    {

        public Nbericht GetNieuwsBericht(string titelNieuwsBericht)
        {
            
            Nbericht nieuwsbericht = null;
            try
            {
                Openconnectie();
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


        public DataSet getReactiesBericht(int berichtid)
        {
            
            DataSet ds = new DataSet();
            try
            {
                Openconnectie();
                OracleCommand oraCommand = new OracleCommand("SELECT UserName,GeplaatstOP,Tekst FROM reactie WHERE BERICHTID = :berichtid ORDER BY GeplaatstOP DESC", conn);
                oraCommand.Parameters.Add(new OracleParameter("berichtid", berichtid));
               
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


        public void Plaatsreactie(Reactie reactie)
        {
            
            
            try
            {
                Openconnectie();
                OracleCommand oraCommand = new OracleCommand("SELECT MAX(REACTIEID) from REACTIE ", conn);
                
                int maxid = int.Parse(oraCommand.ExecuteScalar().ToString());
                
                OracleCommand oraCommandins = new OracleCommand("INSERT INTO REACTIE(REACTIEID,TEKST,BERICHTID,USERNAME)VALUES(:Reactieid,:Inhoud,:Berichtid,:username) ", conn);
                oraCommandins.Parameters.Add("ReactieID", maxid + 1);
                oraCommandins.Parameters.Add("Inhoud",reactie.Reactietekst);
                oraCommandins.Parameters.Add("Berichtid",reactie.BerichtID);
                oraCommandins.Parameters.Add("username", reactie.Username);
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