using GuardianClassLib.Models.MainDb;
using GuardianClassLib.Models.MainDb.Activity;
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
            var result = _bll.Insert(ent);
            return new PageDataResult<UserInfo> { flag = EnumActionFlag.success, Data = result };


        }
        #endregion

        #region  测试异常捕获

        [HttpGet]
        [Route("testException")]
        public PageResultBase TestExceptionFilter() {
            var numberOne = 10;
            var numberTow = 0;
            var result = numberOne / numberTow;
            return new PageResultBase { flag = EnumActionFlag.success, Message = "" };
        }
        #endregion

        #region 测试活动创建

        [HttpGet]
        [Route("testActivity")]
        public PageDataResult<RequestActivity> TestCreateActivity()
        {
            var act = new RequestActivity {
                ActiveID=Guid.NewGuid(),
                ActiveTitle="测试活动",
                ActiveName="我们做游戏吧",
                ActiveCommodityPhoto="",
                ActiveContents="",
                BuyerSubsidies=0.00M,
                IsLockPrice=false,
                CanGetPrice=0.00M,
                CommodityID=1,
                Content="",
                HighSalePrice=0.00M,
                Context="",
                SilverShopFee=0.02M,
                Icon="",
                Icon2="",
                LowSalePrice=0.00M,
                Subsidies=0.02M,
                MainPhoto="",
                MarketPrice=0.23M,
                PhotoAddress="",
                Photos="",
                PublicSupplyPrice=0213.93M,
                RecommendSalePrice= "",
                RecommendText="",
                SaleAmount=10,
                ShopGoodsId="",
                Sku="",
                SkuKey="",
                TPType=10,
                TypeName="",
                WarehouseName="",
                BeginTime=DateTime.Now,
                EndTime=DateTime.Now,
                Disabled=false


            };
            var result = _bll.Create(act);
            return new PageDataResult<RequestActivity> { flag = EnumActionFlag.success, Data = result };
        }
        #endregion


    }
}
