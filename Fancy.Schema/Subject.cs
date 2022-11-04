using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Schema
{
    /// <summary>
    /// 主体
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 主属性
        /// </summary>
        public Property PrimaryProperty { get; set; }

        /// <summary>
        /// 属性字典
        /// </summary>
        public Dictionary<string, Property> PropertyMap { get; set; }
    }

    /// <summary>
    /// SubjectExtension
    /// </summary>
    public static partial class SubjectExtension
    {

        /// <summary>
        /// subject.Name + subject.PrimaryProperty.Name
        /// </summary>
        /// <returns></returns>
        public static string PrimaryPropertyFullName(this Subject subject)
        {
            if (subject.PrimaryProperty == null)
            {
                return string.Empty;
            }

            return subject.Name + subject.PrimaryProperty.Name;
        }

        /// <summary>
        /// SetName
        /// </summary>
        public static TSubject SetName<TSubject>(this TSubject subject, string name)
            where TSubject : Subject
        {
            subject.Name = name;

            return subject;
        }

        /// <summary>
        /// SetDisplayName
        /// </summary>
        public static TSubject SetDisplayName<TSubject>(this TSubject subject, string displayName)
            where TSubject : Subject
        {
            subject.DisplayName = displayName;

            return subject;
        }

        /// <summary>
        /// AddProperty
        /// </summary>
        public static TSubject AddProperty<TSubject>(this TSubject subject, Property property)
            where TSubject : Subject
        {
            if (subject.PropertyMap == null)
            {
                subject.PropertyMap = new Dictionary<string, Property>();
            }

            subject.PropertyMap.Add(property.Name, property);

            return subject;
        }

        /// <summary>
        /// AddProperty
        /// </summary>
        public static Property AddProperty<TSubject>(this TSubject subject, string propertyName)
            where TSubject : Subject
        {
            if (subject.PropertyMap == null)
            {
                subject.PropertyMap = new Dictionary<string, Property>();
            }

            Property property = new Property();
            property.Name = propertyName;
            subject.PropertyMap.Add(property.Name, property);

            return property;
        }
    }
}
