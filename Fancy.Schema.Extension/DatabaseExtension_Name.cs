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
        /// DatabaseTransaciton
        /// </summary>
        public static string DatabaseTransaciton(this Database database)
        {
            return $"{database.Name}Transaciton";
        }
    }
}
