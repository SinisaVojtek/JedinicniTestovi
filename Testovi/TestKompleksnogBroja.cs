using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.Oom;

namespace Testovi
{
    /// <summary>
    /// Summary description for TestKompleksnogBroja
    /// </summary>
    [TestClass]
    public class TestKompleksnogBroja
    {
        
        [TestMethod]
        public void PozivKonstruktoraKompleksnogBrojaKaoRealniDioPostavljaPrviBroj()
        {
            KompleksniBroj kb=new KompleksniBroj(4,7);
            Assert.AreEqual(4, kb.RealniDio);
        }

        [TestMethod]
        public void PozivKonstruktoraKompleksnogBrojaKaoImaginarniDioPostavljaDrugiBroj()
        {
            KompleksniBroj kb = new KompleksniBroj(4, 7);
            Assert.AreEqual(7, kb.ImaginarniDio);
        }

        [TestMethod]
        public void ZbrojDvaKompleksnaBrojaDajeKompleksniBrojSRealnimDjelomJednakimZbrojuRealnihDjelova()
        {
            KompleksniBroj kb1 = new KompleksniBroj(4, 7);
            KompleksniBroj kb2 = new KompleksniBroj(7, 9);
            Assert.AreEqual(11, (kb1+kb2).RealniDio);
        }

        [TestMethod]
        public void ZbrojDvaKompleksnaBrojaDajeKompleksniBrojSImaginarnimDjelomJednakimZbrojuImaginarnihDjelova()
        {
            KompleksniBroj kb1 = new KompleksniBroj(4, 7);
            KompleksniBroj kb2 = new KompleksniBroj(7, 9);
            Assert.AreEqual(16, (kb1 + kb2).ImaginarniDio);
        }
    }
}
