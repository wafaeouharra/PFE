<%@ Page Title="" Language="C#" MasterPageFile="~/Public.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PFE1.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <link rel="stylesheet" type="text/css" href="Content/Main.css" />
    <div class="login" style="background-image:url('../Images/img5.jpg')">
            <p class="Title">Authentification</p>
            <div style="align-self: center;background-color: transparent;">
            <asp:Login ID="Login1" runat="server" BackColor="#FFCCCC" BorderColor="#999999" BorderStyle="Solid" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" Height="307px" OnLoggingIn="Login1_LoggingIn" Orientation="Horizontal" Width="1499px" OnAuthenticate="Login1_Authenticate" >
                <LoginButtonStyle BackColor="#19C2BC" BorderStyle="None" Font-Bold="True" Height="80px" />
                <TitleTextStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Size="Larger" Font-Strikeout="False" Font-Underline="True" />
                <ValidatorTextStyle Font-Bold="False" />
            </asp:Login>
            </div>
            <br />

    </div>
</asp:Content>
