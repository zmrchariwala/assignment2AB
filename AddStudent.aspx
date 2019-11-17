<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="Assignment2ab.AddStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link rel="stylesheet" type="text/css" href="stye_layout.css" />
     <div id="student" runat="server">
        <h2>Details for Students:</h2>
        <span>STUDENT FIRST NAME:</span> 
        <asp:TextBox runat="server" ID="student_fname" ></asp:TextBox><br />
        <span>STUDENT LAST NAME:</span>
        <asp:TextBox runat="server" ID="student_lname" ></asp:TextBox><br />
        <span>STUDENT NUMBER:</span> 
        <asp:TextBox runat="server" ID="student_number" ></asp:TextBox><br />
        <span> ENROLLMENT DATE:</span>
        <asp:TextBox runat="server" ID="enrolment_date" ></asp:TextBox><br />   
    <div>
        <asp:Button class="button1" runat="server" Text="ADD" />
    </div>
    </div>
</asp:Content>
