using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GrigorevKU.Sprint5.TaskReview.V20.Lib;

namespace Tyuiu.GrigorevKU.Sprint5.TaskReview.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedFileExists()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V20.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string strline = "Ссловарные сслова сс удвоенной ссогласной нн";
            string res = ds.Calculate(strline);
            string wait = "Ссловарные слова с удвоенной согласной нн";
            Assert.AreEqual(wait, res);
        }

    }
}
