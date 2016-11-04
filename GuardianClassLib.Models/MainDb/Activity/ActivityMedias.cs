using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianClassLib.Models.MainDb.Activity
{
    /// <summary>
    /// 活动媒介
    /// </summary>
    public class ActivityMedias
    {
        /// <summary>
        /// 媒介编号
        /// </summary>
        public string PkId { get; set; }

        /// <summary>
        /// 媒介内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 媒介类型
        /// </summary>
        public EnumActivityMediasType Type { get; set; }
    }
}
