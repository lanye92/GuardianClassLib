using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace GuardianClassLib.Models.RspModel
{
    public class PageResultBase
    {
        private EnumActionFlag _flag;
        public EnumActionFlag flag
        {
            set
            {
                _flag = value;
            }
        }

        [JsonProperty(PropertyName = "status")]
        public string Status { get { return _flag.ToString(); } }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }


        public HttpResponseMessage ResponseMessage()
        {
            var str = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            return new HttpResponseMessage { Content = new StringContent(str, Encoding.UTF8, "application/json") };
        }
    }
}
