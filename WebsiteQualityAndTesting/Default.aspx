<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebsiteQualityAndTesting._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div id="customWrap">
        <form method="post" enctype="multipart/form-data">
  <fieldset>
    <div class="form-group">
      <label for="valueOfCar">Vehicle value</label>
      <input type="number" class="form-control" id="valueOfCar" placeholder="Enter the value of the car" name="valueOfCar" min="0"
      required>
    </div>
    <div class="form-group">
      <label for="coverType">Select the cover type</label>
      <select class="form-control" id="coverType" name="coverType" required>
        <option>Comprehensive</option>
        <option>Third party</option>
      </select>
    </div>
    <div class="form-group">
      <label for="DOB">Date of birth</label>
      <input type="date" class="form-control" id="DOB" placeholder="Enter your date of birth" name="DOB"
      required>
    </div>
    <div class="form-group">
      <label for="penaltyPoints">Penalty Points</label>
      <input type="number" class="form-control" id="penaltyPoints" placeholder="Enter the number of penalty points"
             name="penaltyPoints" min="0" required>
    </div>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click2" Text="Submit" />
  </fieldset>
</form>
        <br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>

</asp:Content>
