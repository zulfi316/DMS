<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="UI.Main" %>

<!DOCTYPE html />
<html>
<head runat="server">
    <link href="CSS/jquery-ui-1.9.1.custom.css" rel="stylesheet"/>
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
<body>
    <div style="width: 100%; height: 10%; background-color: #778899">
        <h1>
            &lt;Logo goes here &gt;
        </h1>
    </div>
    <hr />
    <div style="width: 100%; height: 10%; text-align: left">
        <h3>
            Welcome to the docket management system
        </h3>
    </div>
    <div id="DMS-popup" style="display: none">
    </div>
    <div id="DMS-Breadcrumb" style="width: 100%; height: 10%; text-align: left">
        <span onclick="dcmMain.docket.Init()" style="cursor: pointer">Docket</span>
    </div>
    <div id="DMS-Main" style=" position:relative; width: 80%; height: 60%;float:right;">
        <script type="text/javascript">
           
        </script>
    </div>
</body>
</html>
