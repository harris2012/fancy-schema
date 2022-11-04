using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Schema
{
    /// <summary>
    /// MetadataConstant
    /// </summary>
    public class MetadataConstant
    {
        /// <summary>
        /// MetadataName
        /// </summary>
        public string MetadataName { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }
    }

    /// <summary>
    /// MetadataConstantExtension
    /// </summary>
    public static class MetadataConstantExtension
    {

        /// <summary>
        /// SetName
        /// </summary>
        public static TMetadataConstant SetName<TMetadataConstant>(this TMetadataConstant metadataConstant, string Name)
            where TMetadataConstant : MetadataConstant
        {
            metadataConstant.Name = Name;

            return metadataConstant;
        }

        /// <summary>
        /// SetValue
        /// </summary>
        public static TMetadataConstant SetValue<TMetadataConstant>(this TMetadataConstant metadataConstant, string Value)
            where TMetadataConstant : MetadataConstant
        {
            metadataConstant.Value = Value;

            return metadataConstant;
        }

        /// <summary>
        /// SetTitle
        /// </summary>
        public static TMetadataConstant SetTitle<TMetadataConstant>(this TMetadataConstant metadataConstant, string Title)
            where TMetadataConstant : MetadataConstant
        {
            metadataConstant.Title = Title;

            return metadataConstant;
        }
    }
}
