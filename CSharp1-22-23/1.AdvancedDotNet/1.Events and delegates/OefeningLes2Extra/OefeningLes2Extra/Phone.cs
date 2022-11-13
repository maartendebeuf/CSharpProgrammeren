using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningLes2Extra
{
    public class Phone
    {
        public string telefoonnummer { get; set; }
        public event EventHandler Called;
        public event EventHandler Messaged;
        public delegate void MessageEventHandler(object sender, MessageEventArgs e)
        public void CallPhone()
        {
            Called?.Invoke(this, null);
        }
        public void SendMessage()
        {

        }
        

        //          	MessageEventHandler = custom EventHandler (met MessageEventArgs ipv EventArgs)
        //          	MessageEventsArgs = custom EventArgs deze heeft de property Message

    }
}
