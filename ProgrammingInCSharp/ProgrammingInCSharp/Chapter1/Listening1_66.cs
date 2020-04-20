using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp
{
    class Listening1_66
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

        public static void Listening1_66Main()
        {
            // Create a new alarm
            Alarm alarm = new Alarm();

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
