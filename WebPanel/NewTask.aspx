<%@ Page Title="Nowe ćwiczenie" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewTask.aspx.cs" Inherits="WebPanel.NewTask" %>

<%@ Register TagPrefix="uc" TagName="TaskFormControl" Src="~/Controls/TaskFormControl.ascx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <uc:TaskFormControl runat="server" ID="TaskForm" />
</asp:Content>
