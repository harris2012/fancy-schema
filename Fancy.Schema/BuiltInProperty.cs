using Panosen.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Canos.Template
{
    /// <summary>
    /// BuiltInProperty
    /// </summary>
    public class BuiltInProperty
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// DisplayName
        /// </summary>
        public string DisplayName { get; private set; }

        /// <summary>
        /// ProgramType
        /// </summary>
        public ProgramType ProgramType { get; private set; }

        /// <summary>
        /// Id
        /// </summary>
        public static readonly BuiltInProperty Id = new BuiltInProperty { Name = "Id", DisplayName = "编号", ProgramType = ProgramType.INT };

        /// <summary>
        /// DataStatus
        /// </summary>
        public static readonly BuiltInProperty DataStatus = new BuiltInProperty { Name = "DataStatus", DisplayName = "状态", ProgramType = ProgramType.INT };

        /// <summary>
        /// Position
        /// </summary>
        public static readonly BuiltInProperty Position = new BuiltInProperty { Name = "Position", DisplayName = "位置", ProgramType = ProgramType.INT };

        /// <summary>
        /// CreateTime
        /// </summary>
        public static readonly BuiltInProperty CreateTime = new BuiltInProperty { Name = "CreateTime", DisplayName = "创建时间", ProgramType = ProgramType.DATETIME };

        /// <summary>
        /// LastUpdateTime
        /// </summary>
        public static readonly BuiltInProperty LastUpdateTime = new BuiltInProperty { Name = "LastUpdateTime", DisplayName = "最后更新时间", ProgramType = ProgramType.DATETIME };

        /// <summary>
        /// BuiltInProperty
        /// </summary>
        public static implicit operator BuiltInProperty(string name)
        {
            switch (name)
            {
                case "Id":
                    return Id;
                case "DataStatus":
                    return DataStatus;
                case "Position":
                    return Position;
                case "CreateTime":
                    return CreateTime;
                case "LastUpdateTime":
                    return LastUpdateTime;
                default:
                    return new BuiltInProperty { Name = name };
            }
        }
    }
}
