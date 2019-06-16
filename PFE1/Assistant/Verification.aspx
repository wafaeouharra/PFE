<%@ Page Title="" Language="C#" MasterPageFile="~/Assistant.Master" AutoEventWireup="true" CodeBehind="Verification.aspx.cs" Inherits="PFE1.Assistant.Verification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="../Content/Main.css" />
    <p class="Title">Les Informations du client</p>
    <p style="text-align: right"><asp:Label ID="lblSituation" runat="server" Font-Bold="True" Font-Italic="True" Font-Underline="True"></asp:Label><br /></p>
    <table align="center">
        <tr>
            <td>
                <label>IDClient :</label>
            </td>
            <td>
                <asp:TextBox ID="TxtID" runat="server" Height="35px" Width="200px"></asp:TextBox>
                <asp:Button ID="btnverif" runat="server" Text="Verifier" OnClick="btnverif_Click" BackColor="#86CFE2" BorderStyle="None" Font-Italic="True" Font-Size="Larger" Font-Underline="True" Height="91px" Width="168px"/>
            </td>
        </tr>
                <tr>
            <td>
                <label>Nom Client :</label><br />
                <label>Prenom Client :</label><br />
                <label>Tel Client :</label><br />
                <label>Activité :<br />
                Entraineur :</label><br />
                <label>Type Abonnement :</label><br />
            </td>
            <td>
                <asp:Label ID="lblnom" runat="server" Text="Le nom"></asp:Label><br />
                <asp:Label ID="lblprenom" runat="server" Text="le prenom"></asp:Label><br />
                <asp:Label ID="lbltelephone" runat="server" Text="le telephone"></asp:Label><br />
                <asp:DropDownList ID="DDLActivite" runat="server" DataSourceID="SqlDataSource1" DataTextField="LibelleActivite" DataValueField="IDActivite" Height="30px" Width="200px" AutoPostBack="True">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SalleConnectionString %>" SelectCommand="SELECT [IDActivite], [LibelleActivite] FROM [Activite]"></asp:SqlDataSource>
                <br />
                <asp:DropDownList ID="DDLEntraineur" runat="server" DataSourceID="SqlDataSource3" DataTextField="NMPRNM" DataValueField="IDEntraineur" Height="30px" style="margin-left: 0px" Width="200px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:SalleConnectionString %>" SelectCommand="SELECT [IDEntraineur],[Nom]+' '+[Prenom] AS 'NMPRNM' FROM [Entraineur] WHERE Specialite=@Activ">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DDLActivite" DefaultValue="1" Name="Activ" PropertyName="SelectedValue" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <br />
                <asp:DropDownList ID="DDLTypeAbonn" runat="server" DataSourceID="SqlDataSource2" DataTextField="NomType" DataValueField="IDType" Height="30px" Width="200px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:SalleConnectionString %>" SelectCommand="SELECT [IDType], [NomType] FROM [TypeAbonnement]"></asp:SqlDataSource>
            </td>
        </tr>
                <tr>
            <td>
                <asp:Button ID="btnModif" runat="server" Text="Modifier" OnClick="btnModif_Click" BackColor="#86CFE2" BorderStyle="None" Font-Italic="True" Font-Size="Larger" Font-Underline="True" Height="91px" Width="168px" OnClientClick="return confirm('Etes vous sur?');"/>
            </td>
            <td>
                <asp:Button ID="btnAnnul" runat="server" Text="Annuler" OnClick="btnAnnul_Click" BackColor="#F4CEC3" BorderStyle="None" Font-Italic="True" Font-Size="Larger" Font-Underline="True" Height="91px" Width="168px"/>
            </td>
        </tr>
    </table>

</asp:Content>
