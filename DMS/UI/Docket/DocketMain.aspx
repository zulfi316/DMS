<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DocketMain.aspx.cs" Inherits="UI.Docket.Main" %>

<img style="position: absolute; top: 10%; right: 15%; cursor: pointer" title="Add New Docket"
    alt="Add New Docket" onclick="dmsMain.docket.ShowDocketCreation()" src="/Images/AddDocket.jpg" />
<img style="position: absolute; top: 10%; right: 13%; cursor: pointer" title="Delete Dockets"
    alt="Delete Dockets" onclick="dmsMain.docket.SetDeleted()" src="/Images/Delete.png" />
<%if (docketsForUser == null || docketsForUser.Count <= 0)
  { %>
<div style="text-align: center">
    <h4>
        No dockets currently assigned to you.
    </h4>
</div>
<%}
  else
  { %>
<div style="position: absolute; top: 10%; right: 20%">
    <table>
        <tr>
            <th>
                <input id="DMS-Docket-SelectAll" type="checkbox" onclick="dmsMain.SelectAllCheckboxes('DMS-Docket-Selector', this.checked)" />
            </th>
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
        <tr>
            <td>
                <input type="checkbox" class="DMS-Docket-Selector" id="<%=docket.Id%>" />
            </td>
            <td onclick="dmsMain.project.Init('<%=docket.Id%>')" style="cursor: pointer">
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
