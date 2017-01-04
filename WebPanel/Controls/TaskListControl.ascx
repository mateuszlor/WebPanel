<%@  Control Language="C#" AutoEventWireup="true" CodeBehind="TaskListControl.ascx.cs" Inherits="WebPanel.Controls.TaskListControl" %>

<div class="container">
    <asp:Panel runat="server" ID="TaskPanel">
    <table class="table">
        <tbody>
            <tr>
                <th>Zadanie:</th>
                <td>
                    <asp:Literal runat="server" ID="Task" />
                </td>
            </tr>
            <tr>
                <th>Ilość: </th>
                <td>
                    <asp:Literal runat="server" ID="Count" />
                </td>
            </tr>
            <tr>
                <th>Wykonane:</th>
                <td>
                    <asp:CheckBox runat="server" ID="Completed" />
                </td>
            </tr>
        </tbody>
    </table>
        </asp:Panel>
    <asp:Panel runat="server" ID="ErrorPanel">
        <p class="text-error">Nie znaleziono taska o podanym ID</p>
    </asp:Panel>
</div>
