using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverView._4.Architecture.Command
{
    internal class CommandProgram
    {
        private void Start()
        {
            Receiver receiver = new TV();
            Command onCommand = new OnCommand(receiver);
            Invoker invoker = new Invoker(onCommand);
            invoker.execute();

            // On command for DVDPlayer with same invoker 
            receiver = new DVDPlayer();
            onCommand = new OnCommand(receiver);
            invoker = new Invoker(onCommand);
            invoker.execute();
        }
    }
    interface Command
    {
        void execute();
    }
    class Receiver
    {
        public void switchOn()
        {
            Console.WriteLine("Switch on from: " + this.GetType().ToString());
        }
    }
    class OnCommand : Command
    {
        private Receiver receiver;

        public OnCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }
        public void execute()
        {
            receiver.switchOn();
        }
    }
    class Invoker
    {
        private Command command;

        public Invoker(Command command)
        {
            this.command = command;
        }
        public void execute()
        {
            this.command.execute();
        }
    }

    class TV : Receiver
    {

        public String toString()
        {
            return "TV";
        }
    }
    class DVDPlayer : Receiver
    {


        public String toString()
        {
            return "DVD";
        }
    }
}
