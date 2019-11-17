<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="UpdateClasses.aspx.cs" Inherits="Assignment2ab.UpdateClasses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="stye_layout.css" />
     <div id="classes" runat="server">
        <h2>Details for Classes:</h2>
        <span>CLASS CODE:</span> 
        <asp:TextBox runat="server" ID="class_code" ></asp:TextBox><br />
        <span>START DATE:</span>
        <asp:TextBox runat="server" ID="start_date" ></asp:TextBox><br />
        <span>FINISH DATE:</span> 
        <asp:TextBox runat="server" ID="finish_date" ></asp:TextBox><br />
        <span> CLASS NAME:</span>
        <asp:TextBox runat="server" ID="class_name" ></asp:TextBox><br />   
    <div>
        <asp:Button class="button1" runat="server" Text="UPDATE" />
    </div>
    </div>
</asp:Content>
