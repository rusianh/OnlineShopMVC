﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShopMVC.Areas.Admin.Code
{   
    [Serializable] // Tuần tự hóa ra nhị phân
    public class UserSession
    {
        public string UserName { get; set; }
    }
}