<%@ Page Title="" Language="C#" MasterPageFile="~/StaticItems.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Producto2.Index" Async="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Escribir aquí -->
    <div class="content-container">
        <h1 align="center">Productos</h1>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <!-- Se deberán visualizar los primeros 40 productos-->
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
