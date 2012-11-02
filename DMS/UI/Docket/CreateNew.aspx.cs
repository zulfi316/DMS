using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer.BLDocket;

namespace UI.Docket
{
    public partial class CreateNew : System.Web.UI.Page
    {
        protected string docketNumber;

        protected void Page_Load(object sender, EventArgs e)
        {
            docketNumber = BLDocketHelper.Instance.DocketNumber;
        }
    }
}