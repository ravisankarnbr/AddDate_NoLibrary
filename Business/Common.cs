using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDate_NoLibrary.Business
{
    internal class Common
    {
        public static bool CheckIfLeapYear(int year)
        {
            try
            {
                if (year < 1 || year > 9999)
                {
                    throw new ArgumentOutOfRangeException("year", "ArgumentOutOfRange_Year");
                }
                return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
            }
            catch(Exception ex)
            {

            }
            return false;
        }
    }
}
