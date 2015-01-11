using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using eigenopdracht;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;



namespace UnitTestGamerNL
{
    [TestClass]
    public class UnitTest1
    {
        Nbericht expected = new Nbericht(1, "halo", "de", Convert.ToDateTime("31-08-1990"), Convert.ToDateTime("31-08-1990"), "hallo");
        [TestMethod]
        // test of een Nbericht goed wordt aan gemaakt.
        public void TestcreateNbericht()
        {


            Nbericht expected = new Nbericht(1, "halo", "de", Convert.ToDateTime("31-08-1990"), Convert.ToDateTime("31-08-1990"), "hallo");
            Assert.IsNotNull(expected);
            
        }


        [TestMethod]
        // controleert of de getter van berichtid goed is
        public void checkgetterid()
        {
            Nbericht nieuwsbericht= new Nbericht(1, "halo", "de", Convert.ToDateTime("31-08-1990"), Convert.ToDateTime("31-08-1990"), "hallo");
            int actual = nieuwsbericht.Berichtid;
            int excepted =1;
            Assert.AreEqual(excepted, actual);
        }


        [TestMethod]
        // controleert of de getter van titel goed is
        public void checkgettertitel()
        {
            Nbericht nieuwsbericht = new Nbericht(1, "halo", "de", Convert.ToDateTime("31-08-1990"), Convert.ToDateTime("31-08-1990"), "hallo");
            string actual = nieuwsbericht.Titel;
            string expected ="halo";
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        // controleert of de getter van inhoud goed is
        public void checkgetterinhoud()
        {
            Nbericht nieuwsbericht = new Nbericht(1, "halo", "de", Convert.ToDateTime("31-08-1990"), Convert.ToDateTime("31-08-1990"), "hallo");
            string actual = nieuwsbericht.Inhoud;
            string expected = "de";
            Assert.AreEqual(expected, actual);
        }


        

        [TestMethod]
        // controleert die data terug geeft met hoogsteid ophalen
        public void checkjuistedatatop5MAxid()
        {
            DbTop5 db = new DbTop5();
            string actual = db.top5hoogsteid();
            string expected = "12";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        // controleert de getter postdatum
        public void checkgetterpostdatum()
        {
            Nbericht nieuwsbericht = new Nbericht(1, "halo", "de", Convert.ToDateTime("31-08-1990"), Convert.ToDateTime("31-08-1990"), "hallo");
            DateTime actual = nieuwsbericht.Postdatum;
            DateTime expected = Convert.ToDateTime("31-08-1990");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        // controleert de getter laatstgewijzigd
        public void checkgetterlaatstgewijzigd()
        {
            Nbericht nieuwsbericht = new Nbericht(1, "halo", "de", Convert.ToDateTime("31-08-1990"), Convert.ToDateTime("31-08-1990"), "hallo");
            DateTime actual = nieuwsbericht.Laatstgewijzigd;
            DateTime expected = Convert.ToDateTime("31-08-1990");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        // controleert of de getter van bron goed is
        public void checkgetterbron()
        {
            Nbericht nieuwsbericht = new Nbericht(1, "halo", "de", Convert.ToDateTime("31-08-1990"), Convert.ToDateTime("31-08-1990"), "hallo");
            string actual = nieuwsbericht.Inhoud;
            string expected = "de";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        // controleert of de constuctor van reactie werkt
        public void checkReactiecon1()
        {
            DateTime d = DateTime.Now;
            Reactie r = new Reactie("Pieter","badhvashjdfhjasg",1);
            Assert.IsNotNull(r);
        }
        [TestMethod]
        // controleert of de constuctor van reactie werkt
        public void checkReactiecon2()
        {
            DateTime d = DateTime.Now;
            Reactie r = new Reactie("Pieter", "blablablabal", d);
            Assert.IsNotNull(r);
            
        }






        
        
    }
}
