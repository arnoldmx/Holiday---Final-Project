<!--
    
 ** File Name: Index.aspx

* Name: Jackson Wiley, Max Arnold, Keegean McGorry
* email:  wileyjn@mail.uc.edu, 
* Assignment Number: Final Project
* Due Date:   4/29/2025
* Course #/Section:   Web Dev with .net 001
* Semester/Year:   Spring 2025
* Brief Description of the assignment:  Create a web page where we all collaborate through git hub 
* and have a button for each of our problems we idependently solve from LeetCode.

* Brief Description of what this module does. This module is the index for our project. it has each of our problems 
    and will run the code on index.aspx.cs when clicked. This file is used for the formatting
* 
* Citations: 
* Anything else that's relevant:

    -->






<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Holiday___Final_Project.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 100%; display: flex; justify-content: center; margin-top: 40px; margin-bottom: 40px;">
    <div style="text-align: center;">
        <h1 class="display-4">Our LeetCode Problems</h1>
        <h3 class="text-muted">Team Holiday</h3>
        <p class="lead">Max Arnold, Keegean McGorry, Jackson Wiley</p>
    </div>
</div>
<div class="container mt-5">
    <div class="row">

        <div class="col-md-4 mb-4">
            <div class="card text-center h-100">
                <div class="card-body">
                    <h5 class="card-title">Burst Balloons</h5>
                    <asp:Button ID="btnShow1" runat="server" Text="View Problem" CssClass="btn btn-outline-primary" OnClick="btnShow1_Click" />
                    <asp:Panel ID="panel1" runat="server" Visible="false" CssClass="mt-3">
                        <asp:Label ID="lblDesc1" runat="server" Text=""></asp:Label><br />
                        <asp:Button ID="btnRun1" runat="server" Text="Run" CssClass="btn btn-success mt-2" OnClick="btnRun1_Click" />
                        <asp:Label ID="lblOutput1" runat="server" CssClass="d-block mt-2"></asp:Label>
                    </asp:Panel>
                </div>
            </div>
        </div>

        <div class="col-md-4 mb-4">
            <div class="card text-center h-100">
                <div class="card-body">
                    <h5 class="card-title">Bus Problem</h5>
                    <asp:Button ID="btnShow2" runat="server" Text="View Problem" CssClass="btn btn-outline-primary" OnClick="btnShow2_Click" />
                    <asp:Panel ID="panel2" runat="server" Visible="false" CssClass="mt-3">
                        <asp:Label ID="lblDesc2" runat="server" Text=""></asp:Label><br />
                        <asp:Button ID="btnRun2" runat="server" Text="Run" CssClass="btn btn-success mt-2" OnClick="btnRun2_Click" />
                        <asp:Label ID="lblOutput2" runat="server" CssClass="d-block mt-2"></asp:Label>
                    </asp:Panel>
                </div>
            </div>
        </div>

        <div class="col-md-4 mb-4">
            <div class="card text-center h-100">
                <div class="card-body">
                    <h5 class="card-title">Problem 3</h5>
                    <asp:Button ID="btnShow3" runat="server" Text="View Problem" CssClass="btn btn-outline-primary" OnClick="btnShow3_Click" />
                    <asp:Panel ID="panel3" runat="server" Visible="false" CssClass="mt-3">
                        <asp:Label ID="lblDesc3" runat="server" Text=""></asp:Label><br />
                        <asp:Button ID="btnRun3" runat="server" Text="Run" CssClass="btn btn-success mt-2" OnClick="btnRun3_Click" />
                        <asp:Label ID="lblOutput3" runat="server" CssClass="d-block mt-2"></asp:Label>
                    </asp:Panel>
                </div>
            </div>
        </div>

    </div>
</div>


    </form>
</body>
</html>
