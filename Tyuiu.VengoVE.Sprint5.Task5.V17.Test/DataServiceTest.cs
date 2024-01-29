using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.VengoVE.Sprint5.Task5.V17.Lib;

namespace Tyuiu.VengoVE.Sprint5.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = $@"C:\Users\ASUS\source\repos\Tyuiu.VengoVE.Sprint5\Tyuiu.VengoVE.Sprint5.Task5.V17\bin\Debug\InPutDataFileTask5V17.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
