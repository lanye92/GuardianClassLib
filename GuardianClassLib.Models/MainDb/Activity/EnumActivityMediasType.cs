using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianClassLib.Models.MainDb.Activity
{
    public enum EnumActivityMediasType
    {
        /// <summary>
        /// 文本
        /// </summary>
        TEXT = 1,

        /// <summary>
        /// 图片
        /// </summary>
        PICTURE = 2,

        /// <summary>
        /// 音频
        /// </summary>
        AUDIO = 3,

        /// <summary>
        /// 视频
        /// </summary>
        VIDEO = 4,

        /// <summary>
        /// 海报
        /// </summary>
        POSTER = 5,
    }
}
