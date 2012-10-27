<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="UI._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Docket Management System </title>
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
    <div style="width: 50%; height: 70%; float: right">
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
