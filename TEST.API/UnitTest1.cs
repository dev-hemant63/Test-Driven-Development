using Repository;

namespace TEST.API
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 obj = new Class1();
            int res = obj.Sum(2,3);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Class1 obj = new Class1();
            int res = obj.divide(9, 0);
        } 
    }
}