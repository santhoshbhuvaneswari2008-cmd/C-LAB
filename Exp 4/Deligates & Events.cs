using System;
class Alarm
{
    public delegate void AlarmHandler();
    public event AlarmHandler Ring;
    public void StartAlarm()
    {
        Console.WriteLine("Alarm Started...");

        if (Ring != null)
        {
            Ring();   // Raise the event
        }
    }
}
class User
{
    public void WakeUp()
    {
        Console.WriteLine("User: Wake up! Alarm is ringing.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Alarm alarm = new Alarm();
        User user = new User();
        alarm.Ring += user.WakeUp;
        alarm.StartAlarm();
        Console.ReadLine();
    }
}
