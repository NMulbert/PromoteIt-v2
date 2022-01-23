using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPR_registration.Classes
{
    public class Activist
    {
        [JsonProperty(PropertyName = "id")]
        public Guid id { get; set; } = Guid.NewGuid();
        public string userName { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public string password { get; set; }
        public List<string> products { get; set; }


        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
