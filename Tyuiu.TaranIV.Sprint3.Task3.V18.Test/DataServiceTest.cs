using Tyuiu.TaranIV.Sprint3.Task3.V18.Lib;

namespace Tyuiu.TaranIV.Sprint3.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();

            string str = "4n5nvf 56 bgy";
            char ch = 'n';
            string waiting = "nnnnvf nn bgy";

            string res = ds.ReplaceNumOnChar(str, ch);

            Assert.AreEqual(waiting, res);
        }
    }
}
