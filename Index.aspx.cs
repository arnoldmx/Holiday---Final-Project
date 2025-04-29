
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

        // Problem 1 
        protected void btnShow1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            lblDesc1.Text = "You are given n balloons, indexed from 0 to n - 1. Each balloon is painted with a number on it represented by an array nums. You are asked to burst all the balloons." +
                "If you burst the ith balloon, you will get nums[i - 1] * nums[i] * nums[i + 1] coins. If i - 1 or i + 1 goes out of bounds of the array, then treat it as if there is a balloon with a 1 painted on it.  Test Case [3, 1, 5, 8]";

        }

        protected void btnRun1_Click(object sender, EventArgs e)
        {
            McGorry solver = new McGorry();
            int[] testCase = new int[] { 3, 1, 5, 8 };
            int result = solver.MaxCoins(testCase);
            lblOutput1.Text = "Result: " + result;

            lblCode1.Text = "";
        }

        protected void btnClear1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            lblDesc1.Text = "";
            lblOutput1.Text = "";
            lblCode1.Text = "";
        }

        // Problem 2

        // ---------- Problem 2 ----------
        protected void btnShow2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;

            // Multi-line description with HTML <br /> breaks
            lblDesc2.Text = string.Join(Environment.NewLine,
                "You are given an array of stop with each array being a diffrent set of stops for a diffrent bus.",
                "Starting at stop source and ending at target, return the minimum number of buses needed",
                "to reach target, or –1 if it is impossible.",
                "",
                "Example 1:",
                "routes = [[1,2,7],[3,6,7]], source = 1, target = 6",
                "Example 2:",
                "routes = [[7,12],[4,5,15],[6],[15,19],[9,12,13]], source = 15, target = 12"
            ).Replace(Environment.NewLine, "<br />");
        }

        protected void btnRun2_Click(object sender, EventArgs e)
        {
            // ---------- Example 1 ----------
            int[][] routes1 = { new[] { 1, 2, 7 }, new[] { 3, 6, 7 } };
            int ans1 = Wiley.NumBusesToDestination(routes1, 1, 6);

            // ---------- Example 2 ----------
            int[][] routes2 =
            {
        new[] {  7, 12 },
        new[] {  4,  5, 15 },
        new[] {  6 },
        new[] { 15, 19 },
        new[] {  9, 12, 13 }
    };
            int ans2 = Wiley.NumBusesToDestination(routes2, 15, 12);

            lblOutput2.Text = $"Example 1 result: {ans1}<br />Example 2 result: {ans2}";

            // Show solver source 
            lblCode2.Text = "";
        
        }

        protected void btnClear2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            lblDesc2.Text = string.Empty;
            lblOutput2.Text = string.Empty;
            lblCode2.Text = string.Empty;
        }


        // Problem 3
        protected void btnShow3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            lblDesc3.Text = "Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays. Test Case nums1 = [1, 3], nums2 = [2]:";
        }

        protected void btnRun3_Click(object sender, EventArgs e)
        {
            Arnold.Solution solver = new Arnold.Solution();
            int[] nums1 = new int[] { 1, 3 };
            int[] nums2 = new int[] { 2 };
            double result = solver.FindMedianSortedArrays(nums1, nums2);
            lblOutput3.Text = "Result: " + result;

            lblCode3.Text = "";
        }

        protected void btnClear3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            lblDesc3.Text = "";
            lblOutput3.Text = "";
            lblCode3.Text = "";
        }
    }
}