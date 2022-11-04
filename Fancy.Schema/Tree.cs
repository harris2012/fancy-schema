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
    public class Tree
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

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
        /// `上级`来源属性
        /// </summary>
        public Property ParentProperty { get; set; }
    }

    /// <summary>
    /// TreeExtension
    /// </summary>
    public static class TreeExtension
    {
        /// <summary>
        /// SetMetaName
        /// </summary>
        public static TTree SetTreeName<TTree>(this TTree tree, string treeName)
            where TTree : Tree
        {
            tree.Name = treeName;

            return tree;
        }
    }
}
