<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebsiteQualityAndTesting._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div id="customWrap">
        <form method="post" enctype="multipart/form-data">
  <fieldset>
    <div class="form-group">
      <label for="vehicleValue">Vehicle value</label>
      <input type="number" class="form-control" id="vehicleValue" placeholder="Enter vehicle value" name="vehicleValue" min="0"
      required>
    </div>
    <div class="form-group">
      <label for="selectCover">Select cover type</label>
      <select class="form-control" id="selectCover" name="coverType" required>
        <option>Comprehensive</option>
        <option>Third party</option>
      </select>
    </div>
    <div class="form-group">
      <label for="dateOfBirth">Date of birth</label>
      <input type="date" class="form-control" id="dateOfBirth" placeholder="Enter your date of birth" name="dateOfBirth"
      required>
    </div>
    <div class="form-group">
      <label for="penaltyPointsValue">Penalty Points</label>
      <input type="number" class="form-control" id="penaltyPointsValue" placeholder="Enter your penalty points"
             name="penaltyPoints" min="0" required>
    </div>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click2" Text="Submit" />
  </fieldset>
</form>
        <br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>

</asp:Content>
