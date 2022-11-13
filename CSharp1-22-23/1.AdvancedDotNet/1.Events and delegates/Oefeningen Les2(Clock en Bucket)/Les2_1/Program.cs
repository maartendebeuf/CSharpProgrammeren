using Les2_1;

var clock = new Clock(new DateTime(2022, 9, 14,19,40,0));

clock.AlarmTriggerd += Clock_AlarmTriggerd;

void Clock_AlarmTriggerd(object? sender, EventArgs e)
{
    Console.WriteLine("Alarm Alarm Alarm!");
    
}