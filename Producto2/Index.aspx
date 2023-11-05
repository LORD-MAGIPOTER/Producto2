<%@ Page Title="" Language="C#" MasterPageFile="~/StaticItems.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Producto2.Index" Async="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Escribir aquí -->
    <h1 align="center">Productos</h1>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <!-- Se deberán visualizar los primeros 40 productos-->
    <div class="container mt-5">
        <div class="row">
            <div class="col-md-6 offset-md-3">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">Product Information</h5>
                        <ul class="list-group list-group-flush">
                            <li class="list-group-item"><strong>ProductID:</strong>
                                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                            </li>
                            <li class="list-group-item"><strong>ProductName:</strong>
                                <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                            </li>
                            <li class="list-group-item"><strong>SupplierID:</strong>
                                <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                            </li>
                            <li class="list-group-item"><strong>CategoryID:</strong>
                                <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                            </li>
                            <li class="list-group-item"><strong>QuantityPerUnit:</strong>
                                <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                            </li>
                            <li class="list-group-item"><strong>UnitPrice:</strong>
                                <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
                            </li>
                            <li class="list-group-item"><strong>UnitsInStock:</strong>
                                <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
                            </li>
                            <li class="list-group-item"><strong>UnitsOnOrder:</strong>
                                <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
                            </li>
                            <li class="list-group-item"><strong>ReorderLevel:</strong>
                                <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
                            </li>
                            <li class="list-group-item"><strong>Discontinued:</strong>
                                <asp:Label ID="Label11" runat="server" Text=""></asp:Label>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    
</asp:Content>
