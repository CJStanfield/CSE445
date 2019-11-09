<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryIt._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Assignment 8</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Verification</h2>
            <p>
                Verification takes the URL of an XML (.xml) file and the URL of the corresponding XMLS (.xsd) file as input and validates the XML file against the corresponding XMLS (XSD) file. The Web method returns “No Error” or an error message showing the available information at the error point.</p>
            <p>
                <strong>XML Link&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
                <asp:TextBox ID="VerificationXMLLink" runat="server" Width="277px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Result:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="VerificationResult" runat="server"></asp:TextBox>
            </p>
            <p>
                XSD<strong> Link&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
                <asp:TextBox ID="VerificationXSDLink" runat="server" Width="277px"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="VerificationButton" runat="server" OnClick="VerificationButton_Click" Text="Submit" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Search</h2>
            <p>
                takes the URL of an XML (.xml) file and a key (e.g., the model of a car) as input. It returns the node’s content information related to the search key, for example: name, contact, phone, etc.</p>
            <p>
                <strong>XML Link&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
                <asp:TextBox ID="SearchXMLLink" runat="server" Width="277px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
            <p>
                Key&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
                <asp:TextBox ID="SearchKey" runat="server" Width="277px"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="SearchButton" runat="server" Text="Submit" OnClick="SearchButton_Click" />
            </p>
        </div>
    </div>

</asp:Content>
