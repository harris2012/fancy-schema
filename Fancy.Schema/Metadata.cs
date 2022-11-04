using Panosen.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Schema
{
    /// <summary>
    /// 元数据
    /// </summary>
    public class Metadata
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 元数据类型
        /// </summary>
        public MetadataType MetadataType { get; set; }

        /// <summary>
        /// 主键列
        /// </summary>
        public string KeyName { get; set; }

        /// <summary>
        /// 显示列
        /// </summary>
        public string TextName { get; set; }

        /// <summary>
        /// 主键文字
        /// </summary>
        public string KeyTitle { get; set; }

        /// <summary>
        /// 显示标题
        /// </summary>
        public string TextTitle { get; set; }

        /// <summary>
        /// MetaKey的类型
        /// </summary>
        public ProgramType ProgramType { get; set; }

        /// <summary>
        /// 来源主体的名称
        /// </summary>
        public Subject Subject { get; set; }

        /// <summary>
        /// 主键列对应的属性
        /// </summary>
        public Property KeyProperty { get; set; }

        /// <summary>
        /// 文字列对应的属性
        /// </summary>
        public Property TextProperty { get; set; }

        /// <summary>
        /// 属性字典
        /// </summary>
        public Dictionary<string, MetadataConstant> MetadataConstantMap { get; set; }
    }

    /// <summary>
    /// MetadataExtension
    /// </summary>
    public static class MetadataExtension
    {
        /// <summary>
        /// SetMetaName
        /// </summary>
        public static TMetadata SetMetaName<TMetadata>(this TMetadata metadata, string cascadeName)
            where TMetadata : Metadata
        {
            metadata.Name = cascadeName;

            return metadata;
        }

        /// <summary>
        /// SetMetadataType
        /// </summary>
        public static TMetadata SetMetadataType<TMetadata>(this TMetadata metadata, MetadataType metadataType)
            where TMetadata : Metadata
        {
            metadata.MetadataType = metadataType;

            return metadata;
        }

        /// <summary>
        /// SetKeyName
        /// </summary>
        public static TMetadata SetKeyName<TMetadata>(this TMetadata metadata, string keyName)
            where TMetadata : Metadata
        {
            metadata.KeyName = keyName;

            return metadata;
        }

        /// <summary>
        /// SetTextName
        /// </summary>
        public static TMetadata SetTextName<TMetadata>(this TMetadata metadata, string textName)
            where TMetadata : Metadata
        {
            metadata.TextName = textName;

            return metadata;
        }

        /// <summary>
        /// SetKeyTitle
        /// </summary>
        public static TMetadata SetKeyTitle<TMetadata>(this TMetadata metadata, string keyTitle)
            where TMetadata : Metadata
        {
            metadata.KeyTitle = keyTitle;

            return metadata;
        }

        /// <summary>
        /// SetTextTitle
        /// </summary>
        public static TMetadata SetTextTitle<TMetadata>(this TMetadata metadata, string textTitle)
            where TMetadata : Metadata
        {
            metadata.TextTitle = textTitle;

            return metadata;
        }

        /// <summary>
        /// SetProgramType
        /// </summary>
        public static TMetadata SetProgramType<TMetadata>(this TMetadata metadata, ProgramType programType)
            where TMetadata : Metadata
        {
            metadata.ProgramType = programType;

            return metadata;
        }

        /// <summary>
        /// SetSubject
        /// </summary>
        public static TMetadata SetSubject<TMetadata>(this TMetadata metadata, Subject subject)
            where TMetadata : Metadata
        {
            metadata.Subject = subject;

            return metadata;
        }

        /// <summary>
        /// SetKeyProperty
        /// </summary>
        public static TMetadata SetKeyProperty<TMetadata>(this TMetadata metadata, Property keyProperty)
            where TMetadata : Metadata
        {
            metadata.KeyProperty = keyProperty;

            return metadata;
        }

        /// <summary>
        /// SetTextProperty
        /// </summary>
        public static TMetadata SetTextProperty<TMetadata>(this TMetadata metadata, Property textProperty)
            where TMetadata : Metadata
        {
            metadata.TextProperty = textProperty;

            return metadata;
        }

        /// <summary>
        /// AddMetaname
        /// </summary>
        public static TMetadata AddMetadataConstant<TMetadata>(this TMetadata metadata, MetadataConstant metadataConstant)
            where TMetadata : Metadata
        {
            if (metadata.MetadataConstantMap == null)
            {
                metadata.MetadataConstantMap = new Dictionary<string, MetadataConstant>();
            }

            metadata.MetadataConstantMap.Add(metadataConstant.Name, metadataConstant);

            return metadata;
        }

        /// <summary>
        /// AddMetaname
        /// </summary>
        public static MetadataConstant AddMetadataConstant<TMetadata>(this TMetadata metadata, string name)
            where TMetadata : Metadata
        {
            if (metadata.MetadataConstantMap == null)
            {
                metadata.MetadataConstantMap = new Dictionary<string, MetadataConstant>();
            }

            MetadataConstant metadataConstant = new MetadataConstant();
            metadataConstant.Name = name;

            metadata.MetadataConstantMap.Add(name, metadataConstant);

            return metadataConstant;
        }
    }
}
