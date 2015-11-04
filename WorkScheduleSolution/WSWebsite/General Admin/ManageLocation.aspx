<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ManageLocation.aspx.cs" Inherits="General_Admin_ManageLocation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p> <h1> Manage Location</h1>
    <asp:ListView ID="ListView1" runat="server" DataSourceID="ObjectDataSource1">
    </asp:ListView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
    </p>
   
    
</asp:Content>

