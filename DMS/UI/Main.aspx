<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="UI.Main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script src="Scripts/DCMMain.js" type="text/javascript"></script>
    <title>Docket Management System</title>
    <script type="text/javascript" language="javascript">

        //  Make the global JS class here
        dcmMain = new DCMMain();
        

    </script>
</head>
<body>
    <div style="width: 100%; height: 10%; background-color: #778899">
        <h1>
            &lt;Logo goes here &gt;
        </h1>
    </div>
    <hr />
    <div style="width: 100%; height: 10%; text-align: center">
        <h3>
            Welcome to the docket management system
        </h3>
    </div>
    <div id="DCM.Breadcrumb" style="width: 100%; height: 10%; text-align: center">
        <span onclick="dcmMain.docket.Init()" style="cursor: pointer">Docket</span>
    </div>
    <div id="DCM.MainDiv" style="width: 100%; height: 60%; text-align: center">
        <script type="text/javascript">
            dcmMain.Init("Docket");
        </script>
    </div>
</body>
</html>
