<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryIt._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Assignment 5 TryIt</h1>
        <h1>5 Day Weather Forecast:</h1>
        <p>Get the 5 day weather forcast by typing your zipcode below:<br />
            <asp:TextBox ID="WeatherInput" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Height="26px" OnClick="Button2_Click" Text="Submit" Width="94px" />
        </p>
        <p>
            <asp:ListBox ID="ListBoxWeather" runat="server"></asp:ListBox>
        </p>
        <p>
            Method Name: string[] WeatherService(string zipcode);</p>
        <p>
            <a href="http://localhost:62672/Service1.svc">http://localhost:62672/Service1.svc</a></p>
        <h1>Top10Words Service:</h1>
        <p>Get the top 10 words from a website by entering the url below:<br />
            <asp:TextBox ID="TopWordsInput" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Height="26px" Text="Submit" Width="100px" OnClick="Button1_Click" />
        </p>
        <p>
            <asp:ListBox ID="ListBoxWords" runat="server"></asp:ListBox>
        </p>
        <p>
            string[] Top10Words(string url);</p>
        <p>
            <a href="http://localhost:62672/Service1.svc">http://localhost:62672/Service1.svc</a></p>
    </div>

    <div class="row">
    </div>

</asp:Content>
