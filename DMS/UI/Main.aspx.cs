using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class Main : System.Web.UI.Page
    {
        public List<string[]> docketInfo;
        protected void Page_Load(object sender, EventArgs e)
        {
            docketInfo = BusinessLayer.Docket.BLDocketHelper.Instance.GetDocketsForUserId(string.Empty);
        }
    }
}