﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AJAXServerControls
{
    public partial class _02_UpdatePanelErrors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                throw new ApplicationException("Обновление страницы потерпело неудачу!");
            }
        }
    }
}