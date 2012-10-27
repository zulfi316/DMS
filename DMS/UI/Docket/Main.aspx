<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="UI.Docket.Main" %>

<h5>
    These are the dockets currently assigned to you:
</h5>
<table border="1">
    <tr>
        <th>
            Numer
        </th>
        <th>
            Inventor
        </th>
        <th>
            Type
        </th>
    </tr>
    <%
        foreach (UI.UIDocket.Docket docket in docketsForUser)
        {%>
    <tr>
        <td>
            <%=docket.Id %>
        </td>
        <td>
            <%=docket.InventorName %>
        </td>
        <td>
            <%=docket.TypeOfApp %>
        </td>
    </tr>
    <%}
    %>
</table>
