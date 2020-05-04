using System;
using System.Collections.Generic;
using System.Text;

namespace MyHRMUtil
{
    public class AnnualLeaveCalc
    {
        private DateTime baseDateTime;
        private DateTime baseYearFirstdate;
        private int daysofthisYear = 0;

        public AnnualLeaveCalc() : this(DateTime.Now)
        {

        }

        public AnnualLeaveCalc(DateTime dateTime)
        {
            baseDateTime = dateTime;
            baseYearFirstdate = new DateTime(baseDateTime.Year, 1, 1);
            daysofthisYear = (new DateTime(baseDateTime.Year +1, 1, 1) - baseYearFirstdate).Days;
        }

        public int GetQuota(DateTime Time2Count)
        {
            int quota = 0;
            int yearCount = baseDateTime.Year - Time2Count.Year;
            if (yearCount > 0)
            {
                //if (baseDateTime.Month < Time2Count.Month)
                //{
                //    yearCount -= 1;
                //}
                switch (yearCount)
                {
                    case 0:
                        quota = 0;
                        break;
                    case 1:
                        quota = 0;
                        if (baseDateTime.Month >= Time2Count.Month)
                        {
                            quota = (int)(0 * (1.0M * (Time2Count.DayOfYear-1) / daysofthisYear)) +
                                (int)(5 * (1.0M * (daysofthisYear - Time2Count.DayOfYear+1) / daysofthisYear));
                        }
                        break;
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        quota = 5;
                        break;
                    case 10:
                        quota = 5;
                        if (baseDateTime.Month >= Time2Count.Month)
                        {
                            quota = (int)(5 * (1.0M * (Time2Count.DayOfYear-1) / daysofthisYear)) +
                                (int)(10 * (1.0M * (daysofthisYear - Time2Count.DayOfYear+1) / daysofthisYear));
                        }
                        break;
                    case 11:
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                    case 16:
                    case 17:
                    case 18:
                    case 19:
                        quota = 10;
                        break;
                    case 20:
                        quota = 10;
                        if (baseDateTime.Month >= Time2Count.Month)
                        {
                            quota = (int)(10 * (1.0M * (Time2Count.DayOfYear-1) / daysofthisYear)) +
                                (int)(15 * (1.0M * (daysofthisYear - Time2Count.DayOfYear+1) / daysofthisYear));
                        }
                        break;
                    default:
                        quota = 15;
                        break;
                }
            }
            return quota;
        }
    }
}
