<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="ShowClasses.aspx.cs" Inherits="Assignment2ab.ShowClasses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link rel="stylesheet" type="text/css" href="stye_layout.css" />
      <div id="classes" runat="server">
        <h2>Details for Classes:</h2>
        <span>CLASS CODE:</span> 
        <span id="class_code" runat="server"></span><br />
        <span>START DATE:</span>
        <span id="start_date" runat="server"></span><br />
        <span>FINISH DATE:</span> 
        <span id="finish_date" runat="server"></span><br />
        <span>CLASS NAME:</span>
        <span id="class_name" runat="server"></span><br />   
    <div>
        <asp:Button class="button1" runat="server" Text="UPDATE" />
    </div>
    </div>
</asp:Content>
