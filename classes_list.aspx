<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="classes_list.aspx.cs" Inherits="Assignment2ab.classes_list" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <link rel="stylesheet" type="text/css" href="stye_layout.css" />
    <h2>CLASSES</h2>
    <div id="teacher_nav">
        <asp:label for="classes_search" runat="server"> Teacher Search:</asp:label>
        <asp:TextBox ID="classes_search" runat="server"></asp:TextBox>
           <asp:Button Class="button2" runat="server" text="SEARCH"/>
           <asp:Button Class="button2" runat="server" text="EDIT"/>
           <asp:Button Class="button2" runat="server" text="DELETE"/>
           <asp:Button Class="button2" runat="server" text="ADD"/>
        
    </div>
    <div class="table" runat="server">
        <div class="listitem">
            <div class="cul1">CLASS CODE</div>
            <div class="cul1">START DATE</div>
            <div class="cul1">FINISH DATE</div>
            <div class="cul2">CLASS NAME</div>
            
        </div>
      
    </div>
</asp:Content>
