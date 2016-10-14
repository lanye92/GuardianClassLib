using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianClassLib.Models.RspModel
{
    public enum EnumActionFlag
    {
        /// <summary>
        /// 成功
        /// </summary>
        success,
        /// <summary>
        /// 授权失败
        /// </summary>
        noauth,
        /// <summary>
        /// 执行失败
        /// </summary>
        error,
        /// <summary>
        /// 未绑定用户
        /// </summary>
        unbinduser,
        /// <summary>
        /// 需要先绑定用户的
        /// </summary>
        binduser,
    }
}
