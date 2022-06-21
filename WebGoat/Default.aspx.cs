using System;
using System.Web;
using System.Web.UI;
using OWASP.WebGoat.NET.App_Code.DB;
using OWASP.WebGoat.NET.App_Code;

namespace OWASP.WebGoat.NET
{
	public partial class Default : System.Web.UI.Page
	{
        private IDbProvider du = Settings.CurrentDbProvider;
        
        protected void ButtonProceed_Click(object sender, EventArgs e)
        {
            Response.Redirect("RebuildDatabase.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}

