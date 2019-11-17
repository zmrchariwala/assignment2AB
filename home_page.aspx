<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="home_page.aspx.cs" Inherits="Assignment2ab.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="stye_layout.css" />

    <div>
        <asp:Button class="button" runat="server" Text="STUDENTS" PostBackUrl="~/student_list.aspx" />
    </div>
     <div >
        <asp:Button class="button" runat="server" Text="TEACHERS" PostBackUrl="~/teacher_list.aspx" />
    </div>
     <div >
        <asp:Button class="button" runat="server" Text="CLASSES" PostBackUrl="~/classes_list.aspx" />
    </div>
</asp:Content>
