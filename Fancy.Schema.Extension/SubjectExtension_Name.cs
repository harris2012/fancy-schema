using System;
using System.Collections.Generic;
using System.Text;

namespace Fancy.Schema
{
    /// <summary>
    /// 主体名称扩展
    /// </summary>
    public static partial class SubjectExtension
    {

        #region CreateSubject

        /// <summary>
        /// CreateSubject
        /// </summary>
        public static string CreateSubject(this Subject subject) { return $"Create{subject.Name}"; }

        /// <summary>
        /// CreateSubjectService
        /// </summary>
        public static string CreateSubjectService(this Subject subject) { return $"{subject.CreateSubject()}Service"; }

        /// <summary>
        /// CreateSubjectRequest
        /// </summary>
        public static string CreateSubjectRequest(this Subject subject) { return $"{subject.CreateSubject()}Request"; }

        /// <summary>
        /// CreateSubjectResponse
        /// </summary>
        public static string CreateSubjectResponse(this Subject subject) { return $"{subject.CreateSubject()}Response"; }

        #endregion

        #region FetchSubject

        /// <summary>
        /// FetchSubject
        /// </summary>
        public static string FetchSubject(this Subject subject) { return $"Fetch{subject.Name}"; }

        /// <summary>
        /// FetchSubjectService
        /// </summary>
        public static string FetchSubjectService(this Subject subject) { return $"{subject.FetchSubject()}Service"; }

        /// <summary>
        /// FetchSubjectRequest
        /// </summary>
        public static string FetchSubjectRequest(this Subject subject) { return $"{subject.FetchSubject()}Request"; }

        /// <summary>
        /// FetchSubjectResponse
        /// </summary>
        public static string FetchSubjectResponse(this Subject subject) { return $"{subject.FetchSubject()}Response"; }

        #endregion

        #region FetchSubjectList

        /// <summary>
        /// FetchSubjectList
        /// </summary>
        public static string FetchSubjectList(this Subject subject) { return $"Fetch{subject.Name}List"; }

        /// <summary>
        /// FetchSubjectListService
        /// </summary>
        public static string FetchSubjectListService(this Subject subject) { return $"{subject.FetchSubjectList()}Service"; }

        /// <summary>
        /// FetchSubjectListRequest
        /// </summary>
        public static string FetchSubjectListRequest(this Subject subject) { return $"{subject.FetchSubjectList()}Request"; }

        /// <summary>
        /// FetchSubjectListResponse
        /// </summary>
        public static string FetchSubjectListResponse(this Subject subject) { return $"{subject.FetchSubjectList()}Response"; }

        #endregion

        #region UpdateSubject

        /// <summary>
        /// UpdateSubject
        /// </summary>
        public static string UpdateSubject(this Subject subject) { return $"Update{subject.Name}"; }

        /// <summary>
        /// UpdateSubjectService
        /// </summary>
        public static string UpdateSubjectService(this Subject subject) { return $"{subject.UpdateSubject()}Service"; }

        /// <summary>
        /// UpdateSubjectRequest
        /// </summary>
        public static string UpdateSubjectRequest(this Subject subject) { return $"{subject.UpdateSubject()}Request"; }

        /// <summary>
        /// UpdateSubjectResponse
        /// </summary>
        public static string UpdateSubjectResponse(this Subject subject) { return $"{subject.UpdateSubject()}Response"; }

        #endregion

        #region DisableSubject

        /// <summary>
        /// DisableSubject
        /// </summary>
        public static string DisableSubject(this Subject subject) { return $"Disable{subject.Name}"; }

        /// <summary>
        /// DisableSubjectService
        /// </summary>
        public static string DisableSubjectService(this Subject subject) { return $"{subject.DisableSubject()}Service"; }

        /// <summary>
        /// DisableSubjectRequest
        /// </summary>
        public static string DisableSubjectRequest(this Subject subject) { return $"{subject.DisableSubject()}Request"; }

        /// <summary>
        /// DisableSubjectResponse
        /// </summary>
        public static string DisableSubjectResponse(this Subject subject) { return $"{subject.DisableSubject()}Response"; }

        #endregion

        #region EnableSubject

        /// <summary>
        /// EnableSubject
        /// </summary>
        public static string EnableSubject(this Subject subject) { return $"Enable{subject.Name}"; }

        /// <summary>
        /// EnableSubjectService
        /// </summary>
        public static string EnableSubjectService(this Subject subject) { return $"{subject.EnableSubject()}Service"; }

        /// <summary>
        /// EnableSubjectRequest
        /// </summary>
        public static string EnableSubjectRequest(this Subject subject) { return $"{subject.EnableSubject()}Request"; }

        /// <summary>
        /// EnableSubjectResponse
        /// </summary>
        public static string EnableSubjectResponse(this Subject subject) { return $"{subject.EnableSubject()}Response"; }

        #endregion

        #region LockSubject

        /// <summary>
        /// LockSubject
        /// </summary>
        public static string LockSubject(this Subject subject) { return $"Lock{subject.Name}"; }

        /// <summary>
        /// LockSubjectService
        /// </summary>
        public static string LockSubjectService(this Subject subject) { return $"{subject.LockSubject()}Service"; }

        /// <summary>
        /// LockSubjectRequest
        /// </summary>
        public static string LockSubjectRequest(this Subject subject) { return $"{subject.LockSubject()}Request"; }

        /// <summary>
        /// LockSubjectResponse
        /// </summary>
        public static string LockSubjectResponse(this Subject subject) { return $"{subject.LockSubject()}Response"; }

        #endregion

        #region UnlockSubject

        /// <summary>
        /// UnlockSubject
        /// </summary>
        public static string UnlockSubject(this Subject subject) { return $"Unlock{subject.Name}"; }

        /// <summary>
        /// UnlockSubjectService
        /// </summary>
        public static string UnlockSubjectService(this Subject subject) { return $"{subject.UnlockSubject()}Service"; }

        /// <summary>
        /// UnlockSubjectRequest
        /// </summary>
        public static string UnlockSubjectRequest(this Subject subject) { return $"{subject.UnlockSubject()}Request"; }

        /// <summary>
        /// UnlockSubjectResponse
        /// </summary>
        public static string UnlockSubjectResponse(this Subject subject) { return $"{subject.UnlockSubject()}Response"; }

        #endregion


        /*

        #region {item}

        /// <summary>
        /// {item}
        /// </summary>
        public static string {item}(this Subject subject) { return $"Fetch{subject.Name}List"; }

        /// <summary>
        /// {item}Service
        /// </summary>
        public static string {item}Service(this Subject subject) { return $"{subject.{item}()}Service"; }

        /// <summary>
        /// {item}Request
        /// </summary>
        public static string {item}Request(this Subject subject) { return $"{subject.{item}()}Request"; }

        /// <summary>
        /// {item}Response
        /// </summary>
        public static string {item}Response(this Subject subject) { return $"{subject.{item}()}Response"; }

        #endregion
         */

    }
}
