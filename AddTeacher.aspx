<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="AddTeacher.aspx.cs" Inherits="Assignment2ab.AddTeacher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link rel="stylesheet" type="text/css" href="stye_layout.css" />
     <div id="teacher" runat="server">
        <h2>Details for Teachers:</h2>
        <span>TEACHER FIRST NAME:</span> 
        <asp:TextBox runat="server" ID="teacher_fname" ></asp:TextBox><br />
        <span>TEACHER LAST NAME:</span>
        <asp:TextBox runat="server" ID="teacher_lname" ></asp:TextBox><br />
        <span>HIRE DATE:</span> 
        <asp:TextBox runat="server" ID="hire_date" ></asp:TextBox><br />
        <span> EMP NUMBER:</span>
        <asp:TextBox runat="server" ID="employee_number" ></asp:TextBox><br />
        <span> SALARY:</span>
        <asp:TextBox runat="server" ID="salary_amount" ></asp:TextBox><br />
    <div>
        <asp:Button class="button1" runat="server" Text="ADD" />
    </div>
    </div>
</asp:Content>
