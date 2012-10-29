<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DocketMain.aspx.cs" Inherits="UI.Docket.Main" %>

<%if (docketsForUser == null || docketsForUser.Count <= 0)
  { %>
<div>
    <h5>
        No dockets currently assigned to you.
        <br />
        Get started by clicking in the new project button!
    </h5>
</div>
<%}
  else
  { %>
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
    <tr onclick="dcmMain.project.Init('<%=docket.Id%>')">
        <td>
            <%=docket.Id%>
        </td>
        <td>
            <%=docket.InventorName%>
        </td>
        <td>
            <%=docket.TypeOfApp%>
        </td>
    </tr>
    <%}
  }
    %>
</table>
