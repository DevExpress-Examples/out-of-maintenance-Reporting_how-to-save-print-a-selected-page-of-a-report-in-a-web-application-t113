<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v13.2, Version=13.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.XtraReports.v13.2.Web, Version=13.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<%@ Register assembly="WebApplication1" namespace="WebApplication1" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
<script>
    function printpage() {
        window.print()
    }
</script>
    </head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;&nbsp;&nbsp;<dx:ASPxDocumentViewer 
            ID="ASPxDocumentViewer1" runat="server" 
            ReportTypeName="WindowsFormsApplication1.XtraReport3" 
            oncachereportdocument="ASPxDocumentViewer1_CacheReportDocument">
<StylesViewer>
<BookmarkSelectionBorder BorderColor="Gray" BorderStyle="Dashed" BorderWidth="3px"></BookmarkSelectionBorder>
</StylesViewer>

<StylesSplitter>
<Pane>
<Paddings Padding="16px"></Paddings>
</Pane>
</StylesSplitter>
            <ToolbarItems>
                <dx:ReportToolbarButton ItemKind="Search" />
                <dx:ReportToolbarSeparator />
                <dx:ReportToolbarButton ItemKind="PrintReport" />
                <dx:ReportToolbarButton ItemKind="PrintPage" />
                <dx:ReportToolbarSeparator />
                <dx:ReportToolbarButton Enabled="False" ItemKind="FirstPage" />
                <dx:ReportToolbarButton Enabled="False" ItemKind="PreviousPage" />
                <dx:ReportToolbarLabel ItemKind="PageLabel" />
                <dx:ReportToolbarComboBox ItemKind="PageNumber" Width="65px">
                </dx:ReportToolbarComboBox>
                <dx:ReportToolbarLabel ItemKind="OfLabel" />
                <dx:ReportToolbarTextBox ItemKind="PageCount" />
                <dx:ReportToolbarButton ItemKind="NextPage" />
                <dx:ReportToolbarButton ItemKind="LastPage" />
                <dx:ReportToolbarSeparator />
                <dx:ReportToolbarButton ItemKind="SaveToDisk" />
                <dx:ReportToolbarButton ItemKind="SaveToWindow" />
                <dx:ReportToolbarComboBox ItemKind="SaveFormat" Width="70px">
                    <Elements>
                        <dx:ListElement Value="pdf" />
                        <dx:ListElement Value="xls" />
                        <dx:ListElement Value="xlsx" />
                        <dx:ListElement Value="rtf" />
                        <dx:ListElement Value="mht" />
                        <dx:ListElement Value="html" />
                        <dx:ListElement Value="txt" />
                        <dx:ListElement Value="csv" />
                        <dx:ListElement Value="png" />
                    </Elements>
                </dx:ReportToolbarComboBox>
                <dx:ReportToolbarButton Name="ExportCurrentPage" Text="ExportCurrentPage" />
            </ToolbarItems>
            <ClientSideEvents ToolbarItemClick="function(s, e) {
debugger;
	  if(e.item.name == &quot;ExportCurrentPage&quot;)
    {
        window.location.href = &quot;ExportReport.aspx?ExportPage=&quot;+s.GetToolbar().pageIndex
    }
}" />
        </dx:ASPxDocumentViewer>
    </div>
    </form>
    &nbsp;

</body>
</html>
