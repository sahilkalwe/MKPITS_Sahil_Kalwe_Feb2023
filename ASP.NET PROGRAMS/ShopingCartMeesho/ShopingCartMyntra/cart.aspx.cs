﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ShopingCartMyntra
{
    public partial class cart : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string prodid = Request.QueryString["prodid"].ToString();
            Session["prodid"] = prodid;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Checkmno.aspx");
        }
    }
    }
