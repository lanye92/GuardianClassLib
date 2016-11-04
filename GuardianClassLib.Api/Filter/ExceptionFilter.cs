using GuardianClassLib.HELPER;
using GuardianClassLib.Models.RspModel;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Web.Http.Filters;

namespace GuardianClassLib.Api.Filter
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
#if DEBUG
            //base.OnException(actionExecutedContext);
            //return;
#endif
            var body = "";
            var isr = System.Web.HttpContext.Current.Request.InputStream;
            if (isr.Length > 0)
            {
                var sr = new StreamReader(isr, Encoding.UTF8);
                body = sr.ReadToEnd();
            }
            var error = "[接口错误]" + actionExecutedContext.Exception.Message + @"
" + actionExecutedContext.Exception.StackTrace;
            var errorData = new
            {
                url = actionExecutedContext.Request.RequestUri,
                header = actionExecutedContext.Request.Headers,
                query = actionExecutedContext.Request.GetQueryNameValuePairs(),
                errorStr = error,
                body = body
            };
            Logger.WriteError(errorData.ToJson());
            var ent = new PageResultBase
            {
                flag = EnumActionFlag.error,
                Message = "服务器繁忙，请稍后重试"
            };
            actionExecutedContext.Response = ent.ResponseMessage();

        }
    }
}