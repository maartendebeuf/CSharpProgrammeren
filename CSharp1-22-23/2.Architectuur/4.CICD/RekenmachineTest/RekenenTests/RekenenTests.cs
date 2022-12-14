namespace RekenenTests
{
    [TestClass]
    public class RekenenTests
    {
        [TestMethod]
        public void TestSomWaarden()
        {
            Single x = 542;
            Single y = 8;
            Single expected = 550;
            Single returned = 0;


            Rekenen.Rekenen rekenen = new Rekenen.Rekenen();

            returned = rekenen.Som(x, y);
            Assert.AreEqual(expected, returned);
        }
        [TestMethod]
        public void TestVerschilWaarden()
        {
            Single x = 542;
            Single y = 8;
            Single expected = 534;
            Single returned = 0;


            Rekenen.Rekenen rekenen = new Rekenen.Rekenen();

            returned = rekenen.Verschil(x, y);
            Assert.AreEqual(expected, returned);
        }
        [TestMethod]
        public void TestProductWaarden()
        {
            Single x = 2;
            Single y = 8;
            Single expected = 16;
            Single returned = 0;


            Rekenen.Rekenen rekenen = new Rekenen.Rekenen();

            returned = rekenen.Product(x, y);
            Assert.AreEqual(expected, returned);
        }
        [TestMethod]
        public void TestDelenWaarden()
        {
            Single x = 500;
            Single y = 5;
            Single expected = 100;
            Single returned = 0;


            Rekenen.Rekenen rekenen = new Rekenen.Rekenen();

            returned = rekenen.Delen(x, y);
            Assert.AreEqual(expected, returned);
        }
        [TestMethod]
        public void TestDelenDoorNul()
        {
            Single x = 500;
            Single y = 0;
            Single expected = 0;
            Single returned = 0;


            Rekenen.Rekenen rekenen = new Rekenen.Rekenen();

            //returned = rekenen.Delen(x, y);
            Assert.ThrowsException<DivideByZeroException>(()=>rekenen.Delen(x,y));
        }
    }
}