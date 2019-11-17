<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="ShowStudent.aspx.cs" Inherits="Assignment2ab.ShowStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="stye_layout.css" />
      <div id="student" runat="server">
        <h2>Details for Students:</h2>
        <span>STUDENT FIRST NAME:</span> 
        <span id="student_fname" runat="server"></span><br />
        <span>STUDENT LAST NAME:</span>
        <span id="student_lname" runat="server"></span><br />
        <span>STUDENT NUMBER:</span> 
        <span id="student_number" runat="server"></span><br />
        <span> ENROLLMENT DATE:</span>
        <span id="enrolment_date" runat="server"></span><br />   
    <div>
        <asp:Button class="button1" runat="server" Text="UPDATE" />
    </div>
    </div>
</asp:Content>
