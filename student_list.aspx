<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="student_list.aspx.cs" Inherits="Assignment2ab.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="stye_layout.css" />
    <h2>STUDENTS</h2>
    <div id="student_nav">
        <asp:label for="student_search" runat="server">Search:</asp:label>
        <asp:TextBox ID="student_search" runat="server"></asp:TextBox>
          <asp:Button Class="button2" runat="server" text="SEARCH"/>
          <!--<asp:Button Class="button2" runat="server" text="EDIT"/>
          <asp:Button Class="button2" runat="server" text="DELETE"/>
          <asp:Button Class="button2" runat="server" text="ADD"/>-->
        
    </div>
    <div class="table" runat="server">
        <div class="listitem">
            <div class="cul1">FIRST NAME</div>
            <div class="cul2">LAST NAME</div>
            <div class="cul2">STUDENT NUMBER</div>
            <div class="cul2">ENROLMENT DATE</div>
        </div>
        <div id="students_result" runat="server">

        </div>
    </div>
</asp:Content>
