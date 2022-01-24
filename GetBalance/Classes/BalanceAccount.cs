using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBalance.Classes
{
    public class BalanceAccount
    {
        [JsonProperty(PropertyName = "id")]
        public Guid id { get; set; } = Guid.NewGuid();
        public string userName { get; set; }
        public int userBalance { get; set; } = 0;
    }
}
