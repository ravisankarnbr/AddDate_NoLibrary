using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AddDate_NoLibrary.Business
{
    internal class DateManipulation
    {

        public static DateOnly AddDays(int day, int month, int year, int daysToAdd)
        {
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; // 12 months (Feb 28 days)

            if(daysToAdd> 0)
            {
               while(daysToAdd > 0) 
               {
                    if (Common.CheckIfLeapYear(year)) // Check If Leap year or not
                        daysInMonth[1] = 29;
                    else
                        daysInMonth[1] = 28;  
                    
                    day++;

                    if (day > daysInMonth[month - 1]) // check if greater than 30/ 31 days, then move to next month
                    {
                        month++; // Increment to next month

                        if (month > 12)
                        {
                            year++;
                            month = 1;
                        }
                        day = 1; // If month changes then start from the 1st day of month
                    }
                    daysToAdd--;
               }                
               
            }

            return new DateOnly(year, month, day);

        }
    }
}
