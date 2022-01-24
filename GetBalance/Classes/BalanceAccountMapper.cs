using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBalance.Classes
{
    public  class BalanceAccountMapper
    {
        public static BalanceAccount MapUserData(dynamic userData)
        {
            BalanceAccount account = new BalanceAccount();
            account.userName = userData.userName;

            return account;
        }
    }
}
