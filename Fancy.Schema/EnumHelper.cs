using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Schema
{
    /// <summary>
    /// EnumHelper
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// ToPropertyFrom
        /// </summary>
        public static PropertyFrom ToPropertyFrom(string propertyFrom)
        {
            switch (propertyFrom)
            {
                case "InputOfInt":
                    return PropertyFrom.InputOfInt;
                case "InputOfLong":
                    return PropertyFrom.InputOfLong;
                case "InputOfDecimal":
                    return PropertyFrom.InputOfDecimal;
                case "InputOfDateTime":
                    return PropertyFrom.InputOfDateTime;
                case "InputOfString":
                    return PropertyFrom.InputOfString;
                case "CheckboxOfBoolean":
                    return PropertyFrom.CheckboxOfBoolean;
                case "RadioGroupOfBoolean":
                    return PropertyFrom.RadioGroupOfBoolean;
                case "RadioGroupOfMetadata":
                    return PropertyFrom.RadioGroupOfMetadata;
                case "CheckboxGroupOfMetadata":
                    return PropertyFrom.CheckboxGroupOfMetadata;
                case "DropdownOfCascade":
                    return PropertyFrom.DropdownOfCascade;
                case "DropdownOfMetadata":
                    return PropertyFrom.DropdownOfMetadata;
                case "DropdownOfTree":
                    return PropertyFrom.DropdownOfTree;

                default:
                    return PropertyFrom.None;
            }
        }

        /// <summary>
        /// ToMetadataType
        /// </summary>
        public static MetadataType ToMetadataType(string metadataType)
        {
            switch (metadataType)
            {
                case "Standard":
                    return MetadataType.Standard;

                case "BuiltIn":
                    return MetadataType.BuiltIn;

                default:
                    return MetadataType.None;
            }
        }

        /// <summary>
        /// ToRepositoryType
        /// </summary>
        public static RepositoryType ToRepositoryType(string repositoryType)
        {
            switch (repositoryType)
            {
                case "Mysql":
                    return RepositoryType.Mysql;
                case "Sqlite":
                    return RepositoryType.Sqlite;
                case "Mssql":
                    return RepositoryType.Mssql;
                case "Oracle":
                    return RepositoryType.Oracle;
                case "Postgre":
                    return RepositoryType.Postgre;
                default:
                    return RepositoryType.None;
            }
        }
    }
}
