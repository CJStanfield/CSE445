<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent"></asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>ASP .NET Test Client</h2>
    <p>Enter a string of numbers separated by commas to be sorted
        <asp:TextBox ID="txtInput" runat="server" Width="200px">
        </asp:TextBox>
        &nbsp;<asp:Button ID="btnSubmit" runat="server" onClick="btnSubmit_Click" Text="Submit" />
    </p>
    <p>Sorted String:
        <asp:Label ID="lblSorted" runat="server" ></asp:Label>
    </p>
    <p>Calculator <br /> <br />
        <asp:TextBox ID="InputNum1" runat="server" Width="50px"></asp:TextBox> 
         <asp:Label ID="LabelOperator" runat="server" ></asp:Label>
        <asp:TextBox ID="InputNum2" runat="server" Width="50px"></asp:TextBox> 
        <asp:Label ID="LabelEquals" runat="server" Text=" = " ></asp:Label>
        <asp:Label ID="LabelResult" runat="server" ></asp:Label>
        <br />
        <asp:Button ID="ButtonPlus" runat="server" onClick="updateOperator_Add" Text="+" Width="25px"/>
        <asp:Button ID="ButtonMinus" runat="server" onClick="updateOperator_Subtract" Text="-" Width="25px" />
        <br />
        <asp:Button ID="ButtonMultiply" runat="server" onClick="updateOperator_Multiply" Text="*" Width="25px"/>
        <asp:Button ID="ButtonDivide" runat="server" onClick="updateOperator_Divide" Text="/" Width="25px"/>
        <br />
        <asp:Button ID="Calculate" runat="server" onClick="Calculator_Result" Text="Calculate" />
    </p>

    <p>Stock Quotes <br /> <br />
         
        <asp:Label ID="LabelSearchTicker" runat="server" >Search Ticker Symbol</asp:Label>
        <asp:TextBox ID="InputTickerSymbol" runat="server" Width="50px"></asp:TextBox>
        <asp:Label ID="LabelStockPrice" runat="server" ></asp:Label>
        <br />
        <asp:Button ID="ButtonSearchTicker" runat="server" onClick="Search_Ticker" Text="Search" Width="100px"/>
    </p>
</asp:Content>

