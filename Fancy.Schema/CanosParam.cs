using Fancy.Schema;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fancy.Schema
{
    /// <summary>
    /// CanosParam
    /// </summary>
    public class CanosParam
    {
        /// <summary>
        /// ReleaseNo
        /// </summary>
        public string ReleaseNo { get; set; }

        /// <summary>
        /// 项目
        /// </summary>
        public Project Project { get; set; }

        /// <summary>
        /// 数据库
        /// </summary>
        public Server Server { get; set; }

        /// <summary>
        /// 主体
        /// </summary>
        public Dictionary<string, Subject> SubjectMap { get; set; }

        /// <summary>
        /// 元数据
        /// </summary>
        public Dictionary<string, Metadata> MetadataMap { get; set; }

        /// <summary>
        /// 级联
        /// </summary>
        public Dictionary<string, Cascade> CascadeMap { get; set; }

        /// <summary>
        /// 级联
        /// </summary>
        public Dictionary<string, Tree> TreeMap { get; set; }
    }

    /// <summary>
    /// CanosParamExtension
    /// </summary>
    public static class CanosParamExtension
    {
        /// <summary>
        /// AddSubject
        /// </summary>
        public static TCanosParam AddSubject<TCanosParam>(this TCanosParam canosParam, Subject subject)
            where TCanosParam : CanosParam
        {
            if (canosParam.SubjectMap == null)
            {
                canosParam.SubjectMap = new Dictionary<string, Subject>();
            }

            canosParam.SubjectMap.Add(subject.Name, subject);

            return canosParam;
        }

        /// <summary>
        /// AddSubject
        /// </summary>
        public static Subject AddSubject<TCanosParam>(this TCanosParam canosParam, string subjectName)
            where TCanosParam : CanosParam
        {
            if (canosParam.SubjectMap == null)
            {
                canosParam.SubjectMap = new Dictionary<string, Subject>();
            }

            Subject subject = new Subject();
            subject.Name = subjectName;
            canosParam.SubjectMap.Add(subjectName, subject);

            return subject;
        }

        /// <summary>
        /// AddMetadata
        /// </summary>
        public static TCanosParam AddMetadata<TCanosParam>(this TCanosParam canosParam, Metadata metadata)
            where TCanosParam : CanosParam
        {
            if (canosParam.MetadataMap == null)
            {
                canosParam.MetadataMap = new Dictionary<string, Metadata>();
            }

            canosParam.MetadataMap.Add(metadata.Name, metadata);

            return canosParam;
        }

        /// <summary>
        /// AddMetadata
        /// </summary>
        public static Metadata AddMetadata<TCanosParam>(this TCanosParam canosParam, string metadataName)
            where TCanosParam : CanosParam
        {
            if (canosParam.MetadataMap == null)
            {
                canosParam.MetadataMap = new Dictionary<string, Metadata>();
            }

            Metadata metadata = new Metadata();
            metadata.Name = metadataName;
            canosParam.MetadataMap.Add(metadataName, metadata);

            return metadata;
        }

        /// <summary>
        /// AddCascade
        /// </summary>
        public static TCanosParam AddCascade<TCanosParam>(this TCanosParam canosParam, Cascade cascade)
            where TCanosParam : CanosParam
        {
            if (canosParam.CascadeMap == null)
            {
                canosParam.CascadeMap = new Dictionary<string, Cascade>();
            }

            canosParam.CascadeMap.Add(cascade.Name, cascade);

            return canosParam;
        }

        /// <summary>
        /// AddCascade
        /// </summary>
        public static Cascade AddCascade<TCanosParam>(this TCanosParam canosParam, string cascadeName)
            where TCanosParam : CanosParam
        {
            if (canosParam.CascadeMap == null)
            {
                canosParam.CascadeMap = new Dictionary<string, Cascade>();
            }

            Cascade cascade = new Cascade();
            cascade.Name = cascadeName;
            canosParam.CascadeMap.Add(cascadeName, cascade);

            return cascade;
        }

        /// <summary>
        /// AddTree
        /// </summary>
        public static TCanosParam AddTree<TCanosParam>(this TCanosParam canosParam, Tree tree)
            where TCanosParam : CanosParam
        {
            if (canosParam.TreeMap == null)
            {
                canosParam.TreeMap = new Dictionary<string, Tree>();
            }

            canosParam.TreeMap.Add(tree.Name, tree);

            return canosParam;
        }

        /// <summary>
        /// AddTree
        /// </summary>
        public static Tree AddTree<TCanosParam>(this TCanosParam canosParam, string treeName)
            where TCanosParam : CanosParam
        {
            if (canosParam.TreeMap == null)
            {
                canosParam.TreeMap = new Dictionary<string, Tree>();
            }

            Tree Tree = new Tree();
            Tree.Name = treeName;
            canosParam.TreeMap.Add(treeName, Tree);

            return Tree;
        }
    }
}
