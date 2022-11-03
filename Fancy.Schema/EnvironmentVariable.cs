using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Canos.Template
{
    /// <summary>
    /// 环境变量
    /// </summary>
    public class EnvironmentVariable
    {
        /// <summary>
        /// 环境变量的Key
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 编程类型
        /// </summary>
        public string ProgramType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
