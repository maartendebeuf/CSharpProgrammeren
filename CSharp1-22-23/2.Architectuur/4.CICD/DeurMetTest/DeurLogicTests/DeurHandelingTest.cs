namespace DeurLogicTests
{
    [TestClass]
    public class DeurHandelingTest
    {
        [TestMethod]
        public void HeeftToegang_StatusGeblokkeerd()
        {
            string tokenID = "ABCD";
            int deurID = 1;
            Assert.AreEqual(21, DeurLogic.DeurHandeling.ToegangAanvraag(tokenID, deurID));
            //21
        }
        [TestMethod]
        public void HeeftToegang_OK()
        {
            string tokenID = "B59D";
            int deurID = 54;
            Assert.AreEqual(10, DeurLogic.DeurHandeling.ToegangAanvraag(tokenID, deurID));
            //10
        }
        [TestMethod]
        public void HeeftToegang_TokenGewijgerd()
        {
            string tokenID = "B59G";
            int deurID = 54;
            ArgumentException argumentException = new ArgumentException();

            Assert.ThrowsException<ArgumentException>(() => DeurLogic.DeurHandeling.ToegangAanvraag(tokenID, deurID), "Foutieve hex moet fout geven");
            //Exeption
        }
        [TestMethod]
        public void HeeftToegang_GeenToegang()
        {

            string tokenID = "1234";
            int deurID = 0;
            Assert.AreEqual(22, DeurLogic.DeurHandeling.ToegangAanvraag(tokenID, deurID));
            //22
        }


    }
}
