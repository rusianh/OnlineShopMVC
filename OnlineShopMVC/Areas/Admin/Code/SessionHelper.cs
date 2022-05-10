using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShopMVC.Areas.Admin.Code
{
    public class SessionHelper
    {
        public static void SetSession(UserSession session)
        {
            HttpContext.Current.Session["loginSession"] = session;
        }
        public static UserSession GetSession()
        {
            var sesstion = HttpContext.Current.Session["loginSession"];
            if(sesstion == null) return null;
            else return sesstion as UserSession;
        }
    }
}