using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Canos.Template
{
    /// <summary>
    /// 属性来源
    /// </summary>
    public enum PropertyFrom
    {
        ///// <summary>
        ///// 基础录入
        ///// </summary>
        //Basic,

        ///// <summary>
        ///// 元数据
        ///// </summary>
        //Metadata,

        ///// <summary>
        ///// 级联
        ///// </summary>
        //Cascade,

        ///// <summary>
        ///// 树
        ///// </summary>
        //Tree,

        /// <summary>
        /// 输入int
        /// </summary>
        InputOfInt,

        /// <summary>
        /// 输入long
        /// </summary>
        InputOfLong,

        /// <summary>
        /// 输入decimal
        /// </summary>
        InputOfDecimal,

        /// <summary>
        /// 输入DateTime
        /// </summary>
        InputOfDateTime,

        /// <summary>
        /// 输入字符串
        /// </summary>
        InputOfString,

        /// <summary>
        /// 单选框
        /// </summary>
        CheckboxOfBoolean,

        /// <summary>
        /// [单选]单选框组
        /// </summary>
        RadioGroupOfBoolean,

        /// <summary>
        /// [单选]单选框组
        /// </summary>
        RadioGroupOfMetadata,

        /// <summary>
        /// [多选]多选框组
        /// </summary>
        CheckboxGroupOfMetadata,

        /// <summary>
        /// [单选]下拉框
        /// </summary>
        DropdownOfMetadata,

        /// <summary>
        /// [单选]级联
        /// </summary>
        DropdownOfCascade,

        /// <summary>
        /// [单选]树
        /// </summary>
        DropdownOfTree,

        /// <summary>
        /// 未配置
        /// </summary>
        None
    }
}
