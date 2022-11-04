using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Schema
{
    /// <summary>
    /// 级联项
    /// </summary>
    public class CascadeItem
    {
        /// <summary>
        /// 级联项来源主体
        /// </summary>
        public Subject Subject { get; set; }

        /// <summary>
        /// `值`来源属性
        /// </summary>
        public Property ValueProperty { get; set; }

        /// <summary>
        /// `文字`来源属性
        /// </summary>
        public Property LabelProperty { get; set; }

        /// <summary>
        /// `过滤`来源属性
        /// </summary>
        public Property MaskProperty { get; set; }

        /// <summary>
        /// 父级级联项
        /// </summary>
        public CascadeItem ParentCascadeItem { get; set; }
    }

    /// <summary>
    /// CascadeItemExtension
    /// </summary>
    public static class CascadeItemExtension
    {

        /// <summary>
        /// SetSubject
        /// </summary>
        public static TCascadeItem SetSubject<TCascadeItem>(this TCascadeItem cascadeItem, Subject subject)
            where TCascadeItem : CascadeItem
        {
            cascadeItem.Subject = subject;

            return cascadeItem;
        }

        /// <summary>
        /// SetValueProperty
        /// </summary>
        public static TCascadeItem SetValueProperty<TCascadeItem>(this TCascadeItem cascadeItem, Property valueProperty)
            where TCascadeItem : CascadeItem
        {
            cascadeItem.ValueProperty = valueProperty;

            return cascadeItem;
        }

        /// <summary>
        /// SetLabelProperty
        /// </summary>
        public static TCascadeItem SetLabelProperty<TCascadeItem>(this TCascadeItem cascadeItem, Property labelProperty)
            where TCascadeItem : CascadeItem
        {
            cascadeItem.LabelProperty = labelProperty;

            return cascadeItem;
        }

        /// <summary>
        /// SetMaskProperty
        /// </summary>
        public static TCascadeItem SetMaskProperty<TCascadeItem>(this TCascadeItem cascadeItem, Property maskProperty)
            where TCascadeItem : CascadeItem
        {
            cascadeItem.MaskProperty = maskProperty;

            return cascadeItem;
        }

        /// <summary>
        /// SetMaskProperty
        /// </summary>
        public static TCascadeItem SetParentCascadeItem<TCascadeItem>(this TCascadeItem cascadeItem, CascadeItem parentCascadeItem)
            where TCascadeItem : CascadeItem
        {
            cascadeItem.ParentCascadeItem = parentCascadeItem;

            return cascadeItem;
        }

        /// <summary>
        /// CreateParentCascadeItem
        /// </summary>
        public static TCascadeItem AddParentCascadeItem<TCascadeItem>(this TCascadeItem cascadeItem)
            where TCascadeItem : CascadeItem, new()
        {
            TCascadeItem parentCascadeItem = new TCascadeItem();

            cascadeItem.ParentCascadeItem = parentCascadeItem;

            return parentCascadeItem;
        }
    }
}
