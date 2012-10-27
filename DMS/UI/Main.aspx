<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="UI.Main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <title>Docket Management System</title>

    <script type="text/javascript" language="javascript">

        function Init(userStartPage) {

            $.ajax({
                type: "POST",
                url: userStartPage,
                data: "",
                dataType: "html",
                success: function (result) {

                    //$(#"DCM.MainDiv").html(result);
                    document.getElementById("DCM.MainDiv").innerHTML = result;
                },
                error: function () {

                    alert("Oopsies happened!");
                }
            });
        }

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
    <div id="DCM.MainDiv" style="width: 100%; height: 70%; text-align: center">
       <script type="text/javascript">
           Init("/Docket/Main.aspx");
       </script>
    </div>
</body>
</html>
