<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebPanel._Default" %>

<%@ Register TagPrefix="uc" TagName="TaskListControl" Src="~/Controls/TaskListControl.ascx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <uc:TaskListControl runat="server" />
</asp:Content>
