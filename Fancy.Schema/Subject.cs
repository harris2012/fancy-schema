using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Schema
{
    /// <summary>
    /// 主体
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 属性字典
        /// </summary>
        public Dictionary<string, Property> PropertyMap { get; set; }

        /// <summary>
        /// 关联的数据数据库
        /// </summary>
        public List<string> RelativeDatabaseList { get; set; }
    }
}
