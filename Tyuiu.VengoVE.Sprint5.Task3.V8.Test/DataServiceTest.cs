﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.VengoVE.Sprint5.Task3.V8.Lib;


namespace Tyuiu.VengoVE.Sprint5.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = $@"C:\Users\ASUS\source\repos\Tyuiu.VengoVE.Sprint5\Tyuiu.VengoVE.Sprint5.Task3.V8\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
