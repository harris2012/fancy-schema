using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Canos.Template
{
    /// <summary>
    /// SimpleObject
    /// </summary>
    public abstract class SimpleObject
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// SimpleObjectType
        /// </summary>
        public abstract SimpleObjectType SimpleObjectType { get; }
    }

    /// <summary>
    /// SimpleObjectType
    /// </summary>
    public enum SimpleObjectType
    {
        /// <summary>
        /// None
        /// </summary>
        None,

        /// <summary>
        /// Subject
        /// </summary>
        Subject,

        /// <summary>
        /// Metadata
        /// </summary>
        Metadata,

        /// <summary>
        /// Cascade
        /// </summary>
        Cascade,

        /// <summary>
        /// Tree
        /// </summary>
        Tree
    }
}
