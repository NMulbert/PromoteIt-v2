using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPR_registration.Classes
{
    public class NPR
    {
        [JsonProperty(PropertyName = "id")]
        public Guid id { get; set; } = Guid.NewGuid();
        public string orgName { get; set; }
        public string email { get; set; }
        public string website { get; set; }
        public string password { get; set; }
        public string[] campaigns { get; set; }
    }
}
