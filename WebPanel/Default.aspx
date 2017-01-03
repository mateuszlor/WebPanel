<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebPanel._Default" %>

<%@ Register TagPrefix="uc" TagName="TaskFormControl" Src="~/Controls/TaskFormControl.ascx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <uc:TaskFormControl runat="server" />
</asp:Content>
