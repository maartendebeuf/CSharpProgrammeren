using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenLes3_3
{
//    In deze oefening is het de bedoeling dat we de werking van een deur simuleren.
    //● Maak de klasse “Door”
        //○ Methods
    //■ LockDoor()
        //● Hou bij of de deur op slot is
    //■ UnlockDoor()
    //■ OpenDoor()
        //● Hou bij of de deur open is of niet
    //■ CloseDoor()
        //○ Vang volgende fouten op met excepties:
    
    //■ De deur kan niet open wanneer deur op slot is
    //■ De deur kan niet gesloten worden wanneer de deur open is--ok
    //■ De deur kan niet open wanneer de deur al open is--ok
    //■ De deur kan niet gesloten worden als die reeds gesloten is--ok
    public class Door
    {
        private bool _isDoorLocked = false;
        private bool _isDoorOpen = false;

        public void LockDoor()
        {
            if (_isDoorOpen)
            {
                throw new LockDoorWhileOpenException("De deur kan niet gesloten worden wanneer de deur open is");
            }
            else
            {

                if (_isDoorLocked)
                {
                    throw new CloseDoorWhileClosedException("De deur kan niet gesloten worden als die reeds gesloten is");
                }
                else
                {
                    _isDoorLocked = true;
                }
            }
        }
        public void UnlockDoor()
        {

        }
        public void OpenDoor()
        {
            if (_isDoorLocked)
            {
                throw new OpenDoorWhileLockedException("De deur kan niet open wanneer deur op slot is");
            }
            else
            {
                if (_isDoorOpen)
                {
                    throw new OpenDoorWhileOpenException("De deur kan niet open wanneer de deur al open is");
                }
                else
                {
                    _isDoorOpen = true;
                }
            }
        }

        public void CloseDoor()
        {

        }

    }
}
