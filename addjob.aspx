<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addjob.aspx.cs" Inherits="jobportel1.addjob" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <title>Add Job</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1 class="text-center mb-5">Add Job</h1>
            <div class="form-group">
                <label for="jobTitle">Job Title</label>
                <asp:TextBox ID="title" CssClass="form-control" runat="server" placeholder="Enter job title"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="jobDescription">Job Description</label>
                <asp:TextBox ID="Description" CssClass="form-control" runat="server" TextMode="MultiLine" Rows="5"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="jobLocation">Job Location</label>
                <asp:TextBox ID="Location" CssClass="form-control" runat="server" placeholder="Enter job location"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="jobType">Job Type</label>
                <asp:DropDownList ID="jtp" CssClass="form-control" runat="server">
                    <asp:ListItem Text="Select a job type"></asp:ListItem>
                    <asp:ListItem Text="Full-time"></asp:ListItem>
                    <asp:ListItem Text="Part-time"></asp:ListItem>
                    <asp:ListItem Text="Contract"></asp:ListItem>
                    <asp:ListItem Text="Temporary"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="jobSalary">Job Salary</label>
                <asp:TextBox ID="Salary" CssClass="form-control" runat="server" placeholder="Enter job salary"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="email">Email Id</label>
                <asp:TextBox ID="mail" CssClass="form-control" runat="server" placeholder="Enter job salary"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="compnyname">Compny Name</label>
                <asp:TextBox ID="compnyname" CssClass="form-control" runat="server" placeholder="Enter job salary"></asp:TextBox>
            </div>
            
            <asp:Button ID="addjobbtn" CssClass="btn btn-primary" runat="server" Text="Add job" OnClick="addjobbtn_Click" />
        </div>
    </form>
</body>
</html>
