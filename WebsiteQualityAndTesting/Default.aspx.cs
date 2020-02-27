using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebsiteQualityAndTesting.Functions;

namespace WebsiteQualityAndTesting
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click2(object sender, EventArgs e)
        {
            int driverAge = Functions.Functions.CalculateDriverAge(Request.Form.Get("dateOfBirth"));
            if (driverAge < 18)
                Label1.Text = "No Quote Possible";
            else
            {
                double premium = Functions.Functions.BasicPremium(Request.Form.Get("coverType")) *
                    Convert.ToDouble(Request.Form.Get("vehicleValue"));
                if (driverAge <= 25)
                {
                    premium += premium * 0.10;
                }
                bool quotePossible = true;
                Functions.Functions.CheckPenaltyPoints(Convert.ToInt32(Request.Form.Get("penaltyPoints")),
                    premium: ref premium, quotePossible: ref quotePossible);
                if (!quotePossible)
                {
                    Label1.Text = "No Quote Possible";
                }
                else
                {
                    Label1.Text = premium.ToString();
                }

            }
        }
    }
}