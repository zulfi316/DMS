<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateNew.aspx.cs" Inherits="UI.Docket.CreateNew" %>

<table>
    <tr>
        <th>
            Docket number:
        </th>
        <td>
            <input type="text" disabled="disabled" id="DMS-Docket-Number" value="<%=docketNumber %>" />
        </td>
    </tr>
    <tr>
        <th>
            Invention Name:
        </th>
        <td>
            <input type="text" value="" id="DMS-Docket-InventionName" />
        </td>
    </tr>
    <tr>
        <th>
            Inventor Name:
        </th>
        <td>
            <input type="text" value="" id="DMS-Docket-InventorName" />
        </td>
    </tr>
    <tr>
        <th>
            Type of App:
        </th>
        <td>
            <input type="text" value="" id="DMS-Docket-AppType" />
        </td>
    </tr>
</table>
