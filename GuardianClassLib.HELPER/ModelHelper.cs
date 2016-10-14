using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianClassLib.HELPER
{
    public class ModelHelper
    {
        #region Modal赋值,ent赋值给oe

        /// <summary>
        /// Modal赋值,ent赋值给oe
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ent"></param>
        /// <param name="oe"></param>
        public static void SetModal<T>(T ent, T oe)
        {
            var eType = ent.GetType();
            foreach (var a in eType.GetProperties())
            {
                if (a.Name.ToLower().StartsWith("pk")) continue;
                var val = a.GetValue(ent);
                if (val == null || string.IsNullOrEmpty(val.ToString().Trim())) continue;
                a.SetValue(oe, val);
            }
        }
        #endregion


    }
}
