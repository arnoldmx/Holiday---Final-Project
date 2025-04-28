using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Holiday___Final_Project
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
            }
        }

        protected void btnShow1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            lblDesc1.Text = "Given n balloons with values, return maximum coins by bursting them optimally. Example: [3,1,5,8]";
        }

        protected void btnRun1_Click(object sender, EventArgs e)
        {
            McGorry solver = new McGorry();
            int[] testCase = new int[] { 3, 1, 5, 8 };
            int result = solver.MaxCoins(testCase);
            lblOutput1.Text = "Result: " + result;
        }

        //  Problem 2 
        protected void btnShow2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            lblDesc2.Text = "Problem 2 description goes here...";
        }

        protected void btnRun2_Click(object sender, EventArgs e)
        {

            lblOutput2.Text = "Result: [Placeholder]";
        }

        // Problem 3 
        protected void btnShow3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            lblDesc3.Text = "Problem 3 description goes here...";
        }

        protected void btnRun3_Click(object sender, EventArgs e)
        {

            lblOutput3.Text = "Result: [Placeholder]";
        }
    }
}