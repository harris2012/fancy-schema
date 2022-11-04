using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Schema
{
    /// <summary>
    /// 属性
    /// </summary>
    public class Property
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 该表字段是否来自于元数据
        /// </summary>
        public PropertyFrom PropertyFrom { get; set; }

        /// <summary>
        /// 通用编程语言类型
        /// </summary>
        public MetaPropertyType PropertyType { get; set; }

        /// <summary>
        /// 元数据名称
        /// </summary>
        public Metadata Metadata { get; set; }

        /// <summary>
        /// 级联名称
        /// </summary>
        public Cascade Cascade { get; set; }

        /// <summary>
        /// 级联名称
        /// </summary>
        public Tree Tree { get; set; }

        /// <summary>
        /// 必填
        /// </summary>
        public bool Required { get; set; }

        /// <summary>
        /// 检查录入文字的格式，正则表达式
        /// </summary>
        public string Pattern { get; set; }

        /// <summary>
        /// 可以搜索
        /// </summary>
        public bool Searchable { get; set; }

        /// <summary>
        /// 自增长
        /// </summary>
        public bool AutoIncrement { get; set; }
    }

    /// <summary>
    /// PropertyExtension
    /// </summary>
    public static class PropertyExtension
    {
        /// <summary>
        /// SetName
        /// </summary>
        public static TProperty SetName<TProperty>(this TProperty property, string name)
            where TProperty : Property
        {
            property.Name = name;

            return property;
        }

        /// <summary>
        /// SetDisplayName
        /// </summary>
        public static TProperty SetDisplayName<TProperty>(this TProperty property, string displayName)
            where TProperty : Property
        {
            property.DisplayName = displayName;

            return property;
        }

        /// <summary>
        /// SetPropertyFrom
        /// </summary>
        public static TProperty SetPropertyFrom<TProperty>(this TProperty property, PropertyFrom propertyFrom)
            where TProperty : Property
        {
            property.PropertyFrom = propertyFrom;

            return property;
        }

        /// <summary>
        /// SetPropertyType
        /// </summary>
        public static TProperty SetPropertyType<TProperty>(this TProperty property, MetaPropertyType propertyType)
            where TProperty : Property
        {
            property.PropertyType = propertyType;

            return property;
        }

        /// <summary>
        /// SetMetadata
        /// </summary>
        public static TProperty SetMetadata<TProperty>(this TProperty property, Metadata metadata)
            where TProperty : Property
        {
            property.Metadata = metadata;

            return property;
        }

        /// <summary>
        /// SetCascade
        /// </summary>
        public static TProperty SetCascade<TProperty>(this TProperty property, Cascade cascade)
            where TProperty : Property
        {
            property.Cascade = cascade;

            return property;
        }

        /// <summary>
        /// SetRequired
        /// </summary>
        public static TProperty SetRequired<TProperty>(this TProperty property, bool required)
            where TProperty : Property
        {
            property.Required = required;

            return property;
        }

        /// <summary>
        /// SetPattern
        /// </summary>
        public static TProperty SetPattern<TProperty>(this TProperty property, string pattern)
            where TProperty : Property
        {
            property.Pattern = pattern;

            return property;
        }

        /// <summary>
        /// SetSearchable
        /// </summary>
        public static TProperty SetSearchable<TProperty>(this TProperty property, bool searchable)
            where TProperty : Property
        {
            property.Searchable = searchable;

            return property;
        }

        /// <summary>
        /// SetAutoIncrement
        /// </summary>
        public static TProperty SetAutoIncrement<TProperty>(this TProperty property, bool autoIncrement)
            where TProperty : Property
        {
            property.AutoIncrement = autoIncrement;

            return property;
        }
    }
}
