<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="UI.Main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
    <div style="width: 100%; height: 10%; text-align: center">
        <h5>
            These are the dockets currently assigned to you:
        </h5>
        <fieldset>
            <legend>Dockets:</legend>
            <%for (int i = 0; i < docketInfo.Count; i++)
              {
                  Response.Write(docketInfo[i][0]);
                  Response.Write(docketInfo[i][1]);
                  Response.Write(docketInfo[i][2]);
              } %>
        </fieldset>
    </div>
</body>
</html>
