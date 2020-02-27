using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebsiteQualityAndTesting.Functions
{
    public class Functions
    {
        public static int CalculateDriverAge(string DOB)
        {
            DateTime driverDateOfBirth = DateTime.Parse(DOB);
            DateTime currentDate = DateTime.Now;
            return (currentDate.Year - driverDateOfBirth.Year - 1) +
            (((currentDate.Month > driverDateOfBirth.Month) ||
            ((currentDate.Month == driverDateOfBirth.Month) && (currentDate.Day >= driverDateOfBirth.Day))) ? 1 : 0);
        }
        public static double BasicPremium(string coverType)
        {
            return coverType == "Comprehensive" ? 0.04 : 0.025;
        }
        public static void CheckPenaltyPoints(int penaltyPoints, ref double premium, ref bool quotePossible)
        {
            if (1 <= penaltyPoints && penaltyPoints <= 4)
                premium += 100;
            else if (5 <= penaltyPoints && penaltyPoints <= 7)
                premium += 200;
            else if (8 <= penaltyPoints && penaltyPoints <= 10)
                premium += 300;
            else if (11 <= penaltyPoints && penaltyPoints <= 12)
                premium += 400;
            else if (penaltyPoints > 12)
                quotePossible = false;
        }
    }
}