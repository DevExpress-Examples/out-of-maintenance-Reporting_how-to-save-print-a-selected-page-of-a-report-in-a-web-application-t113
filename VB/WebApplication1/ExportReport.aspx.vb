Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.IO
Imports DevExpress.XtraPrinting

Namespace WebApplication1
	Partial Public Class ExportReport
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Session("Report") IsNot Nothing Then
				Using ms As New MemoryStream(TryCast(Session("Report"), Byte()))
					ms.Seek(0, SeekOrigin.Begin)
					Dim ps As New PrintingSystem()
					ps.LoadDocument(ms)
					Dim opts As New PdfExportOptions()
					opts.ShowPrintDialogOnOpen = False '<= Set to true to open print dialog by default
					opts.PageRange = (Convert.ToInt32(Me.Request("ExportPage"))+1).ToString()
					Using outStream As New MemoryStream()
						ps.ExportToPdf(outStream, opts)
						outStream.Seek(0, SeekOrigin.Begin)
						Dim report() As Byte = outStream.ToArray()
						Page.Response.ContentType = "application/pdf"
						Page.Response.Clear()
						Page.Response.OutputStream.Write(report, 0, report.Length)
						Page.Response.End()
					End Using
				End Using
			End If
		End Sub
	End Class
End Namespace