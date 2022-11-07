using System;
using System.Collections.Generic;
using System.Text;

namespace Fancy.Schema
{
    /// <summary>
    /// 字典
    /// </summary>
    public class Maps
    {
        /// <summary>
        /// 数据库
        /// </summary>
        public Dictionary<string, Database> DatabaseMap { get; set; }

        /// <summary>
        /// 表
        /// </summary>
        public Dictionary<string, Table> TableMap { get; set; }

        /// <summary>
        /// 字段
        /// </summary>
        public Dictionary<string, Field> FieldMap { get; set; }

        /// <summary>
        /// 主体
        /// </summary>
        public Dictionary<string, Subject> SubjectMap { get; set; }

        /// <summary>
        /// 属性
        /// </summary>
        public Dictionary<string, Property> PropertyMap { get; set; }

    }
}
