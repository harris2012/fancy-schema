using System.Collections.Generic;

namespace Fancy.Schema
{
    /// <summary>
    /// SubjectExtension
    /// </summary>
    public static partial class SubjectExtension
    {
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
