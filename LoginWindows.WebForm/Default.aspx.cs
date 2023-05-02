using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginWindows.WebForm
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var principal = (WindowsPrincipal)User;
            var x = Request.IsAuthenticated;
            var identity = (WindowsIdentity)User.Identity;
            var token = identity.Token;
        }
    }
}