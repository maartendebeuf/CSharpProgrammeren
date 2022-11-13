using _1_EventsAndDelegates;

var clock = new Clock();

clock.AddAlarm(new DateTime(2022, 9, 14, 19, 33, 0));
clock.AddAlarm(new DateTime(2022, 9, 14, 19, 44, 0));
clock.AddAlarm(new DateTime(2022, 9, 14, 20, 4, 50));

clock.AlarmTriggered += Clock_AlarmTriggered;

void Clock_AlarmTriggered(AlarmEventArgs e)
{
    Console.WriteLine("Alarm went off! -> " + e.Alarm.ToLongTimeString());
}

Console.ReadKey();