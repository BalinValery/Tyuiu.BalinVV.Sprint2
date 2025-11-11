using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BalinVV.Sprint2.Task1.V21.Lib
{
    public class DataService : ISprint2Task1V21
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = a != b;
            res[0] = !res[0];
            res[1] = a < d;
            res[2] = b <= d;
            res[3] = (a + d) > b;
            res[4] = (a == c) && (b > d);
            res[5] = (a ^ d) < b;
            res[5] = !res[5];
            return res;
        }
    }
}
