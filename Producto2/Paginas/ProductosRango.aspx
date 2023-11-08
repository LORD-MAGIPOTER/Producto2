<%@ Page Title="" Language="C#" MasterPageFile="~/StaticItems.Master" AutoEventWireup="true" CodeBehind="ProductosRango.aspx.cs" Inherits="Producto2.Paginas.ProductosRango" Async="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Aquí irá el contenido de la segunda página-->
    <div class="container">
    <div class="row">
        <div class="col-sm-12 col-md-12 d-flex justify-content-center align-items-center">
            <h3 class="fw-bold mt-3">Unidades en Stock</h3>
        </div>
        <div class="col-sm-12 col-md-12 d-flex justify-content-center align-items-center">
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-12 col-md-12 text-center bg-black border border-1 border-danger">
            <p class="text-light">Ingrese Rango de Precio a Buscar</p>
            <p class="text-light">Precio:</p><asp:TextBox ID="TextBox1" runat="server" placeholder="Mayor a: "></asp:TextBox>
            <p class="text-light">Precio:</p> <asp:TextBox ID="TextBox2" runat="server" placeholder="Menor o igual a: "></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />
        </div>
    </div>
    <hr />
    <br />
    <div class="container">
        <div class="row">
            <div class="col">
                <div class="table-responsive">
                    <asp:GridView ID="GridView1" runat="server"
                        CssClass="table table-hover table-striped mt-3 table-bordered"
                        HeaderStyle-BackColor="#000"
                        GridLines="Vertical"
                        Font-Size="Small"
                        HeaderStyle-ForeColor="White"
                        HeaderStyle-Font-Size="Large"
                        HeaderStyle-Font-Italic="true"
                        HeaderStyle-BorderColor="#C8A2C8">
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</div>
</asp:Content>
