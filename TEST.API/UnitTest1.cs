using Moq;
using Repository;
using Repository.DTO_s;
using Repository.Interfaces;

namespace TEST.API
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 obj = new Class1();
            int res = obj.Sum(2, 3);
            Assert.AreEqual(5, res);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMethod2()
        {
            Class1 obj = new Class1();
            int res = obj.divide(9, 0);
        }

        [TestMethod]
        public async Task SaveStudent()
        {
            var mockStudent = new Mock<IStudent>();
            mockStudent.Setup(s => s.Save(It.IsAny<StudentReq>())).ReturnsAsync(true);
            var student = mockStudent.Object;

            var res = await student.Save(new StudentReq { Name = "Hemant" });
        }
    }

}