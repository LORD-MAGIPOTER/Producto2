<%@ Page Title="" Language="C#" MasterPageFile="~/StaticItems.Master" AutoEventWireup="true" CodeBehind="UnidadesStock.aspx.cs" Inherits="Producto2.Paginas.UnidadesStock" Async="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Aquí irá la información del cuarto enlace  -->
    <div class="row">
    <div class="col-sm-12 col-md-12 d-flex justify-content-center align-items-center">
        <h3 class="text-primary mt-3">Edades</h3>
    </div>
    <div class="col-sm-12 col-md-12 d-flex justify-content-center align-items-center">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
</div>
<div class="row">
    <div class="col-sm-12 col-md-12 text-center bg-primary border border-1 border-danger">
        <p>Seleccione Unidades en Stock</p>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
    </div>
</div>
<hr />
<div class="row">
    <div class="col-sm-12 col-md-12 d-flex justify-content-center align-items-center
                     border border-1 border-primary">
        <asp:ListView ID="ProductoStock" runat="server"
            GroupItemCount="3"
            ItemType="Producto2.Models.Products.DataProductos_">
            <EmptyDataTemplate>
                <table>
                    <tr>
                        <td>Ningún dato fue devuelto.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <GroupTemplate>
                <tr runat="server">
                    <td id="itemPlaceholder" runat="server"></td>
                </tr>
            </GroupTemplate>
            <ItemTemplate>
                <td runat="server">
                    <%#: Item.ProductID %>
                    <br />
                    <%#:Item.ProductName %>                       
                    <br />
                    <%#:Item.SupplierID %>
                    <br />
                    <%#: Item.CategoryID %>
                    <br />
                    <%#:Item.UnitsInStock %>
                    <p>---------------</p>
                </td>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server" style="width: 100%;">
                    <tr id="groupPlaceholder" runat="server">
                    </tr>
                </table>
            </LayoutTemplate>
        </asp:ListView>
    </div>
    <%--col--%>
</div>
</asp:Content>
