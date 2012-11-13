<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateNewProject.aspx.cs" Inherits="UI.Project.CreateNewProject" %>

<table style="text-align: right">
    <tr>
        <th>
            Country:
        </th>
        <td>
        <select id="DMS-Project-Country">
            <option>select a Country</option>
            <% 
                foreach (UI.UICountry.Country country in countryList)
                {%>
                <option><%=country.Name%></option>
            <%} %>
        </select> 
        </td>
    </tr>
    <tr>
        <th>
            Drafter:
        </th>
        <td>
            <input type="text" id="DMS-Project-DrafterName" title="Please enter an Drafter name!" />
        </td>
    </tr>
    <tr>
        <th>
            Type of Project:
        </th>
        <td>
            <input type="text" id="DMS-Project-ProjType" title="Please enter a project type!" />
        </td>
    </tr>
    <tr>
        <th>
            Billing:
        </th>
        <td>
            <input type="text" id="DMS-Project-Bill" title="Please enter invoice number!" />
        </td>
    </tr>
    <tr>
        <td colspan="2" style="text-align: left">
            <sub style="color: Red">Project Number will be generated on confirmation</sub>
        </td>
    </tr>
</table>