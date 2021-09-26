using AiWitnessBaseLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AiWitnessUnitTest
{
    [TestClass]
    public class TestFileAccess
    {
        [TestMethod]
        public void GetFilePaths()
        {
            Assert.IsTrue(FileHandling.GetFilePaths().Length > 0);
        }
        
        [TestMethod]
        public void GetFileNames()
        {
            Assert.IsTrue(FileHandling.GetFileNames().Length > 0);
        }
    }
}
