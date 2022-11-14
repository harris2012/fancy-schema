using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Schema
{
    /// <summary>
    /// 字段
    /// </summary>
    public class Field
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 真实名称
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// 字段所属的表
        /// </summary>
        public string Table { get; set; }

        /// <summary>
        /// 不带长度的数据类型
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// .net数据类型
        /// </summary>
        public string CSharpType { get; set; }

        /// <summary>
        /// 自增长
        /// </summary>
        public bool AutoIncrement { get; set; }
    }
}
