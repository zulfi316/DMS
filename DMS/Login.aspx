<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DMS._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>
        Welcome to the docket management system</h1>
    <hr />
    <div id="abhi">
        <form runat="server">
        <table>
            <tr>
                <td>
                    Username:
                </td>
                <td>
                    <input type="text" name="login.userid" />
                </td>
            </tr>
            <tr>
                <td>
                    Password:
                </td>
                <td>
                    <input type="password" name="login.password" />
                </td>
            </tr>
            <tr>
                <td>
                    <input type="submit" value="Login!" name="login.action" />
                </td>
                <td>
                    <input type="submit" value="Forgot Password" name="login.action" />
                </td>
            </tr>
        </table>
        </form>
    </div>
</body>
</html>
