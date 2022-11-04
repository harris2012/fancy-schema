using System;
using System.Collections.Generic;
using System.Text;

namespace Fancy.Schema
{
    /// <summary>
    /// Project 扩展
    /// </summary>
    public static class ProjectExtension
    {

        /// <summary>
        /// Project.Configure
        /// </summary>
        public static string ProjectConfigure(this Project project)
        {
            return $"{project.Name}.Configure";
        }

        /// <summary>
        /// Project.Contract
        /// </summary>
        public static string ProjectContract(this Project project)
        {
            return $"{project.Name}.Contract";
        }

        /// <summary>
        /// Project.Constant
        /// </summary>
        public static string ProjectConstant(this Project project)
        {
            return $"{project.Name}.Constant";
        }

        /// <summary>
        /// Project.Convertor
        /// </summary>
        public static string ProjectConvertor(this Project project)
        {
            return $"{project.Name}.Convertor";
        }

        /// <summary>
        /// Project.Hash
        /// </summary>
        public static string ProjectHash(this Project project)
        {
            return $"{project.Name}.Hash";
        }

        /// <summary>
        /// Project.Options
        /// </summary>
        public static string ProjectOptions(this Project project)
        {
            return $"{project.Name}.Options";
        }

        /// <summary>
        /// Project.Repository
        /// </summary>
        public static string ProjectRepository(this Project project)
        {
            return $"{project.Name}.Repository";
        }

        /// <summary>
        /// Project.Service
        /// </summary>
        public static string ProjectService(this Project project)
        {
            return $"{project.Name}.Service";
        }
    }
}
