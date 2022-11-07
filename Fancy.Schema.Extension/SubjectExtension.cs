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
    }
}
