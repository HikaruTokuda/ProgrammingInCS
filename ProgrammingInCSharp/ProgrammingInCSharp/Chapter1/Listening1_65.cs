using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Subscribers bind to a publisher by using the += operator.
/// It means "add this behavior to the ones for delegate.".
/// The methods in a delegate are not guaranteed to be called in the order that they were added
/// to the delegate.
/// </summary>
namespace ProgrammingInCSharp
{
    class Alarm
    {
        // Delegate for the alarm event
        public Action OnAlarmRaised { get; set; }

        // Called to raise an alarm
        public void RaiseAlarm()
        {
            // Only raise the alarm if someone has subscribed.
            OnAlarmRaised?.Invoke();
            /*
            if (OnAlarmRaised != null)
            {
                OnAlarmRaised();
            }
            */
        }
    }

    class Listening1_65
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

        public static void Listening1_65Main()
        {
            // Create a new alarm
            Alarm alarm = new Alarm();

            // Connect the two listener methods.
            alarm.OnAlarmRaised += AlarmListener1;
            alarm.OnAlarmRaised += AlarmListener2;

            // raise the alarm.
            alarm.RaiseAlarm();
            Console.WriteLine("Alarm raised.");

            Console.ReadKey();
        }
    }
}
