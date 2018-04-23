using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using DevExpress.XtraPrinting;

namespace WebApplication1 {
    public partial class ExportReport : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if(Session["Report"] != null) {
                using(MemoryStream ms = new MemoryStream(Session["Report"] as byte[])) {
                    ms.Seek(0, SeekOrigin.Begin);
                    PrintingSystem ps = new PrintingSystem();
                    ps.LoadDocument(ms);
                    PdfExportOptions opts = new PdfExportOptions();
                    opts.ShowPrintDialogOnOpen = false;//<= Set to true to open print dialog by default
                    opts.PageRange = (Convert.ToInt32(this.Request["ExportPage"])+1).ToString();
                    using(MemoryStream outStream = new MemoryStream()) {
                        ps.ExportToPdf(outStream, opts);
                        outStream.Seek(0, SeekOrigin.Begin);
                        byte[] report = outStream.ToArray();
                        Page.Response.ContentType = "application/pdf";
                        Page.Response.Clear();
                        Page.Response.OutputStream.Write(report, 0, report.Length);
                        Page.Response.End();
                    }
                }
            }
        }
    }
}