using Tyuiu.BalinVV.Sprint2.Task6.V10.Lib;
namespace Tyuiu.BalinVV.Sprint2.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("10.11.2025", ds.FindDateOfPreviousDay(2025, 11, 11));
        }
    }
}
