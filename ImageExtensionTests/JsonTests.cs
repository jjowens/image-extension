using ImageExtension;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using ImageExtension.json;
using System.Collections.Generic;

namespace ImageExtensionTests
{
    [TestClass]
    public class JsonTests
    {

        [TestMethod]
        public void GetPropertyByName_FromImage1()
        {
            string imageFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images\\legobus.jpg");
            Image img = Image.FromFile(imageFilePath);

            string propEquipMake = img.GetPropertyItemByNameAsJson(ImagePropertyName.EquipMake);
            string propEquipModel = img.GetPropertyItemByNameAsJson(ImagePropertyName.EquipModel);

            Assert.IsNotNull(propEquipMake);
            Assert.AreEqual("\"EquipMake\": \"samsung\"", propEquipMake);

            Assert.IsNotNull(propEquipModel);
            Assert.AreEqual("\"EquipModel\": \"SM-G981B\"", propEquipModel);
        }

        [TestMethod]
        public void GetPropertyNamesAsJson_FromImage1()
        {
            string imageFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images\\legobus.jpg");
            Image img = Image.FromFile(imageFilePath);

            List<ImagePropertyName> list = new List<ImagePropertyName>();
            list.Add(ImagePropertyName.EquipMake);
            list.Add(ImagePropertyName.EquipModel);

            string propEquipMake = img.GetPropertyItemsByNameAsJson(list.ToArray());

            

        }
    }
}
