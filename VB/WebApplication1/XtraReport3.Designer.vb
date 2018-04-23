Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication1
	Partial Public Class XtraReport3
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
			Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' detailBand1
			' 
			Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.detailBand1.HeightF = 281.3333F
			Me.detailBand1.Name = "detailBand1"
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.HeightF = 57.29167F
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.HeightF = 54.13154F
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' GroupFooter1
			' 
			Me.GroupFooter1.HeightF = 3.04688F
			Me.GroupFooter1.KeepTogether = True
			Me.GroupFooter1.Name = "GroupFooter1"
			' 
			' Title
			' 
			Me.Title.BackColor = System.Drawing.Color.Transparent
			Me.Title.BorderColor = System.Drawing.Color.Black
			Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.Title.BorderWidth = 1F
			Me.Title.Font = New System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold)
			Me.Title.ForeColor = System.Drawing.Color.Maroon
			Me.Title.Name = "Title"
			' 
			' FieldCaption
			' 
			Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
			Me.FieldCaption.BorderColor = System.Drawing.Color.Black
			Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.FieldCaption.BorderWidth = 1F
			Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold)
			Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
			Me.FieldCaption.Name = "FieldCaption"
			' 
			' PageInfo
			' 
			Me.PageInfo.BackColor = System.Drawing.Color.Transparent
			Me.PageInfo.BorderColor = System.Drawing.Color.Black
			Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.PageInfo.BorderWidth = 1F
			Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold)
			Me.PageInfo.ForeColor = System.Drawing.Color.Black
			Me.PageInfo.Name = "PageInfo"
			' 
			' DataField
			' 
			Me.DataField.BackColor = System.Drawing.Color.Transparent
			Me.DataField.BorderColor = System.Drawing.Color.Black
			Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.DataField.BorderWidth = 1F
			Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10F)
			Me.DataField.ForeColor = System.Drawing.Color.Black
			Me.DataField.Name = "DataField"
			Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			' 
			' xrLabel1
			' 
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(54.16667F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(118.75F, 281.3333F)
			Me.xrLabel1.Text = "xrLabel1"
'			Me.xrLabel1.HtmlItemCreated += New DevExpress.XtraReports.UI.HtmlEventHandler(Me.xrLabel1_HtmlItemCreated);
			' 
			' XtraReport3
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.detailBand1, Me.topMarginBand1, Me.bottomMarginBand1, Me.GroupFooter1})
			Me.DisplayName = "Maintenance Plan"
			Me.Extensions.Add("DataSerializationExtension", "XafReport")
			Me.Extensions.Add("DataEditorExtension", "XafReport")
			Me.Extensions.Add("ParameterEditorExtension", "XafReport")
			Me.Font = New System.Drawing.Font("Segoe UI", 9.75F)
			Me.Margins = New System.Drawing.Printing.Margins(100, 100, 57, 54)
			Me.ReportPrintOptions.DetailCountOnEmptyDataSource = 40
			Me.Scripts.OnBeforePrint = "xafReport1_BeforePrint"
			Me.Scripts.OnParametersRequestBeforeShow = "xafReport1_ParametersRequestBeforeShow"
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
			Me.Version = "13.2"
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private detailBand1 As DevExpress.XtraReports.UI.DetailBand
		Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
		Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
		Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
		Private Title As DevExpress.XtraReports.UI.XRControlStyle
		Private FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
		Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
		Private DataField As DevExpress.XtraReports.UI.XRControlStyle
		Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
