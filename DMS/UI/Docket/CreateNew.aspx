<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateNew.aspx.cs" Inherits="UI.Docket.CreateNew" %>

<table style="text-align: right">
    <tr>
        <th>
            Invention Name:
        </th>
        <td>
            <input type="text" id="DMS-Docket-InventionName" title="Please enter a title!" />
        </td>
    </tr>
    <tr>
        <th>
            Inventor Name:
        </th>
        <td>
            <input type="text" id="DMS-Docket-InventorName" title="Please enter an inventor name!" />
        </td>
    </tr>
    <tr>
        <th>
            Type of App:
        </th>
        <td>
            <input type="text" id="DMS-Docket-AppType" title="Please enter an app type!" />
        </td>
    </tr>
    <tr>
        <td colspan="2" style="text-align: left">
            <sub style="color: Red">Docket Name will be generated on confirmation</sub>
        </td>
    </tr>
</table>
