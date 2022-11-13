using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenLes3_3Door
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
    //■ De deur kan niet gesloten worden wanneer de deur open is
    //■ De deur kan niet open wanneer de deur al open is
    //■ De deur kan niet gesloten worden als die reeds gesloten is
    public class Door
    {
        private bool _isDoorOpen = false;
        public bool IsdoorOpen
        {
            get { return _isDoorOpen; }
            set { _isDoorOpen = value; }
        }
        public string Open
        {
            get 
            {
                if (_isDoorOpen) return "Deur is Open";
                else return "Deur is dicht"; 
            }            
        }
        private bool _isDoorLocked;
        public bool IsDoorLocked
        {
            get { return _isDoorLocked; }
            set { _isDoorLocked = value; }
        }
        public string Locked
        {
            get
            {
                if (_isDoorLocked) return "Deur is gesloten";
                else return "Deur is niet gesloten";
            }
        }


        public void LockDoor()
        {
            if (_isDoorOpen)
            {
                throw new LockDoorWhileOpenException("De deur kan niet gesloten worden wanneer de deur open is");
            }
            else
            {

                _isDoorLocked = true;
            }
        }

        public void UnlockDoor()
        {
            _isDoorLocked = false;
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
            if (!_isDoorOpen)
            {
                throw new CloseDoorWhileClosedException("De deur kan niet dicht als die reeds dicht is");
            }
            else
            {
                _isDoorOpen = false;
            }
        }

    }
}
