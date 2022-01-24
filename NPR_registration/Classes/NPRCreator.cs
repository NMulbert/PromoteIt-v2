using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPR_registration.Classes
{
    public class NPRCreator
    {
        public static NPR CreateNPR(dynamic data)
        {
            NPR newNPR = new NPR();
            newNPR.orgName = data.orgName;
            newNPR.email=data.email;
            newNPR.website=data.website;
            newNPR.password=data.password;

            return newNPR;
        }
    }
}
