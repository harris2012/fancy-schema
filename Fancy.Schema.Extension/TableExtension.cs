using System;
using System.Collections.Generic;
using System.Text;

namespace Fancy.Schema
{
    /// <summary>
    /// 表扩展
    /// </summary>
    public static class TableExtension
    {
        /// <summary>
        /// TableEntity
        /// </summary>
        public static string TableEntity(this Table table) { return $"{table.Name}Entity"; }
    }
}
