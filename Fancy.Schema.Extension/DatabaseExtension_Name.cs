using System;
using System.Collections.Generic;
using System.Text;

namespace Fancy.Schema
{
    /// <summary>
    /// Database 扩展
    /// </summary>
    public static class DatabaseExtension
    {
        /// <summary>
        /// DatabaseContext
        /// </summary>
        public static string DatabaseContext(this Database database)
        {
            return $"{database.Name}Context";
        }

        /// <summary>
        /// DatabaseTransaction
        /// </summary>
        public static string DatabaseTransaction(this Database database)
        {
            return $"{database.Name}Transaction";
        }
    }
}
