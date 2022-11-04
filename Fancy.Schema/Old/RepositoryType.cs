using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Schema
{
    /// <summary>
    /// RepositoryTypeConstant
    /// </summary>
    public enum RepositoryType
    {
        /// <summary>
        /// 未配置
        /// </summary>
        None = 0,

        /// <summary>
        /// Mysql
        /// </summary>
        Mysql,

        /// <summary>
        /// Sqlite
        /// </summary>
        Sqlite,

        /// <summary>
        /// Mssql
        /// </summary>
        Mssql,

        /// <summary>
        /// Oracle
        /// </summary>
        Oracle,

        /// <summary>
        /// PostgreSql
        /// </summary>
        Postgre
    }
}
