using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPR_registration.Classes
{
    public class ActivistCreator
    {
        public static Activist CreateActivist(dynamic ActivistData)
        {
            Activist newActivist = new Activist();

            newActivist.userName = ActivistData.userName;
            newActivist.email = ActivistData.email;
            newActivist.address = ActivistData.address;
            newActivist.phoneNumber = ActivistData.phoneNumber;
            newActivist.password = ActivistData.password;

            return newActivist;
        }
    }
}
