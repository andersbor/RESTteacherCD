using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RESTteacherCD.Models;

namespace RESTteacherCD.Managers.Tests
{
    [TestClass]
    public class TeachersManagerTests
    {
        [TestMethod]
        public void GetAllTest()
        {
            TeachersManager manager = new TeachersManager();
            List<Teacher> all = manager.GetAll();
            Assert.AreEqual(2, all.Count);

        }
    }
}