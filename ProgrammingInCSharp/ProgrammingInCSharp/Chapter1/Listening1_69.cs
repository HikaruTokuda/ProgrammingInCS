using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp
{
    class AlarmEventArgs : EventArgs
    {
        public string Location { get; set; }

        public AlarmEventArgs(string location)
        {
            Location = location;
        }
    }

    class Alarm4
    {
        // Delegate for the alarm event.
        public event EventHandler<AlarmEventArgs> OnAlarmRaised = delegate { };

        // Called to raise an alarm.
        // Does not provide any event arguments.
        public void RaiseAlarm(string location)
        {
            // Raise the alarm.
            // The event handler receivers a reference to thee alarm that is raising this event.
            OnAlarmRaised(this, new AlarmEventArgs(location));
        }
    }

    class Listening1_69
    {
        // Method that must run when the alarm is raised
        static void AlarmListener1(object source, AlarmEventArgs args)
        {
            Console.WriteLine("Alarm Listener 1 called.");
            Console.WriteLine("Alarm in {0}", args.Location);
        }

        // Method that must run when the alarm is raised
        static void AlarmListener2(object source, AlarmEventArgs args)
        {
            Console.WriteLine("Alarm Listener 2 called.");
            Console.WriteLine("Alarm in {0}", args.Location);
        }

        public static void Listening1_69Main()
        {
            // Create a new alarm
            Alarm4 alarm = new Alarm4();

            // Connect the two listener methods.
            alarm.OnAlarmRaised += AlarmListener1;
            alarm.OnAlarmRaised += AlarmListener2;

            // raise the alarm.
            alarm.RaiseAlarm("============ CALL BACK 1 ============");
            Console.WriteLine("Alarm raised.");

            alarm.OnAlarmRaised -= AlarmListener2;
            alarm.RaiseAlarm("============ CALL BACK 2 ============");
            Console.WriteLine("Alarm raised.");

            Console.ReadKey();
        }
    }
}
