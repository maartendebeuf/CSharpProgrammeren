
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverView._4.Architecture.Singleton
{
    //Met het singleton pattern zorg je dat er precies één instance van een class bestaat,
    //en er globale toegang tot die instance is. Deze toegang verloopt via één punt, waar
    //de wrapper van de singleton controle over heeft. 
    //
    //Het pattern is nuttig bij objecten waarvan er maar één logische instantie bestaat.Zo
    //is er altijd maar één window manager actief

    public sealed class MijnUniekeClass
    {
        private string AangemaaktOp;
        private static MijnUniekeClass Instantie = null;

        private MijnUniekeClass()
        {
            AangemaaktOp = DateTime.Now.ToString();
        }

        public static MijnUniekeClass GetInstance
        {
            get
            {
                if (Instantie == null)
                {
                    Instantie = new MijnUniekeClass();
                }
                return Instantie;
            }
        }

        public string Tijd()
        {
            return AangemaaktOp;
        }
    }
}
