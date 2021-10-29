using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWise.Common
{
    public class LocalDateTime
    {
        public static DateTime GetCurrentDateTime()
        {
            DateTime ServerTime = DateTime.Now;
            DateTime LocalTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(ServerTime, TimeZoneInfo.Local.Id, "India Standard Time");
            return LocalTime;
        }
    }
}
