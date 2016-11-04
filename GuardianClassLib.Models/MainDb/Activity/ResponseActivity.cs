using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianClassLib.Models.MainDb.Activity
{ 
    public class ResponseActivity:Activitiy
    {
        /// <summary>
        /// 活动媒介
        /// 列表媒介Type只包含：TEXT=1,PICTURE=2
        /// </summary>
        public List<ActivityMedias> ActivityMedias { get; set; }
        /// <summary>
        /// 活动描述
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 商品编号
        /// </summary>
        public int GoodsId { get; set; }
    }
}
