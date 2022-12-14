using OmzettingLogic;

namespace OmzettingLogicTests
{
    [TestClass]
    public class OmzettingTest
    {
        [TestMethod]
        public void CelciusNaarKelvin()
        {
            //Celcius naar Kelvin:  invoer: 19 °C -> verwacht antwoord: 292.15 K.
            Omzetting omzetting = new Omzetting();
            double celcius = 19;
            double result = 0;
            double expectedResult = 292.15;

            result = omzetting.CelciusNaarKelvin(celcius);

            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void CelciusNaarFahrenheit()
        {
            //Celcius naar FarenHeit: invoer 19 °C -> verwacht antwoord: 66.2 F
            Omzetting omzetting = new Omzetting();
            double celcius = 19;
            double result = 0;
            double expectedResult = 66.2;

            result = omzetting.CelciusNaarFahrenheit(celcius);

            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void KelvinNaarCelcius()
        {
            //Kelvin naar Celcius: invoer 298 °K -> verwacht antwoord: 24.85 °C
            Omzetting omzetting = new Omzetting();
            double kelvin = 298;
            double result = 0;
            double expectedResult = 24.85;

            result = omzetting.KelvinNaarCelcius(kelvin);

            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void delen_doorNul_Throw_exeption()
        {
            //Celcius naar Kelvin: invoer: null -> verwacht antwoord:  ArgumentNullException
            Omzetting omzetting = new Omzetting();
            double celcius = 0;

            Assert.ThrowsException<ArgumentException>(() => omzetting.CelciusNaarKelvin(celcius));
        }

    }

}