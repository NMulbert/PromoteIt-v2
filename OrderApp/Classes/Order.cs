using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Classes
{
    public class Order
    {
        [JsonProperty(propertyName: "id")]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string userName {get;set;}
        public string address { get; set; }
        public string productName { get; set; }
        public int price { get; set; } = 0;
        public string compName { get; set; }
        public bool shipped { get; set; } = false;

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
