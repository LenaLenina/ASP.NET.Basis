﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepeaterSamples
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] arr = new string[5];
            arr[0] = "Item 1";
            arr[1] = "Item 2";
            arr[2] = "Item 3";
            arr[3] = "Item 4";
            arr[4] = "Item 5";
            Repeater1.DataSource = arr;
            Repeater1.DataBind();
        }
    }
}