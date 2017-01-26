<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TaskFormControl.ascx.cs" Inherits="WebPanel.Controls.TaskFormControl" %>

<div class="container">
    <asp:Panel runat="server" ID="TaskPanelPreview">
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
                        <asp:Literal runat="server" ID="Repeats" />
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
    <asp:Panel runat="server" ID="TaskPanelNew">
        <table class="table">
            <tbody>
                <tr>
                    <th>Zadanie:</th>
                    <td>
                        <asp:TextBox runat="server" ID="NewName" CausesValidation="True" ValidationGroup="Validation" />
                        <asp:RequiredFieldValidator runat="server" ValidationGroup="Validation" ErrorMessage="Pole jest wymagane" ControlToValidate="NewName" />
                    </td>
                </tr>
                <tr>
                    <th>Ilość: </th>
                    <td>
                        <asp:TextBox runat="server" ID="NewRepeats" CausesValidation="True" ValidationGroup="Validation" />
                        <asp:RequiredFieldValidator runat="server" ValidationGroup="Validation" ErrorMessage="Pole jest wymagane" ControlToValidate="NewRepeats" />
                    </td>
                </tr>
            </tbody>
        </table>
        <asp:Button runat="server" ID="AddButton" Text="Dodaj" OnClick="AddButton_OnClick" CausesValidation="True" ValidationGroup="Validation" />
    </asp:Panel>
    <asp:Panel runat="server" ID="ErrorPanel">
        <p class="text-error">Nie znaleziono taska o podanym ID</p>
    </asp:Panel>
</div>
