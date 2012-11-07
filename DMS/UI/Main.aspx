<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="UI.Main" %>

<!DOCTYPE html />
<html>
<head runat="server">
    <link href="CSS/jquery-ui-1.9.1.custom.css" rel="stylesheet" />
    <link href="CSS/DMSstyle.css" rel="stylesheet" type="text/css" />
    <script src="JS/jquery-1.8.2.js" type="text/javascript"></script>
    <script src="JS/jquery-ui-1.9.1.custom.js" type="text/javascript"></script>
    <script src="JS/DMSMain.js" type="text/javascript"></script>
    <title>Docket Management System</title>
    <script type="text/javascript" lang="javascript">

        //  Make the global JS class here

        $(function () {
            dmsMain = new DMSMain();
            dmsMain.Init("Docket");
        });

    </script>
</head>
<body class="DMS-Data-Main">
    <div style="width: 100%; height: 10%; background-color: #6678A0">
        <img height="100%" src="Images/Logo.jpg" alt="logo" style="float: left;" />
        
        <h1>Docket Management System</h1>
    </div>
    <hr />
    <div id="DMS-Breadcrumb" style="width: 100%; height: 10%; text-align: left">
        <span onclick="dcmMain.docket.Init()" style="cursor: pointer">Docket</span>
    </div>
    <div id="DMS-Main" class="DMS-Data-Display" style="position: relative; width: 80%;
        height: 60%; float: right;">
        <script type="text/javascript">
           
        </script>
    </div>
    <!-- Dynamic div for popups -->
    <div id="DMS-popup" style="display: none">
    </div>
</body>
</html>
