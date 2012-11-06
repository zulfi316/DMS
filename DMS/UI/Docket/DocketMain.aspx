<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DocketMain.aspx.cs" Inherits="UI.Docket.Main" %>

<button class=".ui-button" onclick="dmsMain.docket.ShowDocketCreation()" style="float:right">Create new docket!</button>

<%if (docketsForUser == null || docketsForUser.Count <= 0)
  { %>
<div style="text-align:center">
    <h4>
        No dockets currently assigned to you.
    </h4>
</div>
<%}
  else
  { %>

<div style=" position:absolute; top:10%; right:20%">
<h5>
    These are the dockets currently assigned to you:
</h5>
<table border="1">
    <tr>
        <th>
            Number
        </th>
        <th>
            Inventor
        </th>
        <th>
            Type
        </th>
        <th>
            Invention Name
        </th>
    </tr>
    <%
      foreach (UI.UIDocket.Docket docket in docketsForUser)
      {%>
    <tr onclick="dmsMain.project.Init('<%=docket.Id%>')">
        <td>
            <%=docket.Number%>
        </td>
        <td>
            <%=docket.InventorName%>
        </td>
        <td>
            <%=docket.TypeOfApp%>
        </td>
        <td>
            <%=docket.InventionName%>
        </td>
    </tr>
    <%}
  }
    %>
</table>
</div>


