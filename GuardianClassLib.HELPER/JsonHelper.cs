using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianClassLib.HELPER
{
    public static class JsonHelper
    {
        #region Object ParseTo Json

        public static string ToJson<T>(this T ent)
        {
            var idtc = new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" }; //时间处理类
            var set = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Include//包含空值
            };
            set.Converters.Add(idtc);

            var reqjson = JsonConvert.SerializeObject(ent, Newtonsoft.Json.Formatting.None, set);
            return Newtonsoft.Json.JsonConvert.SerializeObject(ent, set);
        }
        #endregion


    }
}
