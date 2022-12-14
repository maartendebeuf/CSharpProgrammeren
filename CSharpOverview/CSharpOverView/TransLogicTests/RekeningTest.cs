using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransLogicTests
{
    [TestClass]
    public class RekeningTest
    {
        [TestMethod]
        public void Transactie_BedragVerhogen()
        {
            //PREPARE
            TransactieLogic.Rekening account = new TransactieLogic.Rekening();
            Single TeVerhogenBedrag = 15;
            bool Resultaat=false;
            Single HuidigeSaldo = account.HuidigSaldo;

            //ACT
            Resultaat = account.Transactie("+", TeVerhogenBedrag);
            //ASSERT
            Assert.AreEqual(HuidigeSaldo+TeVerhogenBedrag, account.HuidigSaldo);
        }

        [TestMethod]
        public void Transactie_BedragVerlagenOnderNulException()
        {
            //PREPARE
            TransactieLogic.Rekening account = new TransactieLogic.Rekening();
            Single TeVerlagenBedrag = 1;
            Single HuidigeSaldo = account.HuidigSaldo;


            //ASSERT
            Assert.ThrowsException<Exception>(()=> account.Transactie("-", HuidigeSaldo + TeVerlagenBedrag));
        }

        [TestMethod]
        public void Transactie_BedragVerlagen()
        {
            //PREPARE
            TransactieLogic.Rekening account = new TransactieLogic.Rekening();
            Single TeVerlagenBedrag = 15;
            bool Resultaat = false;
            Single HuidigeSaldo = account.HuidigSaldo;

            //ACT
            Resultaat = account.Transactie("-", TeVerlagenBedrag);
            //ASSERT
            Assert.AreEqual(HuidigeSaldo - TeVerlagenBedrag, account.HuidigSaldo);
        }

        [TestMethod]
        public void Transactie_BedragVerlagenOnderNul()
        {
            //PREPARE
            TransactieLogic.Rekening account = new TransactieLogic.Rekening();
            Single TeVerlagenBedrag = 150;
            bool Resultaat = false;
            Single HuidigeSaldo = account.HuidigSaldo;

            //ACT
            Resultaat = account.Transactie("-", TeVerlagenBedrag);
            //ASSERT
            Assert.AreEqual(HuidigeSaldo - TeVerlagenBedrag, account.HuidigSaldo);
        }


        [TestMethod]
        public void Transactie_BedragVerlagenDecimalen()
        {
            //PREPARE
            TransactieLogic.Rekening account = new TransactieLogic.Rekening();
            Single TeVerlagenBedrag = (Single)1.51;
            bool Resultaat = false;
            Single HuidigeSaldo = account.HuidigSaldo;

            //ACT
            Resultaat = account.Transactie("-", TeVerlagenBedrag);
            //ASSERT
            Assert.AreEqual( 98.49, account.HuidigSaldo);
        }
    }
}
