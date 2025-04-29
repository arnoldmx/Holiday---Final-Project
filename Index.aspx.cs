
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

            lblCode1.Text = @"<pre class='bg-dark text-white p-3 rounded' style='overflow-x: auto;'><code>
public int MaxCoins(int[] nums)
{
    int n = nums.Length;
    int[] newNums = new int[n + 2];
    newNums[0] = newNums[n + 1] = 1;
    for (int i = 0; i &lt; n; i++) newNums[i + 1] = nums[i];

    int[,] dp = new int[n + 2, n + 2];

    for (int len = 1; len &lt;= n; len++)
    {
        for (int left = 1; left &lt;= n - len + 1; left++)
        {
            int right = left + len - 1;
            for (int i = left; i &lt;= right; i++)
            {
                dp[left, right] = Math.Max(dp[left, right],
                    newNums[left - 1] * newNums[i] * newNums[right + 1] +
                    dp[left, i - 1] + dp[i + 1, right]);
            }
        }
    }

    return dp[1, n];
}
</code></pre>";
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
            lblCode2.Text =
        @"<pre class='bg-dark text-white p-3 rounded' style='overflow-x:auto;'><code>
public static int NumBusesToDestination(int[][] routes, int source, int target)
{
    if (source == target) return 0;
    var stopToBuses = new Dictionary&lt;int, List&lt;int&gt;&gt;();
    for (int bus = 0; bus &lt; routes.Length; bus++)
        foreach (int stop in routes[bus])
            (stopToBuses.TryGetValue(stop, out var list) ? list : (stopToBuses[stop] = new List&lt;int&gt;()))
            .Add(bus);

    var visitedStops = new HashSet&lt;int&gt; { source };
    var visitedBuses = new HashSet&lt;int&gt;();
    var q = new Queue&lt;int&gt;();
    q.Enqueue(source);
    int busesTaken = 0;

    while (q.Count &gt; 0)
    {
        int level = q.Count;
        busesTaken++;
        for (int i = 0; i &lt; level; i++)
        {
            int cur = q.Dequeue();
            if (!stopToBuses.TryGetValue(cur, out var buses)) continue;
            foreach (int bus in buses)
            {
                if (!visitedBuses.Add(bus)) continue;
                foreach (int next in routes[bus])
                {
                    if (next == target) return busesTaken;
                    if (visitedStops.Add(next)) q.Enqueue(next);
                }
            }
        }
    }
    return -1;
}
</code></pre>";
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

            lblCode3.Text = @"<pre class='bg-dark text-white p-3 rounded' style='overflow-x: auto;'><code>
public class Arnold
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
                return FindMedianSortedArrays(nums2, nums1);

            int m = nums1.Length;
            int n = nums2.Length;
            int low = 0, high = m;

            while (low <= high)
            {
                int partitionX = (low + high) / 2;
                int partitionY = (m + n + 1) / 2 - partitionX;

                int maxX = (partitionX == 0) ? int.MinValue : nums1[partitionX - 1];
                int minX = (partitionX == m) ? int.MaxValue : nums1[partitionX];
                int maxY = (partitionY == 0) ? int.MinValue : nums2[partitionY - 1];
                int minY = (partitionY == n) ? int.MaxValue : nums2[partitionY];

                if (maxX <= minY && maxY <= minX)
                {
                    if ((m + n) % 2 == 0)
                        return (Math.Max(maxX, maxY) + Math.Min(minX, minY)) / 2.0;
                    else
                        return Math.Max(maxX, maxY);
                }
                else if (maxX > minY)
                {
                    high = partitionX - 1;
                }
                else
                {
                    low = partitionX + 1;
                }
            }

            throw new ArgumentException(""Input arrays are not sorted."");
        }
    }
}
</code></pre>";
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