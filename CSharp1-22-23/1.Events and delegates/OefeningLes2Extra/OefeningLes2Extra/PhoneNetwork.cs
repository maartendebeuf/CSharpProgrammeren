using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningLes2Extra
{
    internal class PhoneNetwork
    {
        public List<Phone> Phones { get; set; }
        public void CallPhone(int number)
        {
            Phone phone = Phones.Find(x => x.telefoonnummer.Equals(number));
            phone.CallPhone();
            //          	Bij het vinden van de telefoon trigger je het Call event van phone
        }
        public void SendMessageToPhone(int number, string message)
        {
            Phone phone = Phones.Find(x => x.telefoonnummer.Equals(number));
            //          	Bij het vinden van de telefoon trigger je het MessagedEvent van phone 

        }
    }
}
