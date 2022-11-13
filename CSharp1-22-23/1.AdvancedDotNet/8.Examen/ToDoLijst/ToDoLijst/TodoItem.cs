using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoLijst
{
    //(Abstracte klasse TodoItem --ok
    //en de afgeleide klasses HomeWork & OutsideWork. --ok
    //Zorg voor minstens volgende properties: Name, --ok
    //Description, DueDate, ExecuterName, Location, DateExecuted) --ok
    public abstract class TodoItem
    {
        public string Name { get; set; }
        public string ExecuterName { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; } = "";
        public string Location { get; set; }
        public DateTime DateExecuted { get; set; }

        public override string ToString()
        {
            string result = $"{Name}, {DueDate.ToString("yy/MM/dd")}, {ExecuterName}, {Location}";
            if (DateExecuted != default)
            {
                result += ", " + DateExecuted.ToString("yy/MM/dd");
            }

            return result;
        }
    }
}
