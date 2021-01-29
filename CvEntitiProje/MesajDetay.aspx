<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MesajDetay.aspx.cs" Inherits="CvEntitiProje.MesajDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3 style="margin-left: 20px">MESAJ DETAYLARI</h3>
    <br />
    <asp:TextBox ID="TxtAdSoyad" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
    <br />
    <asp:TextBox ID="TxtMail" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>

    <br />
    <asp:TextBox ID="TxtKonu" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
    <br />
    <asp:TextBox ID="TxtMesaj" runat="server" TextMode="MultiLine" Height="100" CssClass="form-control" Enabled="false"></asp:TextBox>


</asp:Content>
