using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        XmlConfigurator.Configure();

        var logger = LogManager.GetLogger("GreetingsLogger");

        logger.Info("ASP.NET");
       
    }
}