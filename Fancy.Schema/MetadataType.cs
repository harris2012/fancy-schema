using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Canos.Template
{
    /// <summary>
    /// 元数据类型
    /// </summary>
    public enum MetadataType
    {
        /// <summary>
        /// 未配置
        /// </summary>
        None = 0,

        /// <summary>
        /// 标准元数据
        /// </summary>
        Standard,

        /// <summary>
        /// 内置元数据
        /// </summary>
        BuiltIn
    }
}
