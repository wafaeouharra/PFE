<%@ Page Title="" Language="C#" MasterPageFile="~/Public.Master" AutoEventWireup="true" CodeBehind="Accueil.aspx.cs" Inherits="PFE1.Accueil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link rel="stylesheet" type="text/css" href="Content/Main.css" />
    <p class="Title">Bienvenue le site Officiel de<br /> MaFitness Club</p>
        <p style="text-align: center">
            <asp:Button ID="btnClient" runat="server" BackColor="#F4CEC3" BorderStyle="None" Font-Italic="True" Font-Size="Larger" Font-Underline="True" Height="91px" Text="Client" Width="168px" OnClick="btnClient_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <em>
            <asp:Button ID="btnStf" runat="server" Text="Personnel" OnClick="btnStf_Click" BackColor="#86CFE2"  BorderStyle="None" Font-Italic="True" Font-Size="Larger" Font-Underline="True" Height="91px" Width="168px"/>
            </em>
        </p>
</asp:Content>
