using Tyuiu.BalinVV.Sprint2.Task3.V13.Lib;
namespace Tyuiu.BalinVV.Sprint2.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.75, ds.Calculate(0));
        }
    }
}
