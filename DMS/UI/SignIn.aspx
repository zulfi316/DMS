<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="UI._Default" %>

<!DOCTYPE html">
<html>
<head runat="server">
    <title>Docket Management System </title>
    <link rel="stylesheet" type="text/css" href="/CSS/DMSstyle.css"/>
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
    
    <div style="width: 50%; height: 70%; float: left">
        &nbsp;
    </div>
    <div class="rightpane"style="width: 50%; height: 70%; float: right">
        <form runat="server" method="post">
        <fieldset>
            <legend>Enter login details: </legend>Username:
            <input type="text" name="login.username" />
            <br />
            Password:
            <input type="password" name="login.password" />
            <br />
            <input type="submit" value="Login!" />
        </fieldset>
        </form>
    </div>
</body>
</html>
