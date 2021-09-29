using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ZeensAppDemo.Controllers;

namespace ZeensAppDemo.Tests
{
    [TestClass]
    public class MockTest
    {
       

        // private Mock<CheckEmployeeController> chk;
        [TestInitialize]
        public void Initialise()
        {
            //    MemberRequests = new Mock<IMemberRequest>();
         
        }
        [TestMethod]
        public void TestMethod2()
        {
            
          var chk = Mock.Of<CheckEmployeeController>();
            Mock.Get(chk).Setup(x => x.checkEmp()).Returns(true);
          //  Mock.Get(fournisseurMeteo).Setup(m => m.QuelTempsFaitIl()).Returns(Meteo.Pluie);
            ProcessEmployeeController obje = new ProcessEmployeeController(chk);
          //  var memberProvider = new MemberProvider(MemberRequest.Object);

            Assert.AreEqual(obje.insertEmployee(), true);

        }
    }
}
