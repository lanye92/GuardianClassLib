using GuardianClassLib.Models.MainDb;
using GuardianClassLib.Models.RspModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GuardianClassLib.Api.Controllers
{
    [RoutePrefix("userinfo")]
    public class UserInfoController : ApiController
    {
        private readonly static BLL.UserInfoManage _bll = new BLL.UserInfoManage();

        #region 添加用户信息

        [HttpGet]
        [Route("add")]
        public PageDataResult<UserInfo> AddUserInfo()

        {
            var ent = new UserInfo() { UserName = "18238816270", Password = "123456", PkId = Guid.NewGuid() };
            var result= _bll.Insert(ent);
            return new PageDataResult<UserInfo> { flag = EnumActionFlag.success, Data = result };
        }
        #endregion


    }
}
