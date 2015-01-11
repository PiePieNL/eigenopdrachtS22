﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace eigenopdracht 
{
    public class DbGame : DatabaseConnectie
    {
        public DataSet GetGameInfo(string gameTitel)
        {
            
            
            DataSet ds = new DataSet();
            try
            {
                Openconnectie();
                OracleCommand oraCommand = new OracleCommand("SELECT * FROM GAME WHERE TITEL = :TITEL", conn);
                oraCommand.Parameters.Add(new OracleParameter("TITEL", gameTitel));

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

        public List<Bericht > getGameNieuws(string gametitel)
        {
            List<Bericht> nieuwsberichTitel = new List<Bericht>();
           
            try
            {
                 Openconnectie();
                OracleCommand oraCommand = new OracleCommand("SELECT bericht.titel from BERICHT where GAMEID in(select Game.GAMEID from game where game.TITEL =:Titelg) and BERICHTID in (SELECT nieuws.BERICHTID FROM nieuws)", conn);
                oraCommand.Parameters.Add(new OracleParameter("Titelg", gametitel));
                 OracleDataReader oraReader = oraCommand.ExecuteReader();
                while (oraReader.Read())
                {
                    nieuwsberichTitel.Add(new Bericht(oraReader["Titel"].ToString()));
                }
                

            }
            catch { }
            finally
            {
                conn.Close();
            }
            return nieuwsberichTitel;
        }

        public DataSet Getscreenshots(string gametitel)
        {
            
            DataSet ds = new DataSet();
            try
            {
                Openconnectie();
                string sql = "Select afbeeldingurl from screenshot WHERE GAMEID in (SELECT GAMEID FROM GAME WHERE TITEL =: gametitel) ";
                OracleCommand oraCommand = new OracleCommand(sql, conn);
                oraCommand.Parameters.Add(new OracleParameter("gametitel", gametitel));
               

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