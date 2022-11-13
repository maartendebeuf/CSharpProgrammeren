
//Create instance
using _1_EventsAndDelegates2;

var counter = new SpecialCounter();
//Add event listener
counter.DivisableBy5 += Counter_DivisableBy5;

void Counter_DivisableBy5(object? sender, DivisableEventArgs e)
{
    Console.WriteLine("The counter is now divisable by 5! Current value:" + e.Counter);
    Console.WriteLine("Waiting for key!");
    Console.ReadKey();
}

//Keep running until 50
for (int i = 0; i < 50; i++)
{
    counter.Add();
}

Console.WriteLine("The end!");
Console.ReadKey();
