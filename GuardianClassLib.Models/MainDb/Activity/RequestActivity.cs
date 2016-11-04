using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianClassLib.Models.MainDb.Activity
{
    public class RequestActivity
    {
        /// <summary>
        /// 活动编号
        /// </summary>
        public Guid ActiveID { get; set; }

        /// <summary>
        /// 活动分类
        /// 单品单图、单品多图、主题
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// 活动类别名称
        /// 全部
        /// 今日特卖
        /// 周周有礼
        /// 68节
        /// Response 需要中文
        /// </summary>
        public string ActiveName { get; set; }

        /// <summary>
        /// 活动类别缩略图
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 活动标题
        /// </summary>
        public string ActiveTitle { get; set; }

        /// <summary>
        /// 活动描述
        /// </summary>
        public string ActiveContents { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        public DateTime BeginTime { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 是否过期的
        /// 根据EndTime判断
        /// </summary>
        public bool Disabled { get; set; }




        /// <summary>
        /// 商品ID
        /// </summary>
        public int CommodityID { get; set; }
        /// <summary>
        /// 料号
        /// </summary>
        public string SkuKey { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Sku { get; set; }
        /// <summary>
        /// 缩略图
        /// </summary>
        public string MainPhoto { get; set; }
        /// <summary>
        /// 平台供货价
        /// </summary>
        public decimal PublicSupplyPrice { get; set; }
        /// <summary>
        /// 市场价
        /// </summary>
        public decimal MarketPrice { get; set; }
        /// <summary>
        /// 推荐售价
        /// </summary>
        public string RecommendSalePrice { get; set; }
        /// <summary>
        /// 补贴
        /// </summary>
        public decimal Subsidies { get; set; }
        /// <summary>
        /// 活动的描述内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 买家补贴
        /// </summary>
        public decimal BuyerSubsidies { get; set; }
        /// <summary>
        /// 图片s
        /// </summary>
        public string Photos { get; set; }
        /// <summary>
        /// 推荐理由
        /// </summary>
        public string RecommendText { get; set; }
        /// <summary>
        /// 商品的正文信息
        /// </summary>
        public string Context { get; set; }
        /// <summary>
        /// 是否锁定售价
        /// </summary>
        public bool IsLockPrice { get; set; }

        /// <summary>
        /// 素材地址
        /// </summary>
        public string PhotoAddress { get; set; }

        /// <summary>
        /// 最低售价
        /// </summary>
        public decimal LowSalePrice { get; set; }

        /// <summary>
        /// 最高售价
        /// </summary>
        public decimal HighSalePrice { get; set; }
        /// <summary>
        /// 店铺佣金
        /// </summary>
        public decimal SilverShopFee { get; set; }
        /// <summary>
        /// 可赚
        /// </summary>
        public decimal CanGetPrice { get; set; }

        public string ShopGoodsId { get; set; }

        /// <summary>
        /// 商品活动宣传图
        /// </summary>
        public string ActiveCommodityPhoto { get; set; }

        /// <summary>
        /// 置顶数字
        /// </summary>
        public int TPType { get; set; }

        /// <summary>
        /// 商品销量
        /// </summary>
        public int SaleAmount { get; set; }
        public string Icon2 { get; set; }
        public string WarehouseName { get; set; }
    }
}
