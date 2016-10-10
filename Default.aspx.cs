using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_019
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            int phone = int.Parse(phoneTextBox.Text);
            int ss = int.Parse(ssTextBox.Text);
            

            String result = String.Format("Thank you {0}, for your business<br>" +
                "Your phone number is {1:(000)000-0000}<br>" +
                // "Your phone number is {1}<br>" +
                "Your social security number is {2:000-00-0000}<br>" +
                "The loan date you picked is {3:MMM d, yyyy}<br>" +
                "The amount you want to borrow is: {4:C}",
                nameTextBox.Text,
                phone,
                ss,
                loanDateCalendar.SelectedDate,
                salaryTextBox.Text);

            if (result == "")
            {
                resultLabel.Text = String.Format("Please enter your information");
            }
            else
            {
                resultLabel.Text = result;
            }
            
            
        }
    }
}