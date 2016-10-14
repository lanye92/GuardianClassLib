using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianClassLib.Models.RspModel
{
    /// <summary>
    /// 记录集
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PageListResult<T> : PageResultBase
    {
        [JsonProperty(PropertyName = "data")]
        public List<T> Data { get; set; }

        [JsonProperty(PropertyName = "records")]
        public int Records { get; set; }
    }
}
