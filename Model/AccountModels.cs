using Model.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AccountModels
    {
        private OnlineShopDbContext context = null;
        public AccountModels()
        {
            context = new OnlineShopDbContext();
        }
        public bool Login(string _username, string _password)
        {
            object[] sqlParams =  
            {
                new SqlParameter("@UserName", _username),
                new SqlParameter("password", _password)
            };
            bool res = context.Database.SqlQuery<bool>("Sp_Account_Login @UserName,@Password", sqlParams).SingleOrDefault();
            return res;
        }
    }
}
