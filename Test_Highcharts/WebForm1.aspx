<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Test_Highcharts.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <%--<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"></script>--%>
      <%--<script type="text/javascript" src="http://code.highcharts.com/highcharts.js"></script>--%>
      <%--<script type="text/javascript" src="http://code.highcharts.com/modules/exporting.js"></script>--%>
    <title></title>    
    <script src="js/highcharts.js"></script>
    <script src="scripts/Highcharts-4.0.1/js/modules/exporting.js"></script>
    <script src="scripts/jquery-3.0.0.min.js"></script>
<%--    <script src="scripts/jquery-3.0.0.min.js"></script>
    <script  src="scripts/Highcharts-4.0.1/js/modules/exporting.js"></script>--%>
</head>

<body>
    <form id="form1" runat="server">
    <asp:Literal ID="chrtMyChart" runat="server"></asp:Literal>
    <div id="container" style="min-width: 310px; height: 400px; margin: 0 auto"  runat="server"></div>        
    <div>
    
    </div>
    </form>
</body>
</html>
