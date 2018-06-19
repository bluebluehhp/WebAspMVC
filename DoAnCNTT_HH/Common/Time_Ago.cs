using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnCNTT_HH.Common
{
    public class Time_Ago
    {
        public static string TimeAgo(DateTime dateTime)
        {
            string result = string.Empty;
            var timeSpan = DateTime.Now.Subtract(dateTime);

            if (timeSpan <= TimeSpan.FromSeconds(60))
            {
                result = string.Format("{0} Giây trước", timeSpan.Seconds);
            }
            else if (timeSpan <= TimeSpan.FromMinutes(60))
            {
                result = timeSpan.Minutes > 1 ?
                    String.Format("{0} Phút trước", timeSpan.Minutes) :
                    "1 Phút trước";
            }
            else if (timeSpan <= TimeSpan.FromHours(24))
            {
                result = timeSpan.Hours > 1 ?
                    String.Format("{0} Giờ trước", timeSpan.Hours) :
                    "1 Giờ trước";
            }
            else if (timeSpan <= TimeSpan.FromDays(30))
            {
                result = timeSpan.Days > 1 ?
                    String.Format("{0} Ngày trước", timeSpan.Days) :
                    "Hôm qua";
            }
            else if (timeSpan <= TimeSpan.FromDays(365))
            {
                result = timeSpan.Days > 30 ?
                    String.Format("{0} Tháng trước", timeSpan.Days / 30) :
                    "1 Tháng trước";
            }
            else
            {
                result = timeSpan.Days > 365 ?
                    String.Format("{0} Năm trước", timeSpan.Days / 365) :
                    "1 Năm trước";
            }

            return result;
        }

     
    }

    
}