﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppTest
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {

                Response.Write("Click Button to get response NOW!!! Line added by local");
               
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {

            Response.Write("Samuel: Developer");
        }
    }
}