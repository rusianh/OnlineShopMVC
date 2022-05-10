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

        }
        public bool Login (string _username, int _password)
        {
            var sqlParams = new SqlParameter[]
            {
                new SqlParameter("@UserName", _username),
                new SqlParameter("password", _password)
            };
            var res = context.Database.SqlQuery<bool>("Sp_Account_Login @UserName, @Password",sqlParams).SingleOrDefault();
            return res;
        }
    }
}
