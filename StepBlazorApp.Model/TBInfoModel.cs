using System;
using System.Collections.Generic;
using System.Text;

namespace StepBlazorApp.Model
{
    public class TBInfoModel
    {
        //--------------------------------------------------------------------------
        /// <summary>
        /// dbName --- 数据库名称
        /// </summary>
        public string dbName { get; set; }
        //--------------------------------------------------------------------------
        /// <summary>
        /// tbName --- 数据表名称
        /// </summary>
        public string tbName { get; set; }
        //--------------------------------------------------------------------------
        /// <summary>
        /// tbInfo --- 数据表信息
        /// </summary>
        public string tbInfo { get; set; }
        //--------------------------------------------------------------------------
        /// <summary>
        /// fdName --- 字段名称
        /// </summary>
        public string fdName { get; set; }
        //--------------------------------------------------------------------------
        /// <summary>
        /// fdInfo --- 字段信息
        /// </summary>
        public string fdInfo { get; set; }
        //--------------------------------------------------------------------------
        /// <summary>
        /// fdType --- 字段类型
        /// </summary>
        public string fdType { get; set; }
        //--------------------------------------------------------------------------
        /// <summary>
        /// fdLength --- 字段长度
        /// </summary>
        public int fdLength { get; set; }
        //--------------------------------------------------------------------------
        /// <summary>
        /// is_nullable --- 是否可空
        /// </summary>
        public bool is_nullable { get; set; }
        //--------------------------------------------------------------------------
    }
}
