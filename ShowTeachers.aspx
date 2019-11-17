<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="ShowTeachers.aspx.cs" Inherits="Assignment2ab.ShowTeachers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link rel="stylesheet" type="text/css" href="stye_layout.css" />
      <div id="teacher" runat="server">
        <h2>Details for Teachers :</h2>
        <span>TEACHER FIRST NAME:</span> 
        <span id="teacher_fname" runat="server"></span><br />
        <span>TEACHER LAST NAME:</span> 
        <span id="teacher_lname" runat="server"></span><br />
        <span>HIRE DATE:</span>
        <span id="hire_date" runat="server"></span><br />
        <span>EMP NUMBER:</span> 
        <span id="employee_number" runat="server"></span><br />
        <span> SALARY:</span>
        <span id="salary_amount" runat="server"></span><br />   
    <div>
        <asp:Button class="button1" runat="server" Text="UPDATE" />
    </div>
    </div>
</asp:Content>
