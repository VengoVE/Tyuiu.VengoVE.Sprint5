using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.VengoVE.Sprint5.Task2.V27.Lib;

namespace Tyuiu.VengoVE.Sprint5.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = $@"C:\Users\ASUS\source\repos\Tyuiu.VengoVE.Sprint5\Tyuiu.VengoVE.Sprint5.Task2.V27\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
