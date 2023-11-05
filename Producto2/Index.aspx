<%@ Page Title="" Language="C#" MasterPageFile="~/StaticItems.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Producto2.Index" Async="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Escribir aquí -->
    <h1 align="center">Productos</h1>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <!-- Se deberán visualizar los primeros 40 productos-->

    <asp:GridView ID="GridView1" runat="server"
        CssClass="table table-responsive table-hover
                       table-striped mt-3"
        HeaderStyle-BackColor="#3399ff"
        GridLines="Vertical"
        Font-Size="Small"
        HeaderStyle-ForeColor="White"
        HeaderStyle-Font-Size="Large"
        HeaderStyle-Font-Italic="true"
        HeaderStyle-BorderColor="Aquamarine">
    </asp:GridView>

</asp:Content>
