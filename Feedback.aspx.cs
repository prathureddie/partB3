using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppLAblast
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text) == true && String.IsNullOrWhiteSpace(txtEmail.Text) == true
     && String.IsNullOrWhiteSpace(txtMessage.Text) == true)
            {
                lblResult.Text = "Fields cannot be left blank !!";
                return;
            }

            DbOperations obj = new DbOperations();
            bool result = obj.Insert(txtName.Text, txtEmail.Text, txtMessage.Text);

            if (result == true)
            {
                lblResult.Text = "Feedback Submitted";
                txtName.Text = "";
                txtEmail.Text = "";
                txtMessage.Text = "";
            }
            else
                lblResult.Text = "Failed !!";
        }

    }
}