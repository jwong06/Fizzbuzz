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
            int num = Convert.ToInt32(this.txtNum.Text);

            if(txtNum.Text == "")
            {
                lblFizzBuzz.Text = "Please enter a number into the textbox";
            }
            else
            {
                if (num % 3 == 0)
                {
                    lblFizzBuzz.Text("Fizz");
                }
                if (num % 5 == 0)
                {
                    lblFizzBuzz.Text("Buzz");
                }
                else if (num % 3 == 0 && num % 5 == 0)
                {
                    lblFizzBuzz.Text = "";
                }
            }
        }
    }
}