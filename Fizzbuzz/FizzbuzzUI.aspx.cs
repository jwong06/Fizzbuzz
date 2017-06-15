using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fizzbuzz
{
    public partial class Fizzbuzz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                validNum.Text = "";
                validTxt.Text = "";

                int num = Convert.ToInt32(this.txtNum.Text);
                bool fizz = num % 3 == 0;
                bool buzz = num % 5 == 0;
                bool neither = (num % 3 != 0) && (num % 5 != 0);

                if (fizz && buzz || neither)
                {
                    lblFizzBuzz.Text = "";
                }
                else if (fizz)
                {
                    lblFizzBuzz.Text = "Fizz";
                }
                else if (buzz)
                {
                    lblFizzBuzz.Text = "Buzz";
                }
            }
        }
    }
}

