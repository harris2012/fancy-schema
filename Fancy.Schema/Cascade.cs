using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Canos.Template
{
    /// <summary>
    /// 级联
    /// </summary>
    public class Cascade
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 级联项
        /// </summary>
        public CascadeItem CascadeItem { get; set; }
    }

    /// <summary>
    /// MetadataExtension
    /// </summary>
    public static class CascadeExtension
    {
        /// <summary>
        /// SetMetaName
        /// </summary>
        public static TCascade SetMetaName<TCascade>(this TCascade cascade, string cascadeName)
            where TCascade : Cascade
        {
            cascade.Name = cascadeName;

            return cascade;
        }

        /// <summary>
        /// SetCascadeItem
        /// </summary>
        public static TCascade SetCascadeItem<TCascade>(this TCascade cascade, CascadeItem cascadeItem)
            where TCascade : Cascade
        {
            cascade.CascadeItem = cascadeItem;

            return cascade;
        }

        /// <summary>
        /// CreateCascadeItem
        /// </summary>
        public static CascadeItem CreateCascadeItem<TCascade>(this TCascade cascade)
            where TCascade : Cascade
        {
            CascadeItem cascadeItem = new CascadeItem();

            cascade.CascadeItem = cascadeItem;

            return cascadeItem;
        }
    }
}
