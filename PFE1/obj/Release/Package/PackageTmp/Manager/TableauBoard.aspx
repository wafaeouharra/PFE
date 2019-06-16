<%@ Page Title="" Language="C#" MasterPageFile="~/Manager.Master" AutoEventWireup="true" CodeBehind="TableauBoard.aspx.cs" Inherits="PFE1.Manager.TableauBoard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link rel="stylesheet" type="text/css" href="../Content/Main.css" />   
    <p class="Title">Informations Generales</p>
        <table style="width: 100%">
            <tr>
                <td style="color: #DA9292; font-size: large; text-align: right; width: 1055px">
                    <h3><em><strong><span style="background-color: #19C2BC">Nombre de Clients :</span></strong></em></h3>
                </td>
                <td><strong>
                    <asp:Label ID="lblclts" runat="server" style="font-size: large; background-color: #FFFFFF" Text="Label"></asp:Label>
                    </strong></td>
            </tr>
            <tr>
                <td style="width: 1055px">
                    <h3 style="color: #DA9292; text-align: right"><strong><em><span style="background-color: #19C2BC">Nombre Entraineurs :</span></em></strong></h3>
                </td>
                <td><strong>
                    <asp:Label ID="lblentr" runat="server" style="font-size: large; background-color: #FFFFFF" Text="Label"></asp:Label>
                    </strong></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <h3>Selectionnez Entraineur :</h3>
                    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="NMPRENM" DataValueField="IDEntraineur" Font-Italic="True" Font-Size="Large" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Height="39px">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SalleConnectionString %>" SelectCommand="SELECT [IDEntraineur], [Nom]+' '+[Prenom] AS 'NMPRENM'FROM [Entraineur]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td style="width: 1055px">
                    <h3 style="color: #19C2BC; text-align: right"><strong><em><span style="background-color: #DA9292">Nombre Clients/Entraineur :</span></em></strong></h3>
                </td>
                <td><strong>
                    <asp:Label ID="lblnbcltsentr" runat="server" style="font-size: large; background-color: #FFFFFF" Text="0"></asp:Label>
                    </strong></td>
            </tr>
            <tr>
                <td style="color: #19C2BC; text-align: right; width: 1055px">
                    <h3><em><strong><span style="background-color: #DA9292">Salaire Entraineur :</span></strong></em></h3>
                </td>
                <td><strong>
                    <asp:Label ID="lblSalaireentr" runat="server" style="font-size: large; background-color: #FFFFFF" Text="0 DHS"></asp:Label>
                    </strong></td>
            </tr>
        </table>
</asp:Content>
