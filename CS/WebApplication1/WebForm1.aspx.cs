using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.XtraReports.Web;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

namespace WebApplication1 {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_PreRender(object sender, EventArgs e) {

        }
        protected void Page_PreLoad(object sender, EventArgs e) {
        }

        protected void ASPxButton1_Click(object sender, EventArgs e) {
        }

        protected void ReportViewer1_Unload(object sender, EventArgs e) {
        }

        protected void ReportToolbar1_Init(object sender, EventArgs e) {
            
        }

        protected void ReportViewer1_CacheReportDocument(object sender, CacheReportDocumentEventArgs e) {
            
        }

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void ASPxDocumentViewer1_CacheReportDocument(object sender, CacheReportDocumentEventArgs e) {
            using (System.IO.MemoryStream ms =e.SaveDocumentToMemoryStream()){
                Session["Report"] = ms.ToArray();
            }
            
        }
    }
}
