<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EmployeeSkillForm.aspx.cs" Inherits="Report_EmployeeSkillForm" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <asp:ObjectDataSource ID="EmployeeSkillODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetEmployeeBySkill" TypeName="WSSystem.BLL.WSController"></asp:ObjectDataSource>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%">
        <LocalReport ReportPath="Report\EmployeeSkillsReport.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="EmployeeSkillODS" Name="EmployeeSkillsDS" />
            </DataSources>
        </LocalReport>
</rsweb:ReportViewer>

</asp:Content>

