using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianClassLib.Models.MainDb.Activity
{
    /// <summary>
    /// acthome.html response object
    /// </summary>

    public class Activitiy
    {
        /// <summary>
        /// 活动编号
        /// </summary>
        public string PkId { get; set; }

        /// <summary>
        /// 活动分类
        /// 单品单图、单品多图、主题
        /// </summary>
        public EnumActivityType Type { get; set; }

        /// <summary>
        /// 活动类别名称
        /// 全部
        /// 今日特卖
        /// 周周有礼
        /// 68节
        /// Response 需要中文
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 活动类别缩略图
        /// </summary>
        public string Thumb { get; set; }

        /// <summary>
        /// 活动标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        public DateTime StartTime { get; set; }

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
        /// 活动倒计描述
        /// </summary>
        public string CountDownStr
        {
            get
            {
                return this.CalcActivityCountDown(this.StartTime, this.EndTime);
            }
        }

        /// <summary>
        /// 计算活动时间
        /// </summary>
        /// <param name="_s"></param>
        /// <param name="_e"></param>
        /// <returns></returns>
        private string CalcActivityCountDown(DateTime? _s, DateTime? _e)
        {
            var start = _s ?? DateTime.Now;
            var end = _e ?? DateTime.Now;
            if (start > DateTime.Now)
            {
                return start.ToString("yy-MM-dd HH:mm") + "开始";
                var mins = (start - DateTime.Now).TotalMinutes;
                if (mins < 1)
                {
                    return Convert.ToInt32((start - DateTime.Now).TotalSeconds) + "秒后开始";
                }
                var hours = mins / 60;
                if (hours < 1)
                {
                    return Convert.ToInt32(mins) + "分钟后开始";
                }
                var days = hours / 24;
                if (days < 1)
                {
                    return Convert.ToInt32(hours) + "小时后开始";
                }
                return Convert.ToInt32(days) + "天后开始";
            }
            if (end > DateTime.Now)
            {
                return end.ToString("yy-MM-dd HH:mm") + "结束";
                var mins = (end - DateTime.Now).TotalMinutes;
                if (mins < 1)
                {
                    return "活动仅剩" + Convert.ToInt32((end - DateTime.Now).TotalSeconds) + "秒";
                }
                var hours = mins / 60;
                if (hours < 1)
                {
                    return "活动仅剩" + Convert.ToInt32(mins) + "分钟";
                }
                var days = hours / 24;
                if (days < 1)
                {
                    return "活动仅剩" + Convert.ToInt32(hours) + "小时";
                }
                return "活动仅剩" + Convert.ToInt32(days) + "天";
            }
            return "活动已结束";
        }

    }
}
