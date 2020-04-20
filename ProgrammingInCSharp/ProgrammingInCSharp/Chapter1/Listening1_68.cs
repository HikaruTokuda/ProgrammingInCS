using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The Eventhandler delegate refers to a subscriber method that will accept two arguments.
/// The first argumentis a reference to the object raising the event.
/// The second argument is a reference to an object of type EventArgs that provides information about the event.
/// 
/// </summary>
namespace ProgrammingInCSharp
{
    class Alarm3
    {
        // Delegate for the alarm event.
        public event EventHandler OnAlarmRaised = delegate { };

        // Called to raise an alarm.
        // Does not provide any event arguments.
        public void RaiseAlarm()
        {
            // Raise the alarm.
            // The event handler receivers a reference to thee alarm that is raising this event.
            OnAlarmRaised(this, EventArgs.Empty);
        }
    }

    class Listening1_68
    {
        // Method that must run when the alarm is raised
        static void AlarmListener1(object sender, EventArgs e)
        {
            Console.WriteLine("Alarm Listener 1 called.");
        }

        // Method that must run when the alarm is raised
        static void AlarmListener2(object sender, EventArgs e)
        {
            Console.WriteLine("Alarm Listener 2 called.");
        }

        public static void Listening1_68Main()
        {
            // Create a new alarm
            Alarm3 alarm = new Alarm3();

            // Connect the two listener methods.
            alarm.OnAlarmRaised += AlarmListener1;
            alarm.OnAlarmRaised += AlarmListener2;

            // raise the alarm.
            alarm.RaiseAlarm();
            Console.WriteLine("Alarm raised.");

            alarm.OnAlarmRaised -= AlarmListener2;
            alarm.RaiseAlarm();
            Console.WriteLine("Alarm raised.");

            Console.ReadKey();
        }
    }
}
