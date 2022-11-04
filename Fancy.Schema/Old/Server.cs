using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Schema
{
    /// <summary>
    /// 
    /// </summary>
    public class Server
    {
        /// <summary>
        /// 
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MysqlServerIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int MysqlServerPort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MysqlUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MysqlPassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MysqlDBName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SqliteLocalPath { get; set; }
    }
}
