namespace Fancy.Schema
{
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
        /// SetPropertyType
        /// </summary>
        public static TProperty SetPropertyType<TProperty>(this TProperty property, MetaPropertyType propertyType)
            where TProperty : Property
        {
            property.PropertyType = propertyType;

            return property;
        }
    }
}
