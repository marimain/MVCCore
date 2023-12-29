
using Microsoft.AspNetCore.Mvc;
using MVCCore.Models;

namespace MVCCoreTest
{
    [TestClass]
    public class PatientUnitTest
    {
        [TestMethod]
        public void IndexTest()
        {
            MVCCore.Controllers.PatientController controller = new MVCCore.Controllers.PatientController();
            var result = controller.Index() as ViewResult;
            Assert.IsTrue(result.Model is PatientMetricsViewModel a);
            
            var m = result.Model as PatientMetricsViewModel ;
            Assert.IsTrue(m.Patients is List<PatientDetail> lst);
            Assert.IsTrue(m.Patients.Count() > 0);
            Assert.AreEqual("Index", result.ViewName);

        }
    }
}