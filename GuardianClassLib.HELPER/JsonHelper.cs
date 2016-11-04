using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml;

namespace GuardianClassLib.HELPER
{
    public static class JsonHelper
    {
        #region JsonOperation

        #region JsonSerializer

        public static string JsonSerializer<T>(this T ent)
        {
            var idtc = new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" }; //时间处理类
            var set = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Include,//包含空值
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            set.Converters.Add(idtc);

            var reqjson = JsonConvert.SerializeObject(ent, Newtonsoft.Json.Formatting.None, set);
            return Newtonsoft.Json.JsonConvert.SerializeObject(ent, set);
        }
        #endregion

        #region JsonDeserialize

        public static T JsonDeserialize<T>(string jsonStr)
        {
            var jObj = JObject.Parse(jsonStr);
            var jReq = jObj["request"].ToString();
            var obj = JsonConvert.DeserializeObject<T>(jReq);
            return obj;
        }

        #endregion
        #endregion

        #region XmlOperation

        #region  SerializeToInnerXml

        /// <summary>
        /// 序列化成XML返回字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="res"></param>
        /// <param name="rootName"></param>
        /// <returns></returns>
        public static string SerializeToInnerXml<T>(T res, string rootName)
        {
            var idtc = new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" }; //时间处理类

            var set = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,//忽略
                DateTimeZoneHandling = DateTimeZoneHandling.Local,//本地时间
                NullValueHandling = NullValueHandling.Ignore//包含空值

            };
            set.Converters.Add(idtc);

            var reqjson = JsonConvert.SerializeObject(res, Newtonsoft.Json.Formatting.None, set) + "}";
            var xd =
                JsonConvert.DeserializeXmlNode("{'?xml': {'@version': '1.0','@encoding': 'utf-8'},'" + rootName + "':" + reqjson);
            return xd.InnerXml;
        }
        #endregion

        #region  DeserializeObjectXmlRequest

        /// <summary>
        /// XML反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmlRequest"></param>
        /// <returns></returns>
        public static T DeserializeObjectXmlRequest<T>(string xmlRequest)
        {
            var xd = new XmlDocument();
            xd.LoadXml(xmlRequest);
            var jsonStr = JsonConvert.SerializeObject(xd);
            var jObj = JObject.Parse(jsonStr);
            var jReq = jObj["request"].ToString();
            var obj = JsonConvert.DeserializeObject<T>(jReq);
            return obj;
        }

        /// <summary>
        /// XML节点发序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmlRequest"></param>
        /// <param name="rootName"></param>
        /// <returns></returns>
        public static T DeserializeObjectXmlRequest<T>(string xmlRequest, string rootName = "")
        {
            var xd = new XmlDocument();
            xd.LoadXml(xmlRequest);
            var jsonStr = JsonConvert.SerializeObject(xd);
            var jObj = JObject.Parse(jsonStr);
            var jReq = string.IsNullOrEmpty(rootName) ? jObj.ToString() : jObj[rootName].ToString();
            var obj = JsonConvert.DeserializeObject<T>(jReq);
            return obj;
        }
        #endregion
        #endregion

        #region 序列化成HttpResponseMessage对象

        public static HttpResponseMessage ToJson(string obj)
        {
            var result = new HttpResponseMessage { Content = new StringContent(obj, Encoding.GetEncoding("UTF-8"), "application/json") };
            return result;
        }

        public static HttpResponseMessage ToXml(string obj)
        {
            var result = new HttpResponseMessage { Content = new StringContent(obj, Encoding.GetEncoding("UTF-8"), "text/xml") };
            return result;
        }

        public static HttpResponseMessage ToHtml(string obj)
        {
            var result = new HttpResponseMessage { Content = new StringContent(obj, Encoding.GetEncoding("UTF-8")) };
            return result;
        }

        public static HttpResponseMessage ToJson(Object obj)
        {
            string str;
            if (obj is String || obj is Char)
            {
                str = obj.ToString();
            }
            else
            {
                var serializer = new JavaScriptSerializer();
                str = serializer.Serialize(obj);
            }
            var result = new HttpResponseMessage { Content = new StringContent(str, Encoding.GetEncoding("UTF-8"), "application/json") };
            return result;
        }
        #endregion

    }
}
