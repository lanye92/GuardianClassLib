using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianClassLib.Models.RspModel
{
    public class PageDataResult<T> : PageResultBase
    {
        [JsonProperty(PropertyName = "data")]
        public T Data { get; set; }
    }
}
