﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepeaterSamples._02_GridViewColumns
{
    public partial class _02_BoundFieldSample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = BrowsersDatabase.Browsers;
            GridView1.DataBind();
        }
    }
}