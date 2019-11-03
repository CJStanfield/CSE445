<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment6TryIt._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
    <br />
    Assignment 6 Services:</p>
<p>
    <strong>GetCar</strong></p>
<p>
    Description:&nbsp; Identify a customers preferences and recommend a list of cars that meet their criteria</p>
<p>
    URL: http://webstrar32.fulton.asu.edu/Page5/Service1.svc</p>
<p>
    Method: string[] GetCar(string make, string model, string year, string zipcode)</p>
<p>
    &nbsp;</p>
<p>
    Make:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="GetCarMake" runat="server" Width="323px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p>
    Model:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="GetCarModel" runat="server" Width="322px"></asp:TextBox>
</p>
<p>
    Year:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="GetCarYear" runat="server" Width="133px"></asp:TextBox>
</p>
<p>
    Zipcode:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="GetCarZipcode" runat="server"></asp:TextBox>
</p>
<p>
    Result:</p>
<p>
    <asp:Label ID="GetCarResult1" runat="server"></asp:Label>
</p>
    <p>
        <asp:Label ID="GetCarResult2" runat="server"></asp:Label>
</p>
    <p>
        <asp:Label ID="GetCarResult3" runat="server"></asp:Label>
</p>
<p>
    <asp:Button ID="GetCarButtonSubmit" runat="server" OnClick="GetCarButtonSubmit_Click" Text="Submit" />
</p>
<p>
    &nbsp;</p>
    <p>
        &nbsp;</p>
<p>
    Brake Recommendation Service (RESTful service)</p>
<p>
    Description:&nbsp; Identify when a customer needs to get their brakes serviced</p>
<p>
    URL: http://webstrar32.fulton.asu.edu/page7/Service1.svc</p>
<p>
    Method: string BrakeService(int currentMileage, int LastBrakeChangeMileage);</p>
<p>
    &nbsp;</p>
<p>
    Current Mileage:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="BrakeCurrentMileage" runat="server" Width="323px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p>
    Last Brake Change Mileage:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="BrakeLastMileage" runat="server" Width="322px"></asp:TextBox>
</p>
<p>
&nbsp;<asp:Button ID="BrakeButtonSubmit" runat="server" Text="Submit" OnClick="BrakeButtonSubmit_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Result:&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="BrakeLabelResult" runat="server"></asp:Label>
</p>
<p>
    &nbsp;</p>
    <p>
        &nbsp;</p>
<p>
    Oil Change Service</p>
<p>
    Description:&nbsp; Identify when a customer needs to get their oil changed</p>
<p>
    URL: http://webstrar32.fulton.asu.edu/Page5/Service1.svc</p>
<p>
    Method: string OilServiceRecommendation(string oilType, int currentMileage, int lastOilChangeMileage)</p>
<p>
    &nbsp;</p>
<p>
    Current Mileage:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="OilCurrentMileage" runat="server" Width="323px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p>
    Last Oil Change Mileage:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="OilLastMileage" runat="server" Width="322px"></asp:TextBox>
</p>
<p>
    Oil Type (conventional or synthetic):&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="OilType" runat="server" Width="322px"></asp:TextBox>
</p>
<p>
&nbsp;<asp:Button ID="OilButtonSubmit" runat="server" Text="Submit" OnClick="OilButtonSubmit_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Result:&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="OilLabelResult" runat="server"></asp:Label>
</p>
<p>
    &nbsp;</p>
    <p>
        &nbsp;</p>
<p>
    Make Appointment</p>
<p>
    Description: Get a users appointment preferences and schedule an appointment</p>
<p>
    URL: http://webstrar32.fulton.asu.edu/Page5/Service1.svc</p>
<p>
    Method: string ScheduleAppointment(string date, string time)</p>
<p>
    &nbsp;</p>
<p>
    Desired date (MM/dd/YYYY):&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="DesiredDate" runat="server" Width="323px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p>
    Desired Time (HH:mm AM/PM):&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="DesiredTime" runat="server" Width="322px"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
&nbsp;<asp:Button ID="AppointmentButtonSubmit" runat="server" Text="Submit" OnClick="AppointmentButtonSubmit_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Result:&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="AppointmentLabelResult" runat="server"></asp:Label>
</p>
<p>
    &nbsp;</p>
    <p>
        &nbsp;</p>
<p>
    Top 10 Words</p>
<p>
    Description: Get the top 10 words used on a website by entering the website URL</p>
<p>
    URL: http://webstrar32.fulton.asu.edu/Page5/Service1.svc</p>
<p>
    Method: string[] Top10Words(string url)</p>
<p>
    &nbsp;</p>
<p>
    URL:&nbsp;&nbsp;
    <asp:TextBox ID="Top10URL" runat="server" Width="323px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Top10Submit" runat="server" OnClick="Top10Submit_Click" Text="Submit" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>
            <asp:ListBox ID="Top10ListBox" runat="server"></asp:ListBox>
        </p>
<p>
    &nbsp;</p>
    <p>
        &nbsp;</p>
<p>
    5 Day Weather Forecast</p>
<p>
    Description: Gets the 5 day weather forcase based on a users zipcode</p>
<p>
    URL: http://webstrar32.fulton.asu.edu/Page5/Service1.svc</p>
<p>
    Method: string[] WeatherService(string zipcode)</p>
<p>
    &nbsp;</p>
<p>
    Zipcode:&nbsp;&nbsp;
    <asp:TextBox ID="WeatherZipcode" runat="server" Width="113px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="WeatherSubmit" runat="server" OnClick="WeatherSubmit_Click" Text="Submit" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>
            <asp:ListBox ID="WeatherListBox" runat="server"></asp:ListBox>
        </p>
    <p>
        &nbsp;</p>
&nbsp;

</asp:Content>
