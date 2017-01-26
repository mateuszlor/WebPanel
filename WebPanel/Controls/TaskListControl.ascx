<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TaskListControl.ascx.cs" Inherits="WebPanel.Controls.TaskListControl" %>

<div class="container" style="max-width: 99%">
    <asp:Panel runat="server" ID="TaskPanel">
        <div style="max-width: 98%">
            <asp:DataGrid runat="server" ID="DataGrid" AutoGenerateColumns="False" OnItemCommand="DataGrid_OnItemCommand" BorderStyle="None" BorderWidth="0" BorderColor="white" CssClass="table">
                <Columns>
                    <asp:BoundColumn HeaderText="Zadanie" DataField="Name" />
                    <asp:BoundColumn HeaderText="Ilość" DataField="Repeats" />
                    <asp:TemplateColumn HeaderText="Wykonane">
                        <ItemTemplate>
                            <asp:CheckBox ID="CheckBox" Checked='<%#DataBinder.Eval(Container.DataItem,"IsCompleted") %>' Enabled="False" runat="server" />
                            <asp:HiddenField ID="ID" runat="server" Value='<%#DataBinder.Eval(Container.DataItem,"ID") %>' />
                        </ItemTemplate>
                    </asp:TemplateColumn>
                    <asp:ButtonColumn Text="Wykonane" CommandName="DoneClicked" />
                </Columns>
            </asp:DataGrid>
        </div>
        <asp:Button runat="server" ID="RemoveAllButton" Text="Usuń wszystko" OnClick="RemoveAllButton_OnClick" />
    </asp:Panel>
    <asp:Panel runat="server" ID="ErrorPanel">
        <p class="text-error">Nie znaleziono żadnych tasków</p>
    </asp:Panel>
    <asp:Button runat="server" ID="AddButton" Text="Dodaj" OnClick="AddButton_OnClick" />
</div>
