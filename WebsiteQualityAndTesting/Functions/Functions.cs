using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteQualityAndTesting.Functions
{
    public class Functions
    {
        public static int CalculateDriverAge(string DOB)
        {
            DateTime driverDateOfBirth = DateTime.Parse(DOB);
            DateTime currentDate = DateTime.Now;
            int age = 0;
            age = DateTime.Now.Year - driverDateOfBirth.Year;
            if (DateTime.Now.DayOfYear < driverDateOfBirth.DayOfYear)
                age = age - 1;

            return age;
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

        public static void HandleDriverAge(int driverAge, ref double premium, ref bool quotePossible)
        {
            if (driverAge < 18)
                quotePossible = false;
            else if (driverAge < 25)
                premium += premium * 0.10;
        }


    }
}