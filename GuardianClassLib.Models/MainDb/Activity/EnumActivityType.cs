using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianClassLib.Models.MainDb.Activity
{
    public enum EnumActivityType
    {
        /// <summary>
        /// 单品单图
        /// </summary>
        [Description("单品单图")]
        ONEPICTURE = 1,

        /// <summary>
        /// 单品多图
        /// </summary>
        [Description("单品多图")]
        SOMEPICTURE = 2,

        /// <summary>
        /// 主题
        /// </summary>
        [Description("主题")]
        THEME = 3
    }
}
