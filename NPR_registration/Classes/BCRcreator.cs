using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPR_registration.Classes
{
    public class BCRcreator
    {
        public static BCR CreateBCR(dynamic data)
        {

            dynamic BCRdata = data;

            BCR newBCR = new BCR();
            newBCR.compName = BCRdata.compName;
            newBCR.email = BCRdata.email;
            newBCR.website = BCRdata.website;
            newBCR.password = BCRdata.password;

            return newBCR;
        }
    }
}
