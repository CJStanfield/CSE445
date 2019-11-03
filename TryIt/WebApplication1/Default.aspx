<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Display Contents of XML File</h1>
        <p class="lead">Paste the XML URL in the following text box to display its contents</p>
        <p>
            <asp:TextBox ID="XmlInput" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" Text="Submit" />
            <asp:XmlDataSource ID="XmlDataSource1" runat="server"></asp:XmlDataSource>
        </p>
        <p>Tag names:</p>
        <p>
            <asp:ListBox ID="TagNamesListBox" runat="server"></asp:ListBox>
        </p>
        <p>Text Contents:</p>
        <p>
            <asp:ListBox ID="TextContentsListBox" runat="server"></asp:ListBox>
        </p>
        <p>Attribute Names:</p>
        <p>
            <asp:ListBox ID="AttributeNamesListBox" runat="server"></asp:ListBox>
        </p>
        <p>Attribute Values:</p>
        <p>
            <asp:ListBox ID="AttributeValuesListBox" runat="server"></asp:ListBox>
        </p>
        <p>&nbsp;</p>
    </div>

</asp:Content>
