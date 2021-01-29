<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YetenekGuncelle.aspx.cs" Inherits="CvEntitiProje.YetenekGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3 style="margin-left: 20px"> YETENEK GÜNCELLEME SAYFASI</h3>
    <br />

    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Yeteneğinizi Yazın !!!"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Kaydet" style="margin-left:20px" CssClass="btn btn-primary" OnClick="Button1_Click"  />

</asp:Content>
