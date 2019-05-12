<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Ton trajet en Velib</h2>
        <hr class="my-1">
        <p class="lead">Génére ton trajet en fonction de ta position, ta destination et le vélib le plus proche !</p>
    </div>

    <div class="jumbotron">
        <h3>Saisissez l'addresse de départ et l'adresse d'arrivée</h3>
        <hr class="my-1">

        <div class="form-group">
            <label for="ville">Ville</label>
            <asp:DropDownList ID="ville" runat="server" CssClass="form-control col-6"></asp:DropDownList>
        </div>

        <div class="form-group">
            <label for="inputStart">Adresse de départ</label>
            <input type="text" runat="server" class="form-control" id="inputStart" value="296 avenue janvier passero les kirikos" placeholder="1234 Main St">
        </div>

        <div class="form-group">
            <label for="inputEnd">Adresse d'arrivé</label>
            <input type="text" runat="server" class="form-control" id="inputEnd" placeholder="1234 Main St" value="2 rue emile bouton, bâtiment parc cézanne">
        </div>
        <asp:Button ID="Button1" runat="server" Text="Valider" class="btn btn-primary" OnClick="Button1_Click" />
    </div>

</asp:Content>
