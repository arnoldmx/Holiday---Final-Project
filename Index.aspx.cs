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
        protected void btnShow2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            lblDesc2.Text = "Problem 2";
        }

        protected void btnRun2_Click(object sender, EventArgs e)
        {
            lblOutput2.Text = "Result: [Placeholder]";
            lblCode2.Text = "<pre class='bg-dark text-white p-3 rounded' style='overflow-x: auto;'><code>// Problem 2 code</code></pre>";
        }

        protected void btnClear2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            lblDesc2.Text = "";
            lblOutput2.Text = "";
            lblCode2.Text = "";
        }

        // Problem 3
        protected void btnShow3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            lblDesc3.Text = "Problem 3";
        }

        protected void btnRun3_Click(object sender, EventArgs e)
        {
            lblOutput3.Text = "Result: [Placeholder]";
            lblCode3.Text = "<pre class='bg-dark text-white p-3 rounded' style='overflow-x: auto;'><code>// Problem 3 code</code></pre>";
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