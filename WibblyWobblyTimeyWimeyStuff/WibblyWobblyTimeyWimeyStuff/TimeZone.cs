using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Zones
{
    public class TimeZone
    {


        public static string zone;




        private static Dictionary<string, int> zones = new Dictionary<string, int>()
            {
                {"ET",3},
	            {"CT", 2},
	            {"MT", 1},
	            {"PT", 0}
            };

        static DateTime now = DateTime.Now;


        static int value = zones[zone];

        static TimeSpan duration = new TimeSpan(value, 0, 0);
        static DateTime timezone1 = now.Add(duration);

        static public int currentMinute = timezone1.Minute;
        static public int currentHour = timezone1.Hour;
        static public int currentDay = timezone1.Day;
        static public DayOfWeek currentDayofWeek = timezone1.DayOfWeek;

        static List<int> time = new List<int>(new int[] { currentMinute, currentHour, currentDay });

        static List<int> RetrieveTime()
        {
            return time;
        }

        static DayOfWeek RetrieveDayOfWeek()
        {
            return currentDayofWeek;
        }

    }
}
