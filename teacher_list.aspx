<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="teacher_list.aspx.cs" Inherits="Assignment2ab.teacher_list" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <link rel="stylesheet" type="text/css" href="stye_layout.css" />
    <h2>TEACHERS</h2>
    <div id="teacher_nav">
        <asp:label for="teacher_search" runat="server"> Teacher Search:</asp:label>
        <asp:TextBox ID="teacher_search" runat="server"></asp:TextBox>
          <asp:Button Class="button2" runat="server" text="SEARCH"/>
          <!-- <asp:Button Class="button2" runat="server" text="EDIT"/>
           <asp:Button Class="button2" runat="server" text="DELETE"/>
          <asp:Button Class="button2" runat="server" text="ADD"/>-->
        
    </div>
    <div class="table" runat="server">
        <div class="listitem">
            <div class="cul1">TEACHER FIRST NAME</div>
            <div class="cul2">TEACHER LAST NAME</div>
            <div class="cul2">EMP NUMBER</div>
            <div class="cul2">HIRE DATE</div>
            <div class="cul2">SALARY</div>
            
        </div>
        <div id="teacher_result" runat="server">

        </div>
    </div>
</asp:Content>
