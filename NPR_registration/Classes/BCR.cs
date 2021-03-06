using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPR_registration.Classes
{
    public class BCR
    {
        [JsonProperty(PropertyName = "id")]
        public Guid id { get; set; } = Guid.NewGuid();
        public string compName { get; set; }
        public string email { get; set; }
        public string website { get; set; }
        public string password { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
