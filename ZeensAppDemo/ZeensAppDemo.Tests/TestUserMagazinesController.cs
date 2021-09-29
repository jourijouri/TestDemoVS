using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZeensAppDemo.Models;
using ZeensAppDemo.Controllers;
using System.Linq;

namespace ZeensAppDemo.Tests
{
   
    [TestClass]
    public class TestUserMagazinesController
    {
        [TestMethod]

        public void ListMagazine_ShouldReturnAllList()
        {
            var testMagazines = GetTestMagazine();
            UserMagazinesController controller = new UserMagazinesController(1);

            controller.magazines = testMagazines;
            Assert.AreEqual(testMagazines.Count, controller.magazines.Count);
        }
        [TestMethod]

        public void AddMagazineToFav_ShouldRetournUserNotConnected()
        {
            var testMagazines = GetTestMagazine();
            UserMagazinesController controller = new UserMagazinesController(0);
          String result =  controller.AddMagFav(testMagazines.ElementAt(0));
            Assert.AreEqual("Verifier votre connexion de compte", result);

        }
        public void AddMagazineToFav_ShouldBeAdded()
        {
            var testMagazines = GetTestMagazine();
            UserMagazinesController controller = new UserMagazinesController(1);
            String result = controller.AddMagFav(testMagazines.ElementAt(0));
            Assert.AreEqual("Succesfully added", result);

        }

        private List<Magazine> GetTestMagazine()
        {
            var testMag = new List<Magazine>();
            testMag.Add(new Magazine { id = 1, name = "Demo1"});
            testMag.Add(new Magazine { id = 2, name = "Demo2"});
            testMag.Add(new Magazine { id = 3, name = "Demo3" });
            testMag.Add(new Magazine { id = 4, name = "Demo4"});

            return testMag;
        }


    }
}
