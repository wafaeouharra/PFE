<%@ Page Title="" Language="C#" MasterPageFile="~/Assistant.Master" AutoEventWireup="true" CodeBehind="Inscription.aspx.cs" Inherits="PFE1.Inscription" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="../Content/Main.css" />   
    <p class="Title">Ajouter Un Nouveau Client</p>
    <table style="width: 100%">
        <tr>
            <td style="font-size: x-large; text-align: right; width: 587px;">Nom :</td>
            <td style="text-align: left">
                <asp:TextBox ID="TextBox1" runat="server" Width="490px" Height="36px" style="margin-left: 0px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-size: x-large; text-align: right; width: 587px;">Prenom :</td>
            <td style="text-align: left">
                <asp:TextBox ID="TextBox2" runat="server" Width="490px" Height="34px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-size: x-large; text-align: right; height: 44px; width: 587px;">Telephone :</td>
            <td style="text-align: left; height: 44px">
                <asp:TextBox ID="TxtTel" runat="server" Width="490px" Height="34px">06-</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center; height: 134px;">
                <em>
                <asp:Button ID="BtnEnrg" class="bouton" runat="server" Text="Enregistrer" BackColor="#F4CEC3" BorderStyle="None" Font-Italic="True" Font-Size="Larger" Font-Underline="True" Height="91px" Width="168px" />
                </em>
            </td>
        </tr>
    </table>
</asp:Content>
