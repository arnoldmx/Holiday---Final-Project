
/*

 **File Name: Index.aspx.cs

* Name: Jackson Wiley, Max Arnold, Keegean McGorry
* email:  wileyjn @mail.uc.edu, 
*Assignment Number: Final Project
*Due Date: 4 / 29 / 2025
* Course #/Section:   Web Dev with .net 001
* Semester / Year:   Spring 2025
* Brief Description of the assignment:  Create a web page where we all collaborate through git hub 
* and have a button for each of our problems we idependently solve from LeetCode.

* Brief Description of what this module does. This module contains code that runs when our buttons are pressed
* on the index. It links our individual problems to our individual cs files to run our code.
* 
* Citations: https://leetcode.com/problems/bus-routes/description/ , https://chatgpt.com, https://github.com/jwiley21/wileyjn_Assignment10, https://www.w3schools.com/cs/cs_arrays.php
*Anything else that's relevant:
 */

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
            lblDesc2.Text =
                "You are given an array of stops where each array is a new bus. "
             +"Find the minimum number of buses needed to go "
             +"from a source to target, or –1 if impossible."
             + "Example 1: routes= [[1,2,7],[3,6,7]], source=1, target=6 "
             + "Example 2: routes=[[7,12],[4,5,15],[6],[15,19],[9,12,13]], "
             + "source=15, target=12 ";
        }

        protected void btnRun2_Click(object sender, EventArgs e)
        {
            // ----- Example 1 -----
            int[][] routes1 = { new[] { 1, 2, 7 }, new[] { 3, 6, 7 } };
            int answer1 = Wiley.NumBusesToDestination(routes1, source: 1, target: 6);

            // ----- Example 2 -----
            int[][] routes2 =
            {
        new[] { 7, 12 },
        new[] { 4, 5, 15 },
        new[] { 6 },
        new[] { 15, 19 },
        new[] { 9, 12, 13 }
    };
            int answer2 = Wiley.NumBusesToDestination(routes2, source: 15, target: 12);

            lblOutput2.Text =
                $"Example 1 result: {answer1}<br/>"
              + $"Example 2 result: {answer2}";
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