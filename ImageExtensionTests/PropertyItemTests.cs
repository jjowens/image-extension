using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using ImageExtension;
using System.Drawing.Imaging;

namespace ImageExtensionTests
{
    [TestClass]
    public class PropertyItemTests
    {
        [TestMethod]
        public void GetPropertyByName_FromImage1()
        {
            string imageFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images\\legobus.jpg");
            Image img = Image.FromFile(imageFilePath);

            string propEquipMake = img.GetPropertyItemValueByName(ImagePropertyName.EquipMake);
            string propEquipModel = img.GetPropertyItemValueByName(ImagePropertyName.EquipModel);

            Assert.IsNotNull(propEquipMake);
            Assert.AreEqual("samsung", propEquipMake);

            Assert.IsNotNull(propEquipModel);
            Assert.AreEqual("SM-G981B", propEquipModel);
        }
    }
}
