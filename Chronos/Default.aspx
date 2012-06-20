<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Chronos._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">


<!-- jQuery -->
<script type="text/javascript" src="scripts/jquery-1.6.1.min.js"></script>
<!--Chop Slider Core Plugin -->
<script type="text/javascript" src="scripts/jquery.id.chopslider-2.2.0.free.min.js"></script>
<!--Chop Slider Transitions Library-->
<script type="text/javascript" src="scripts/jquery.id.cstransitions-1.2.min.js"></script>
<!--Scripts with Slider's Initialization -->
<script type="text/javascript" src="scripts/demo-2d.js"></script>

</asp:Content>


<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
<link rel="stylesheet" type="text/css" href="css/chopslider.css"  />    
<div class="wrapper">
  <div class="s-shadow-b"></div>
  <a id="slide-next" href="#"></a> 
  <a id="slide-prev" href="#"></a>
  <div id="slider">
    <div class="slide cs-activeSlide"> <img src="images/slider/1.jpg" width="900" height="300" alt="slide1" /> </div>
    <div class="slide"> <img src="images/slider/2.jpg" width="900" height="300" alt="slide2" /> </div>
    <div class="slide"> <img src="images/slider/3.jpg" width="900" height="300" alt="slide3" /> </div>
    <div class="slide"> <img src="images/slider/4.jpg" width="900" height="300" alt="slide4" /> </div>
  </div>
  <div class="pagination"> 
    <span class="slider-pagination"></span> 
    <span class="slider-pagination"></span> 
    <span class="slider-pagination"></span> 
    <span class="slider-pagination"></span> 
  </div>
    <div class="caption"></div>
</div>

</asp:Content>
