<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciGuncelle.aspx.cs" Inherits="OgrenciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <form runat="server" id="form1">
        <div class="form-group">
            <div>
                <asp:Label for="TextId" runat="server" Text="Öğrenci ID : " style="font-weight:700"></asp:Label>
                <asp:TextBox ID="TextId" runat="server" CssClass ="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TextAd" runat="server" Text="Öğrenci Ad : " style="font-weight:700"></asp:Label>
                <asp:TextBox ID="TextAd" runat="server" CssClass ="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TextSoyad" runat="server" Text="Öğrenci Soyad : " style="font-weight:700"></asp:Label>
                <asp:TextBox ID="TextSoyad" runat="server" CssClass ="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TextNumara" runat="server" Text="Öğrenci Numara : " style="font-weight:700"></asp:Label>
                <asp:TextBox ID="TextNumara" runat="server" CssClass ="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TextMail" runat="server" Text="Öğrenci Mail : " style="font-weight:700"></asp:Label>
                <asp:TextBox ID="TextMail" runat="server" CssClass ="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TextSifre" runat="server" Text="Öğrenci Şifre : " style="font-weight:700"></asp:Label>
                <asp:TextBox ID="TextSifre" runat="server" CssClass ="form-control"></asp:TextBox>
            </div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-warning" OnClick="Button1_Click" />
    </form> 
</asp:Content>


