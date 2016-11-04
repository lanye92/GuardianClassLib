using AutoMapper;
using GuardianClassLib.HELPER.ModelConvert;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianClassLib.HELPER
{
    /// <summary>
    /// AutoMapper
    /// </summary>
    public static class AutoMapperHelper
    {
        #region 配置映射规则  

        /// <summary>
        /// 注册 Mapper 转换规则约定 
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TDestination"></typeparam>
        public static void VoidConfigure<TSource, TDestination>()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<TSource, TDestination>());
            // Mapper.CreateMap<TSource, TDestination>();//TDestination只需要约定基础类型，不要要写成List<xxxxModel>这种形式  
        }
        #endregion

        #region 实体映射扩展方法 
        /// <summary>
        /// 普通实体转换
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TDestination"></typeparam>
        /// <param name="ent"></param>
        /// <returns></returns>
        public static TDestination GetEntity<TSource, TDestination>(this TSource ent)
        {
            return Mapper.Map<TDestination>(ent);
        }

        /// <summary>  
        /// 将 IDataReader 转为实体对象  
        /// </summary>  
        /// <typeparam name="T"></typeparam>  
        /// <param name="dr"></param>  
        /// <returns></returns>  
        public static T GetEntityByDataReader<T>(this IDataReader dr)
        {
            return Mapper.Map<T>(dr);
        }
        /// <summary>  
        /// 将 DataSet 转为实体对象  
        /// </summary>  
        /// <typeparam name="T"></typeparam>  
        /// <param name="ds"></param>  
        /// <returns></returns>  
        public static T GetEntity<T>(this DataSet ds)
        {
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                return default(T);
            var dr = ds.Tables[0].CreateDataReader();
            if (dr.HasRows)
            {
                return Mapper.Map<T>(dr);
            }

            return default(T);
        }
        /// <summary>  
        /// 将 DataTable 转为实体对象  
        /// </summary>  
        /// <typeparam name="T"></typeparam>  
        /// <param name="dt"></param>  
        /// <returns></returns>  
        public static T GetEntity<T>(this DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0)
                return default(T);
            var dr = dt.CreateDataReader();
            return Mapper.Map<T>(dr);
        }


        /// <summary>
        ///将  List 转为实体对象  
        /// </summary>
        /// <typeparam name="TDestination"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static List<TDestination> GetEntity<TDestination>(this IEnumerable source)
        {

            return Mapper.Map<List<TDestination>>(source);
        }

        #endregion

        /// <summary>
        /// 初始化Mapper对象
        /// </summary>
        public static void InitGlobalMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<ActivityProfile>();
            });
        }
    }
}
