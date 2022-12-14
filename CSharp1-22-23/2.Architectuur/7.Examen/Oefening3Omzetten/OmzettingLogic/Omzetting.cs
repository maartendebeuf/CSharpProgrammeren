using static System.Net.Mime.MediaTypeNames;

namespace OmzettingLogic
{
//      Schrijf een class library om temperaturen om te zetten van graden Celcius naar graden Kelvin of Fahrenheit en omgekeerd.
//      De Business Logic moet getest worden adhv Unit Tests.

//      Implementatie van Celcius naar Kelvin = (temp °C + 273.15)
//      Implementatie van Celcius naar Fahrenheit =  ((temp °C* 1.8) + 32)

//      Uit te voeren unit tests:

//      Celcius naar Kelvin:  invoer: 19 °C -> verwacht antwoord: 292.15 K.
//      Celcius naar FarenHeit: invoer 19 °C -> verwacht antwoord: 66.2 F
//      Kelvin naar Celcius: invoer 298 °K -> verwacht antwoord: 24.85 °C
//      Celcius naar Kelvin: invoer: null -> verwacht antwoord:  ArgumentNullException
    public class Omzetting
    {
        public double CelciusNaarKelvin(double? gradenCelcius)
        {
            if (gradenCelcius == null)throw new ArgumentNullException();
            //Celcius naar Kelvin = (temp °C + 273.15)
            return ((double)(gradenCelcius + 273.15));
        }
        public double CelciusNaarFahrenheit(double gradenCelcius)
        {
            //Celcius naar  = ((temp °C* 1.8) + 32)
            return ((gradenCelcius * 1.8) +32);
        }
        public double KelvinNaarCelcius(double gradenKelvin)
        {
            //Kelvin naar Celcius = (temp K - 273.15)
            return Math.Round((double)(gradenKelvin - 273.15), 2);
        }
        public double KelvinNaarFahrenheit(double gradenFahrenheit)
        {
            //Fahrenheit naar Celcius = ((temp F - 32)/1.8)
            return ((gradenFahrenheit - 32)/ 1.8);
        }
    }
}