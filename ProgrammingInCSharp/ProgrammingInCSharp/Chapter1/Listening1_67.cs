using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The Alarm objects that we've created is not particularly secure. Then OnAlarmRaised delegate has been made public
/// so that subscribers can connect to it.
/// However, this means that code external to the Alarm object can raise the alarm by directly calling the
/// OnAlarmRaised delegate.
/// </summary>
namespace ProgrammingInCSharp
{
    class Alarm2
    {
        // Delegate for the alarm event
        public event Action OnAlarmRaised = delegate { };

        // Called to raise an alarm
        public void RaiseAlarm()
        {
            OnAlarmRaised();
        }
    }

    class Listening1_67
    {
        // Method that must run when the alarm is raised
        static void AlarmListener1()
        {
            Console.WriteLine("Alarm Listener 1 called.");
        }

        // Method that must run when the alarm is raised
        static void AlarmListener2()
        {
            Console.WriteLine("Alarm Listener 2 called.");
        }

        public static void Listening1_67Main()
        {
            // Create a new alarm
            Alarm2 alarm = new Alarm2();

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
